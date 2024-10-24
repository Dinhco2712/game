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
    public partial class bai25 : Form
    {
        PictureBox pb = new PictureBox();
        Timer TmGame = new Timer();
        int xBall = 0;
        int yBall = 0;
        int xDelta = 5;
        int yDalta = 5;
        public bai25()
        {
            InitializeComponent();
        }

        private void bai25_Load(object sender, EventArgs e)
        {
            TmGame.Interval = 10;
            TmGame.Tick += tmGame_tick;
            TmGame.Start();

            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Size = new Size(100, 100);
            pb.Location = new Point(xBall, yBall);
            this.Controls.Add(pb);
            pb.ImageLocation = @"D:\ball.png";
        }
        private void tmGame_tick(object sender, EventArgs e)
        {
            xBall += xDelta;
            yBall += yDalta;
            if (xBall > this.ClientSize.Width - pb.Width || xBall <= 0)
                xDelta = -xDelta;
            if (yBall > this.ClientSize.Height - pb.Height || yBall <= 0)
                yDalta = -yDalta;
            pb.Location = new Point(xBall, yBall);
        }
    }
}
