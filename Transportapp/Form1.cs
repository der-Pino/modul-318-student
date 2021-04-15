using SwissTransport.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transportapp
{
    public partial class Programmfenster : Form
    {
        ITransport transport = new Transport();
        public Programmfenster()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Suchen_Click(object sender, EventArgs e)
        {
            if (AbfahrtSuche.Text != null) 
            { 
                VerbindungsListe.Rows.Clear();
                var verbindung = transport.GetConnections(AbfahrtSuche.Text, ZielSuche.Text);
                for(int i = 0; i < 4; i++)
                {
                    string von = verbindung.ConnectionList[i].From.Station.Name;
                    string abfahrt = verbindung.ConnectionList[i].From.Departure?.ToString("HH:mm") ?? "unbekannt";
                    string bis = verbindung.ConnectionList[i].To.Station.Name;
                    string ankunft = verbindung.ConnectionList[i].To.Arrival?.ToString("HH:mm") ?? "unbekannt";
                    VerbindungsListe.Rows.Add(von, abfahrt, bis, ankunft);
                }
            }
        }

        private void SucheClear_Click(object sender, EventArgs e)
        {
            AbfahrtSuche.Text = "";
            ZielSuche.Text = "";
        }

        private void SucheTausch_Click(object sender, EventArgs e)
        {
            var abfahrttemp = AbfahrtSuche.Text;
            AbfahrtSuche.Text = ZielSuche.Text;
            ZielSuche.Text = abfahrttemp;
        }
    }
}
