using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport.Core;
using SwissTransport.Models;

namespace MyTransportApp
{
    public partial class MyTransportAppForm : Form
    {
        ITransport transport = new Transport();
        //Station station = new Station();

        public MyTransportAppForm()
        {
            InitializeComponent();
            //Aktuelles Datum + Uhrzeit
            DatePicker.Text = DateTime.Now.ToString("yyyy-MM-dd");
            TimePicker.Text = DateTime.Now.ToString("HH:mm");
        }

        private void SearchButtonClick(object sender, EventArgs e)
        {
            //Rows leeren
            this.ConnectionSearchDataGridView.Rows.Clear();
            try
            {
                //Falls die Pflichfelder Von+Nach leer sind, gibt es eine Fehlermeldung
                if (FromComboBox.Text != "" && ToComboBox.Text != "")
                {
                    //Alle Verbindungen wo Station mit User-Stationeingabe übereinstimmt, in Objekt speichern
                    var connections = transport.GetConnections(FromComboBox.Text, ToComboBox.Text, DatePicker.Value, TimePicker.Value, 7);
                    //Nur wenn Verbindungen gefunden wurden
                    if (connections.ConnectionList.Count != 0)
                    {
                        //Diese Verbindungen wo jetzt ok sind, muss ich einzeln in eine Variable speichern, 
                        //damit ich diese in die AusgabeTabelle einfügen kann
                        foreach (Connection singleCon in connections.ConnectionList)
                        {
                            //List<Connection> ist eine Liste mit dem Datentyp Connection
                            this.ConnectionSearchDataGridView.Rows.Add(singleCon.From.Departure.ToString().Substring(0, 10), singleCon.From.Departure.ToString().Substring(11, 5), singleCon.From.Station.Name, singleCon.To.Station.Name, singleCon.To.Arrival.ToString().Substring(11, 5), singleCon.Duration.Substring(3, 5), singleCon.From.Platform);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Keine Verbindung zwischen den Stationen gefunden. Bitte ändern Sie Ihre Auswahl.");
                    }
                }
                else
                {
                    MessageBox.Show("Bitte geben Sie eine Start- UND Endstation ein.");
                }
            }
            catch
            {
                MessageBox.Show("Fehler: Bitte überprüfen Sie Ihre Eingabe.");
            }
        }

        private void SearchDepartureTabelClick(object sender, EventArgs e)
        {
            //Rows leeren
            this.DepartureTableDataGridView.Rows.Clear();
            try
            {
                if (DepartureTabelComboBox.Text != "")
                {
                    DateTime time = DateTime.Now;
                    StationBoardRoot connections = transport.GetStationBoard(DepartureTabelComboBox.Text, "0", time, 7);

                    if (connections.Entries.Count != 0)
                    {
                        foreach (var singleCon in connections.Entries) //Entries = List<StationBoard>
                        { 
                            //List<Connection> ist eine Liste mit dem Datentyp Connection
                            this.DepartureTableDataGridView.Rows.Add(singleCon.Stop.Departure.ToString().Substring(11, 5), singleCon.To.ToString(),singleCon.Name.ToString());
                        }
                    }
                    else 
                    {
                        MessageBox.Show("Es gibt aktuell keine Abfahrten von dieser Station.");
                    }
                }
                else
                {
                    MessageBox.Show("Bitte geben Sie eine Station ein.");
                }
            }
            catch
            {
                MessageBox.Show("Fehler: Bitte überprüfen Sie Ihre Eingabe.");
            }
        }

        //Feldinhalt von From und To tauschen
        private void ChangeStationFieldsButtonClick(object sender, EventArgs e)
        {
            var fromStation = FromComboBox.Text;
            var toStation = ToComboBox.Text;

            FromComboBox.Text = toStation;
            ToComboBox.Text = fromStation;
        }

        //Stationsvorschläge beim tippen
        private void SuggestedSearch(ComboBox combobox, KeyEventArgs e) 
        {
            if (e.KeyCode != Keys.Down && e.KeyCode != Keys.Up && e.KeyCode != Keys.Enter && e.KeyCode != Keys.Left && e.KeyCode != Keys.Right)
            {
                //Wenn Combobox nicht leer
                if (combobox.Text != "")
                {
                    try
                    {
                        string eingabee = combobox.Text;
                        //DropDown Items leeren
                        combobox.Items.Clear();
                        //Curser ans Ende setzen
                        combobox.SelectionStart = combobox.Text.Length + 1;

                        //Liste mit Stationen erstellen
                        Stations stations = transport.GetStations(combobox.Text);

                        //DropDown mit Stationsvorschlägen füllen
                        foreach (var singlestation in stations.StationList)
                        {
                            if (singlestation != null)
                            {
                                combobox.Items.Add(singlestation.Name);
                            }
                        }
                        //DropDown geht auf bzw. wird angezeigt
                        combobox.DroppedDown = true;
                        combobox.Text = eingabee;
                        combobox.SelectionStart = combobox.Text.Length + 1;
                    }
                    catch
                    {
                        combobox.Items.Clear();
                        combobox.SelectionStart = combobox.Text.Length + 1;
                        combobox.Items.Add("Keine Ergebnisse");
                    }
                }
            }
        }
        

        private void FromDepartureTabelKeyUp(object sender, KeyEventArgs e)
        {
            SuggestedSearch(DepartureTabelComboBox, e);
        }

        private void FromSearchConnectionKeyUp(object sender, KeyEventArgs e)
        {
            SuggestedSearch(FromComboBox, e);
        }

        private void ToSearchConnectionKeyUp(object sender, KeyEventArgs e)
        {
            SuggestedSearch(ToComboBox, e);

        }

        private void StationSearchMapKeyUp(object sender, KeyEventArgs e)
        {
            SuggestedSearch(StationMapComboBox, e);
        }

        private void MailSendenButtonClick(object sender, EventArgs e)
        { 
            try
            {   
                //neue List erstellen
                var dataGridViewList = new List<string>();
                //Jede Verbindung(1 row) welche ausgewählt wurde einzeln weitergeben
                foreach (DataGridViewRow row in ConnectionSearchDataGridView.SelectedRows)
                {
                    //Jede Zelle einer Row abrufen und daraus ein String bilden
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dataGridViewList.Add(cell.Value.ToString());
                    }
                }
                //Wenn überhaupt eine Verbindung ausgewählt wurde-> Mailtext bilden indem List zusammenbaue
                if (dataGridViewList != null) System.Diagnostics.Process.Start("mailto:" + "?subject=Verbindung" + "&body=Datum: " + dataGridViewList[0] + ", Abfahrt: " + dataGridViewList[1] + ", Uhr " + ", Von: " + dataGridViewList[2] + ", Nach: " + dataGridViewList[3] + ", Ankunft: " + dataGridViewList[4] + ", Dauer: " + dataGridViewList[5] + ", Platform: " + dataGridViewList[6]);
            }
            catch
            {
                MessageBox.Show("Sie haben keine Verbindung ausgewaehlt.\n Drücken Sie in die leere Zelle links der gewünschten Verbindung.");
            }
        }


