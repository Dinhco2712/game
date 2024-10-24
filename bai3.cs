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
    public partial class bai3 : Form
    {
        string path = @"D:\form.xml";

        public bai3()
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
        private void bai3_Load(object sender, EventArgs e)
        {
            InfoWindows iw = new InfoWindows();
            iw = Read();
            this.Width = iw.Width;
            this.Height = iw.Height;
        }

        private void bai3_ResizeEnd(object sender, EventArgs e)
        {
            InfoWindows iw = new InfoWindows();
            iw.Width = this.Size.Width;
            iw.Height = this.Size.Height;
            Write(iw);
        }
    }
}
