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
    public partial class bai27 : Form
    {
        PictureBox pbBasket = new PictureBox();
        int xBasket = 30;
        int yBasket = 250;
        int xDelta = 30;

        public bai27()
        {
            InitializeComponent();
        }

        private void bai27_Load(object sender, EventArgs e)
        {
            pbBasket.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBasket.Size = new Size(100, 100);
            pbBasket.Location = new Point(xBasket, yBasket);
            pbBasket.BackColor = Color.Transparent;
            this.Controls.Add(pbBasket);
            pbBasket.Image = Image.FromFile("../../Images/basket.png");

        }

        private void bai27_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 39 & (xBasket < this.ClientSize.Width - pbBasket.Width))
                xBasket += xDelta;
            if (e.KeyValue == 37 & xBasket > 0)
                xBasket -= xDelta;
            pbBasket.Location = new Point(xBasket, yBasket);
        }
    }
}
