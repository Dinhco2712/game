using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace phandinhco2122110336
{
    public partial class bai28 : Form
    {
        PictureBox pbBasket = new PictureBox();
        PictureBox pbEgg = new PictureBox();
        PictureBox pbBom = new PictureBox();
        PictureBox pbChicken = new PictureBox();
        Button btnRestart = new Button();

        Timer tmEgg = new Timer();
        Timer tmChicken = new Timer();
        Timer tmBom = new Timer();
        

        SoundPlayer backgroundMusic;

        int xBasket = 300;
        int yBasket = 285;
        int xDeltaBasket = 30;

        int xChicken = 300;
        int yChicken = 10;
        int xDeltaChicken = 3;

        int xEgg = 300;
        int yEgg = 10;
        int yDeltaEgg = 3;

        int xBom = 300;
        int yBom = 10;
        int yDeltaBom = 2;

        bool isEggBroken = false;
        bool isBomBroken = false;
        bool isBomFalling = false;

        int time = 0;
        int diem = 0;

        public bai28()
        {
            InitializeComponent();
            SetupRestartButton();

            // Khởi tạo nhạc nền
            try
            {
                backgroundMusic = new SoundPlayer("../../Images/backgroundmusic.wav");
                backgroundMusic.Load(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải nhạc nền: " + ex.Message);
            }
        }

        private void SetupRestartButton()
        {
            btnRestart.Text = "Chơi lại";
            btnRestart.Size = new Size(100, 50);
            btnRestart.Location = new Point((this.ClientSize.Width - btnRestart.Width) / 2, (this.ClientSize.Height - btnRestart.Height) / 2);
            btnRestart.Click += BtnRestart_Click;
            btnRestart.Visible = false;
            this.Controls.Add(btnRestart);
        }

        private void bai28_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("../../Images/background.jpeg");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            // Bắt đầu các bộ đếm thời gian
            tmEgg.Interval = 10;
            tmEgg.Tick += TmEgg_Tick;
            tmEgg.Start();

            tmBom.Interval = 10;
            tmBom.Tick += TmBom_Tick;
            tmBom.Start();

            tmChicken.Interval = 10;
            tmChicken.Tick += TmChicken_Tick;
            tmChicken.Start();

            tmStopwatch.Interval = 1000;
            tmStopwatch.Tick += tmStopwatch_Tick;
            tmStopwatch.Start();

            InitializeGameObjects();
            backgroundMusic.PlayLooping(); // Phát nhạc nền
        }

        private void InitializeGameObjects()
        {
            pbBasket.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBasket.Size = new Size(50, 50);
            pbBasket.Location = new Point(xBasket, yBasket);
            pbBasket.BackColor = Color.Transparent;
            this.Controls.Add(pbBasket);
            pbBasket.Image = Image.FromFile("../../Images/basket.png");

            pbEgg.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEgg.Size = new Size(20, 30);
            pbEgg.Location = new Point(xEgg, yEgg);
            pbEgg.BackColor = Color.Transparent;
            this.Controls.Add(pbEgg);
            pbEgg.Image = Image.FromFile("../../Images/ball.png");

            pbBom.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBom.Size = new Size(30, 30);
            pbBom.Location = new Point(xBom, yBom);
            pbBom.BackColor = Color.Transparent;
            this.Controls.Add(pbBom);
            pbBom.Image = Image.FromFile("../../Images/bom.png");

            pbChicken.SizeMode = PictureBoxSizeMode.StretchImage;
            pbChicken.Size = new Size(70, 70);
            pbChicken.Location = new Point(xChicken, yChicken);
            pbChicken.BackColor = Color.Transparent;
            this.Controls.Add(pbChicken);
            pbChicken.Image = Image.FromFile("../../Images/chicken.png");
        }

        private void TmChicken_Tick(object sender, EventArgs e)
        {
            if (isBomBroken || isEggBroken) return;
            xChicken += xDeltaChicken;
            if (xChicken > this.ClientSize.Width - pbChicken.Width || xChicken <= 0)
                xDeltaChicken = -xDeltaChicken;
            pbChicken.Location = new Point(xChicken, yChicken);
        }

        private void TmBom_Tick(object sender, EventArgs e)
        {
            if (isEggBroken) return;
            if (!isBomFalling) return;

            yBom += yDeltaBom;

            if (yBom > this.ClientSize.Height)
            {
                isBomFalling = false;
                return;
            }

            Rectangle unionreactbom = Rectangle.Intersect(pbBom.Bounds, pbBasket.Bounds);
            if (!unionreactbom.IsEmpty)
            {
                isBomBroken = true;
                tmStopwatch.Stop();
                backgroundMusic.Stop(); // Dừng nhạc nền
                btnRestart.Visible = true;
                return;
            }
            pbBom.Location = new Point(xBom, yBom);
        }

        private void TmEgg_Tick(object sender, EventArgs e)
        {
            if (isBomBroken) return;
            yEgg += yDeltaEgg;

            if (yEgg > this.ClientSize.Height - pbEgg.Height || yEgg <= 0)
            {
                pbEgg.Image = Image.FromFile("../../Images/ballvo.png");
                isEggBroken = true;
                backgroundMusic.Stop(); // Dừng nhạc nền
                btnRestart.Visible = true;
                return;
            }

            Rectangle unionreact = Rectangle.Intersect(pbEgg.Bounds, pbBasket.Bounds);
            if (!unionreact.IsEmpty)
            {
                diem++;
                lbldiem.Text = "" + diem;
                if (diem % 15 == 0)
                {
                    NextLevel();
                }
                yEgg = 30;
                xEgg = pbChicken.Location.X;
            }

            pbEgg.Location = new Point(xEgg, yEgg);
        }

        private void tmStopwatch_Tick(object sender, EventArgs e)
        {
            time++;
            lblTime.Text = time.ToString();

            if (time % 5 == 0 && !isBomFalling || time == 1)
            {
                yBom = 10;
                xBom = pbChicken.Location.X;
                pbBom.Location = new Point(xBom, yBom);
                isBomFalling = true;
                isBomBroken = false;
            }

            if (isEggBroken)
            {
                tmStopwatch.Stop();
            }
        }

        private void NextLevel()
        {
            xDeltaChicken += 1;
            yDeltaEgg += 1;
            yDeltaBom += 2;

            pbChicken.Image = Image.FromFile("../../Images/chicken2.png");
            pbBasket.Image = Image.FromFile("../../Images/basket2.png");
            this.BackgroundImage = Image.FromFile("../../Images/background2.jpeg");
        }

        private void bai28_KeyDown(object sender, KeyEventArgs e)
        {
            if (isBomBroken || isEggBroken) return;
            if (e.KeyValue == 39 && (xBasket < this.ClientSize.Width - pbBasket.Width))
                xBasket += xDeltaBasket;
            if (e.KeyValue == 37 && xBasket > 0)
                xBasket -= xDeltaBasket;
            pbBasket.Location = new Point(xBasket, yBasket);
        }

        private void BtnRestart_Click(object sender, EventArgs e)
        {
            isEggBroken = false;
            isBomBroken = false;
            isBomFalling = false;
            time = 0;
            diem = 0;

            lbldiem.Text = "0";
            lblTime.Text = "0";

            xBasket = 300;
            xChicken = 300;
            yEgg = 10;
            yBom = 10;

            pbBasket.Location = new Point(xBasket, yBasket);
            pbChicken.Location = new Point(xChicken, yChicken);
            pbEgg.Location = new Point(xEgg, yEgg);
            pbBom.Location = new Point(xBom, yBom);

            pbEgg.Image = Image.FromFile("../../Images/ball.png");
            tmEgg.Start();
            tmBom.Start();
            tmChicken.Start();
            tmStopwatch.Start();

            backgroundMusic.PlayLooping(); // Phát lại nhạc nền
            btnRestart.Visible = false;

            this.Focus();
        }
    }
}
