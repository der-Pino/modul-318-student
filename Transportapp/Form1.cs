using SwissTransport.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            List<SwissTransport.Models.Connection> conn = transport.GetConnections(AbfahrtSuche.Text, ZielSuche.Text).ConnectionList;
            //testbox.Text = conn;
        }

    }
}
