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
       // Connection connection = new Connection();

        public MyTransportAppForm()
        {
            InitializeComponent();
            DatePicker.Text = DateTime.Now.ToString("yyyy-MM-dd");
            TimePicker.Text = DateTime.Now.ToString("HH:mm");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SearchButtonClick(object sender, EventArgs e)
        {
            //Falls Die Pflichfeldet Von+Nach leer sind, Gibt Fehlermeldung
            if (FromComboBox.Text != "" && ToComboBox.Text != "")
            {
                //Alle Verbindungen wo Station mit User-Stationeingabe übereinstimmt, in Objekt speichern
                Connections connection = transport.GetConnections(FromComboBox.Text, ToComboBox.Text);

                //Diese Verbindungen wo jetzt ok sind, muss ich einzeln in eine Variable speichern, 
                //damit ich diese in die AusgabeTabelle einfügen kann
                foreach (var c in connection.ConnectionList)
                { //List<Connection> ist eine Liste mit dem Datentyp Connection
                    this.ConnectionSearchDataGridView.Rows.Add(c.From.Departure, c.From.Departure, c.From.Station.Name, c.To.Station.Name, c.To.Arrival, c.Duration, c.From.Platform);

                }
            }
            else {
                MessageBox.Show("Sie haben einen ungueltigen Wert eingegeben.");
            }
        }

        private void SearchDepartureTabelClick(object sender, EventArgs e)
        {
            /*
            if (DepartureTabelComboBox.Text != "")
            {
                Connections connection = transport.GetStationBoard(DepartureTabelComboBox.Text);

                foreach (var c in connection.ConnectionList)
                { //List<Connection> ist eine Liste mit dem Datentyp Connection
                    this.ConnectionSearchDataGridView.Rows.Add(c.From.Departure, c.To.Station.Name, c.From.Platform);

                }
            }
            else
            {
                MessageBox.Show("Sie haben einen ungueltigen Wert eingegeben.");
            }*/
        }
    }
}
