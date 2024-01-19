using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4a_tm
{
    public partial class Form1 : Form
    {
        private string url = @"https://raw.githubusercontent.com/Bowserinator/Periodic-Table-JSON/master/PeriodicTableJSON.json";
        public Form1()
        {
            InitializeComponent();
            HttpClient client = new HttpClient();
            var response = client.GetAsync(url).Result;
            response.EnsureSuccessStatusCode();
            string responseBody = response.Content.ReadAsStringAsync().Result;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmButton btt = new tmButton();
            btt.Width = 80;
            btt.Symbol = "H";
            tableLayoutPanel1.Controls.Add(btt, 9,9);
        }
    }
}
