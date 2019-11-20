using MetroFramework.Forms;
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

namespace INZ1
{
    public partial class Plan : MetroForm
    {
        private Form1 form1;
        public Plan(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
            metroComboBox1.SelectedIndex = 0;
            uprawnienia();
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            St_Plan st = new St_Plan();
            st.Show();
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            try
            {
               

                FileStream fs;
                fs = new FileStream(mydocpath + @"\INZ\" + metroComboBox1.Text + ".jpg", FileMode.Open, FileAccess.Read);
                pictureBox1.Image = System.Drawing.Image.FromStream(fs);
                fs.Close();
            }
            catch
            {
                MessageBox.Show("Najpierw stwórz plan");
            }
        }
        private void uprawnienia()
        {
            if (form1.upr == false)
            {
                metroButton1.Visible = false;
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (metroCheckBox2.Checked == true) { rystyg(); }
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (metroCheckBox1.Checked == true)
            {
                string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                FileStream fs;
                fs = new FileStream(mydocpath + @"\INZ\" + metroComboBox1.Text + ".jpg", FileMode.Open, FileAccess.Read);
                Image bmp = Image.FromStream(fs);
                e.Graphics.DrawImage(bmp, 20, 20);
            }
            else
            {
                string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                FileStream fs;
                fs = new FileStream(mydocpath + @"\INZ\Tyg.jpg", FileMode.Open, FileAccess.Read);
                Image bmp = Image.FromStream(fs);
                e.Graphics.DrawImage(bmp, 0, 0);
            }
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(metroCheckBox1.Checked == true)
            {
                metroCheckBox2.Checked = false;
            }
            else
            {
                metroCheckBox2.Checked = true;
            }
        }

        private void metroCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox2.Checked == true)
            {
                metroCheckBox1.Checked = false;
            }
            else
            {
                metroCheckBox1.Checked = true;
            }
        }
        private void rystyg()
        {
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Image bmp = new Bitmap(800,1150);
            Graphics g = Graphics.FromImage(bmp);
            FileStream fs;
            fs = new FileStream(mydocpath + @"\INZ\Poniedziałek.jpg", FileMode.Open, FileAccess.Read);
            Image poni = Image.FromStream(fs);
            fs.Close();
            fs = new FileStream(mydocpath + @"\INZ\Wtorek.jpg", FileMode.Open, FileAccess.Read);
            Image wto = Image.FromStream(fs);
            fs.Close();
            fs = new FileStream(mydocpath + @"\INZ\Środa.jpg", FileMode.Open, FileAccess.Read);
            Image śro = Image.FromStream(fs);
            fs.Close();
            fs = new FileStream(mydocpath + @"\INZ\Czwartek.jpg", FileMode.Open, FileAccess.Read);
            Image czwa = Image.FromStream(fs);
            fs.Close();
            fs = new FileStream(mydocpath + @"\INZ\Piątek.jpg", FileMode.Open, FileAccess.Read);
            Image pia = Image.FromStream(fs);
            fs.Close();
            Image nag = new Bitmap(1150,280);
            Graphics g2 = Graphics.FromImage(nag);
            Brush br = new SolidBrush(Color.White);
            g2.FillRectangle(br,0,0,1150,280);
            g2.DrawString("Plan zajęć", new Font("Arial", 62, FontStyle.Bold), Brushes.Black, 370, 120);
            nag.RotateFlip(RotateFlipType.Rotate90FlipNone);
            poni.RotateFlip(RotateFlipType.Rotate90FlipNone);
            wto.RotateFlip(RotateFlipType.Rotate90FlipNone);
            śro.RotateFlip(RotateFlipType.Rotate90FlipNone);
            czwa.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pia.RotateFlip(RotateFlipType.Rotate90FlipNone);
            Rectangle pon = new Rectangle(330,0,290,230);
            Rectangle wt = new Rectangle(330, 230, 290, 230);
            Rectangle sr = new Rectangle(330, 460, 290, 230);
            Rectangle czw = new Rectangle(330,690, 290, 230);
            Rectangle pt = new Rectangle(330, 920, 290, 230);
            Rectangle nagg = new Rectangle(620, 0, 280, 1150);
            g.FillRectangle(br, 0, 0, 800, 1150);
            g.DrawImage(nag, nagg);
            g.DrawImage(poni,pon);
            g.DrawImage(wto, wt);
            g.DrawImage(śro, sr);
            g.DrawImage(czwa, czw);
            g.DrawImage(pia, pt);
            string outputFileName = mydocpath+@"\INZ\Tyg.jpg";
            using (MemoryStream memory = new MemoryStream())
            {
                using (FileStream fss = new FileStream(outputFileName, FileMode.Create, FileAccess.ReadWrite))
                {
                    bmp.Save(memory,System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] bytes = memory.ToArray();
                    fss.Write(bytes, 0, bytes.Length);
                }
            }
        }
    }
}
