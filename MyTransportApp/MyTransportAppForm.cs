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
        Stations stationen = new Stations();

        public MyTransportAppForm()
        {
            InitializeComponent();
            DatePicker.Text = DateTime.Now.ToString("yyyy-MM-dd");
            TimePicker.Text = DateTime.Now.ToString("HH:mm");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
