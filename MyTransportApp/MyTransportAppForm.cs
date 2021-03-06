﻿using System;
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
        AutoComplete autocomplete = new AutoComplete();

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
                        //Diese Verbindungen wo jetzt ok sind, werden einzeln in eine Variable gespeichert, 
                        //damit diese in die AusgabeTabelle eingefügt werden können
                        foreach (Connection singleCon in connections.ConnectionList)
                        {
                            this.ConnectionSearchDataGridView.Rows.Add(singleCon.From.Departure.ToString().Substring(0, 10), singleCon.From.Departure.ToString().Substring(11, 5), singleCon.From.Station.Name, singleCon.To.Station.Name, singleCon.To.Arrival.ToString().Substring(11, 5), singleCon.Duration.Substring(3, 5), singleCon.From.Platform);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Keine Verbindung zwischen den Stationen gefunden.\nBitte überprüfen Sie Ihre Eingabe.");
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
                            this.DepartureTableDataGridView.Rows.Add(singleCon.Stop.Departure.ToString().Substring(11, 5), singleCon.To.ToString(),singleCon.Name.ToString());
                        }
                    }
                    else 
                    {
                        MessageBox.Show("Es gibt keine Abfahrten von dieser Station.\nBitte überprüfen Sie Ihre Eingabe.");
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


        

        private void FromDepartureTabelKeyUp(object sender, KeyEventArgs e)
        {
            autocomplete.SuggestedSearch(DepartureTabelComboBox, e);
        }

        private void FromSearchConnectionKeyUp(object sender, KeyEventArgs e)
        {
            autocomplete.SuggestedSearch(FromComboBox, e);
        }

        private void ToSearchConnectionKeyUp(object sender, KeyEventArgs e)
        {
            autocomplete.SuggestedSearch(ToComboBox, e);

        }

        private void StationSearchMapKeyUp(object sender, KeyEventArgs e)
        {
            autocomplete.SuggestedSearch(StationMapComboBox, e);
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
                    //Stationsauswahl an Funktione weitergeben um die Koordinaten derer zu ermitteln
                    var Coords = GetStationGPSCoodrinates(StationMapComboBox.Text);
                    if (Coords != "ERROR")
                    {
                        if (Coords != "/")
                        {
                            //erhaltene Koordinaten an Funktion MoveMap weitergeben damit Station auf der Karte gefunden und angezeigt wird.
                            MoveMapToGPSCoordinates(Coords);
                        }
                        else 
                        {
                            MessageBox.Show("Koordinaten der Station nicht gefunden.");
                        }
                    }
                    else {
                        MessageBox.Show("Fehler: Bitte überprüfen Sie Ihre Eingabe.");
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

        //X- und Y-Koordinaten einer Station holen und zusammenfassen
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
        //aktualisiert den Browser mit den aktuellen GPS-Koordinaten.
        private void MoveMapToGPSCoordinates(string Coordinates)
        {
            Browser.Navigate("https://www.openstreetmap.org/#map=19/47.05010/8.31036&layers=T");
            var URL = "https://www.openstreetmap.org/#map=18/" + Coordinates + "&layers=T";
            Browser.Navigate(URL);
        }
    }
}
