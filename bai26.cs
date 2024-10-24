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
    public partial class bai26 : Form
    {
        PictureBox pbEgg = new PictureBox();
        Timer tmEgg = new Timer();
        int xEgg = 300;
        int yEgg = 0;
        int xDelta = 3;
        int yDelta = 3;
        public bai26()
        {
            InitializeComponent();
        }

        private void bai26_Load(object sender, EventArgs e)
        {
            tmEgg.Interval = 10;
            tmEgg.Tick += tmEgg_tick;
            tmEgg.Start();

            pbEgg.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEgg.Size = new Size(100, 100);
            pbEgg.Location = new Point(xEgg, yEgg);
            pbEgg.BackColor = Color.Transparent;
            this.Controls.Add(pbEgg);
            pbEgg.Image = Image.FromFile("../../Images/ball.png");
        }
        private void tmEgg_tick(object sender, EventArgs e)
        {
            yEgg += yDelta;
            if (yEgg > this.ClientSize.Height - pbEgg.Height || yEgg <= 0)
            { pbEgg.Image = Image.FromFile("../../Images/ballvo.png");
                tmEgg.Stop();
            }
            pbEgg.Location = new Point(xEgg, yEgg);
        }
    }
}
