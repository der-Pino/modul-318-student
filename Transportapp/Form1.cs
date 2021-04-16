using SwissTransport.Core;
using SwissTransport.Models;
using System;
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
            try
            {
                VerbindungsListe.Rows.Clear();
                Connections verbindung = transport.GetConnections(AbfahrtSuche.Text, ZielSuche.Text);
                foreach (Connection connection in verbindung.ConnectionList)
                {
                    string von = connection.From.Station.Name;
                    string abfahrt = connection.From.Departure?.ToString("HH:mm") ?? "unbekannt";
                    string bis = connection.To.Station.Name;
                    string ankunft = connection.To.Arrival?.ToString("HH:mm") ?? "unbekannt";
                    VerbindungsListe.Rows.Add(von, abfahrt, bis, ankunft);
                }
            }
            catch 
            {
                ZielSuche.Text = "Zielort";
                AbfahrtSuche.Text = "Abfahrtsort";
            }
        }

        private void SucheClear_Click(object sender, EventArgs e)
        {
            AbfahrtSuche.Text = "";
            ZielSuche.Text = "";
            Abfahrtvorschlag.Items.Clear();
            Zielortvorschlag.Items.Clear();
            VerbindungsListe.Rows.Clear();
        }

        private void SucheTausch_Click(object sender, EventArgs e)
        {
            var abfahrttemp = AbfahrtSuche.Text;
            AbfahrtSuche.Text = ZielSuche.Text;
            ZielSuche.Text = abfahrttemp;
            Abfahrtvorschlag.Items.Clear();
            Zielortvorschlag.Items.Clear();
        }

        private void StationsSuche_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(StationsSuche.Text))
            {
                Stationsvorschlage.Items.Clear();
                Stations vorschlag = transport.GetStations(StationsSuche.Text);

                foreach (Station station in vorschlag.StationList)
                {
                    if (!string.IsNullOrEmpty(station.Name))
                    { 
                    Stationsvorschlage.Items.Add(station.Name);
                    }
                }
            } 
        }

     
        private void Stationsvorschlage_SelectedIndexChanged(object sender, EventArgs e)
        {
            StationsSuche.Text = Stationsvorschlage.Text;
            Stationsvorschlage.Items.Clear();
        }

        private void StationClear_Click(object sender, EventArgs e)
        {
            StationsSuche.Text = "";
            Stationsvorschlage.Items.Clear();
            Abfahrtstafel.Rows.Clear();
        }



       

        private void AbfahrtSuche_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(AbfahrtSuche.Text))
            {
                Abfahrtvorschlag.Items.Clear();
                Stations vorschlag = transport.GetStations(AbfahrtSuche.Text);

                foreach (Station station in vorschlag.StationList)
                {
                    if (!string.IsNullOrEmpty(station.Name))
                    {
                        Abfahrtvorschlag.Items.Add(station.Name);
                    }

                }
            }
        }

        private void Abfahrtvorschlag_SelectedIndexChanged(object sender, EventArgs e)
        {
            AbfahrtSuche.Text = Abfahrtvorschlag.Text;
            Abfahrtvorschlag.Items.Clear();
        }

        private void ZielSuche_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ZielSuche.Text))
            {
                Zielortvorschlag.Items.Clear();
                Stations vorschlag = transport.GetStations(ZielSuche.Text);

                foreach (Station station in vorschlag.StationList)
                {
                    if (!string.IsNullOrEmpty(station.Name))
                    {
                        Zielortvorschlag.Items.Add(station.Name);
                    }

                }
            }
        }

        private void Zielortvorschlag_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZielSuche.Text = Zielortvorschlag.Text;
            Zielortvorschlag.Items.Clear();
        }

        private void StationSuchen_Click(object sender, EventArgs e)
        {
            try
            {
                string statid = transport.GetStations(StationsSuche.Text).StationList[0].Id;
                var statborad = transport.GetStationBoard(StationsSuche.Text, statid).Entries;

                foreach (StationBoard connection in statborad)
                {
                    string abfahrt = connection.Stop.Departure.ToString("HH:mm") ?? "unbekannt";
                    string ziel = connection.To;

                    Abfahrtstafel.Rows.Add(abfahrt, ziel);
                }
            }
            catch 
            {
               Abfahrtstafel.Rows.Clear();
               Stationsvorschlage.Items.Clear();
               Stationsvorschlage.Items.Add("Station nicht gefunden");
            }
        }

        private void helpbtn_Click(object sender, EventArgs e)
        {
            ToolTip buttonToolTip = new ToolTip
            {
                ToolTipTitle = "Beschreibung",
                UseFading = true,
                UseAnimation = false,
                IsBalloon = true,
                ShowAlways = true,
                AutoPopDelay = 5000,
                ReshowDelay = 500
            };


            buttonToolTip.SetToolTip(helpbtn,"Wenn Sie über gewisse Elemente fahren, wird eine kleine Information angezeigt.");
            buttonToolTip.SetToolTip(SucheTausch, "Hier werden Abfahrt und Ziel-ort vertauscht.");
            buttonToolTip.SetToolTip(Suchen, "Hier werden Verbindungen gesucht und unten Angezeigt.");
            buttonToolTip.SetToolTip(ansichtswitch.TabPages[1].Parent, "Hier kann man zwischen Verbindungssuche und Abfahrtstafel wechseln.");
            buttonToolTip.SetToolTip(SucheClear, "Eingabe Löschen");
            buttonToolTip.SetToolTip(StationClear, "Eingabe Löschen");
            buttonToolTip.SetToolTip(Stationsvorschlage, "Hier werden Stationsvorschläge angezeigt");


        }
    }
}
