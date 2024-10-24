using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phandinhco2122110336
{
    public partial class bai24 : Form
    {
        int second = 0;
        public bai24()
        {
            InitializeComponent();
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            tmStopwatch.Stop();
        }
        private void btStart_Click(object sender, EventArgs e)
        {
            tmStopwatch.Interval = 1000;
            tmStopwatch.Start();
        }

        private void tmStopwatch_Tick(object sender, EventArgs e)
        {
            second++;
            lblDisplay.Text = second.ToString();
        }

       
    }
}
