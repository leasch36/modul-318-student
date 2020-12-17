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
    public class AutoComplete
    {
        ITransport transport = new Transport();

        //Stationsvorschläge beim tippen
        public void SuggestedSearch(ComboBox combobox, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Down && e.KeyCode != Keys.Up && e.KeyCode != Keys.Enter && e.KeyCode != Keys.Left && e.KeyCode != Keys.Right)
            {
                //Wenn Combobox nicht leer
                if (combobox.Text != "")
                {
                    try
                    {
                        string input = combobox.Text;
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
                        combobox.Text = input;
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
    }
}
