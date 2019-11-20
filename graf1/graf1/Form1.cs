using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graf1
{
    public partial class Form1 : MetroForm
    {


        Bitmap dr;
        bool wcz = false;
        
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wcz = true;
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Image";
            dlg.Filter = "jpg files (*.jpg)|*.jpg";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                dr = new Bitmap(dlg.FileName);
                pictureBox1.Image = dr;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dr = new Bitmap(pictureBox1.Width,pictureBox1.Height);
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Image";
            dlg.Filter = "jpg files (*.jpg)|*.jpg";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                dr = new Bitmap(dlg.FileName);
                pictureBox1.Image = dr;
            }
            Graphics g = Graphics.FromImage(dr);
            g.DrawString(textBox1.Text, SystemFonts.DefaultFont, Brushes.Black, 63, 71);
            pictureBox1.Image = dr;
            SaveFileDialog svd = new SaveFileDialog();
            svd.ShowDialog();
            pictureBox1.Image.Save(svd.FileName);
        }
    }
}
