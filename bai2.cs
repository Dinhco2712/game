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
    public partial class bai2 : Form
    {
        string path = @"D:\form.xml";

        public bai2()
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
        void bai2_Load(object sender, EventArgs e)
        {
            InfoWindows iw = new InfoWindows();
            int Width = this.Size.Width;
            int Height = this.Size.Height;
            Write(iw);
        }

        void bai2_ResizeEnd(object sender, EventArgs e)
        {
            InfoWindows iw = new InfoWindows();
            int Width = this.Size.Width;
            int Height = this.Size.Height;
            Write(iw);
        }
    }
}
