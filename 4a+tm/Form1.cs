using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4a_tm
{
    public partial class Form1 : Form
    {
        private string jsonstring = "";
        private string url = @"https://raw.githubusercontent.com/Bowserinator/Periodic-Table-JSON/master/PeriodicTableJSON.json";
        private TM tm;
        public Form1()
        {
            InitializeComponent();
            try
            {
                using (WebClient wc = new WebClient())
                {
                    jsonstring = wc.DownloadString(url);
                    tm = JsonConvert.DeserializeObject<TM>(jsonstring);
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            foreach(var elem in tm.elements)
            {
                tmButton btt = new tmButton();
                btt.Width = 80;
                btt.Symbol = elem.symbol;
                tableLayoutPanel1.Controls.Add(btt, elem.xpos, elem.ypos);

            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