        private void StationMapButton(object sender, EventArgs e)
        {
            try
            {
                if (StationMapComboBox.Text != "")
                {
                    var Coords = GetStationGPSCoodrinates(StationMapComboBox.Text);
                    MoveMapToGPSCoordinates(Coords);
                }
                else
                {
                    MessageBox.Show("Bitte geben Sie eine Station ein.");
                }
            }
            catch 
            {
                MessageBox.Show("Fehler: Bitte überprüfen Sie Ihre Eingabe.");
            }
        }

        // X- und Y-Koordinaten einer Station holen und zusammenfassen
        private string GetStationGPSCoodrinates(string Station)
        {
            var station = transport.GetStations(Station).StationList.FirstOrDefault(x => Equals(x.Name, Station));
            if (station != null)
            {
                string x = Convert.ToString(station.Coordinate.XCoordinate);
                string y = Convert.ToString(station.Coordinate.YCoordinate);
                string amalgamatedCoordinates = x + "/" + y;
                return amalgamatedCoordinates;
            }
            else
            {
                return "ERROR";
            }
        }
        // aktualisiert den Browser mit den aktuellen GPS-Koordinaten.
        private void MoveMapToGPSCoordinates(string Coordinates)
        {
            Browser.Navigate("https://www.openstreetmap.org/#map=19/47.05010/8.31036&layers=T");
            var URL = "https://www.openstreetmap.org/#map=18/" + Coordinates + "&layers=T";
            Browser.Navigate(URL);
        }
    }
}
