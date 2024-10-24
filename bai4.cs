using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace phandinhco2122110336
{
    public partial class bai4 : Form
    {
        string path = "D:\form.xml";
        InfoWindows iw = new InfoWindows();

        public bai4()
        {
            InitializeComponent();
        }
        public void Write(InfoWindows iw)
        {
            XmlSerializer write = new XmlSerializer(typeof(InfoWindows));
            StreamWriter file = new StreamWriter(path);
            write.Serialize(file, iw);
            file.Close();

        }
        public InfoWindows Read()
        {
            XmlSerializer reader = new XmlSerializer(typeof(InfoWindows));
            StreamReader file = new StreamReader(path); 
            InfoWindows iw = (InfoWindows)reader.Deserialize(file);
            file.Close();
            return iw;
        }
        private void bai4_Load(object sender, EventArgs e)
        {
            iw = Read();
            this.Width = iw.Width;
            this.Height = iw.Height;
            this.Location = iw.Location;
        }

        private void bai4_FormClosing(object sender, FormClosingEventArgs e)
        {
            iw.Width = this.Size.Width;
            iw.Height = this.Size.Height;
            iw.Location = this.Location;
            Write(iw);
        }
    }
}
