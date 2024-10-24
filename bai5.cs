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
    public partial class bai5 : Form
    {
        public bai5()
        {
            InitializeComponent();
        }

        private void bai5_KeyUp(object sender,System.Windows.Forms.KeyEventArgs e)
        {
            StreamWrite sw = new StreamWrite(@"D:\Key_Logger.txt", true);
            sw.Write(e.KeyCode);
            sw.Close();
        }

        private void bt_OK_Click(object sender, EventArgs e)
        {

        }

        private void bai5_Load(object sender, EventArgs e)
        {

        }
    }
}
