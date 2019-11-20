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
using System.Data.SqlClient;
using System.IO;

namespace INZ1
{
    
    public partial class St_Plan : MetroForm
    {
        SqlConnection cn = new SqlConnection("Data Source=(local);Initial Catalog=INZ;Integrated Security=True");
        Bitmap dr;
        
        public St_Plan()
        {
            InitializeComponent();
            AddCombo();
            
        }

       private void AddCombo()
        {
            cn.Open();
            SqlCommand cm = new SqlCommand("Select Nazwa From Grupy", cn);
            

            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
               metroComboBox2.Items.Add(dr["Nazwa"]);
                metroComboBox4.Items.Add(dr["Nazwa"]);
                metroComboBox6.Items.Add(dr["Nazwa"]);
                metroComboBox8.Items.Add(dr["Nazwa"]);
                metroComboBox10.Items.Add(dr["Nazwa"]);
                metroComboBox12.Items.Add(dr["Nazwa"]);
                metroComboBox14.Items.Add(dr["Nazwa"]);
                metroComboBox16.Items.Add(dr["Nazwa"]);
            }

            cn.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (metroComboBox1.Text.Length > 0)
            {
               if(metroLabel1.Visible==false&& metroLabel2.Visible ==false&& metroLabel3.Visible == false && metroLabel4.Visible == false)
                {
                    dr = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    dr = INZ1.Properties.Resources.Plan_2;
                    Graphics g = Graphics.FromImage(dr);
                    g.DrawString(metroComboBox1.Text, new Font("Arial",22,FontStyle.Bold), Brushes.Black, 150, 21);
                    g.DrawString(metroComboBox2.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 120, 75);
                    g.DrawString(metroComboBox3.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 120, 125);
                    g.DrawString(metroComboBox4.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 300, 75);
                    g.DrawString(metroComboBox5.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 300, 125);
                    g.DrawString(metroComboBox6.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 120, 175);
                    g.DrawString(metroComboBox7.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 120, 225);
                    g.DrawString(metroComboBox8.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 300, 175);
                    g.DrawString(metroComboBox9.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 300, 225);
                    g.DrawString(metroComboBox10.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 120, 275);
                    g.DrawString(metroComboBox11.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 120, 325);
                    g.DrawString(metroComboBox12.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 300, 275);
                    g.DrawString(metroComboBox13.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 300, 325);
                    g.DrawString(metroComboBox14.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 120, 375);
                    g.DrawString(metroComboBox15.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 120, 425);
                    g.DrawString(metroComboBox16.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 300, 375);
                    g.DrawString(metroComboBox17.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 300, 425);
                    pictureBox1.Image = dr;
                    /*SaveFileDialog svd = new SaveFileDialog();
                    svd.Title = "Zapisz";
                    svd.Filter = "jpg files (*.jpg) | *.jpg";
                    svd.FileName = metroComboBox1.Text;
                    svd.ShowDialog();*/
                    string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    dr.Save(mydocpath + @"\INZ\" + metroComboBox1.Text + ".jpg");

                    MessageBox.Show("Zapisano");
                }
                else
                {
                    MessageBox.Show("Popraw błędy!");
                }
                
            }
            else
            {
                MessageBox.Show("Wybierz dzień");
            }
        }

        private void metroComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(string.Compare(metroComboBox3.Text,metroComboBox5.Text,true)==0)
            {
                metroLabel1.Visible = true;
            }
            else
            {
                metroLabel1.Visible = false;
            }
        }

        private void metroComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.Compare(metroComboBox3.Text, metroComboBox5.Text, true) == 0)
            {
                metroLabel1.Visible = true;
            }
            else
            {
                metroLabel1.Visible = false;
            }
        }

        private void metroComboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.Compare(metroComboBox7.Text, metroComboBox9.Text, true) == 0)
            {
                metroLabel2.Visible = true;
            }
            else
            {
                metroLabel2.Visible = false;
            }
        }

        private void metroComboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.Compare(metroComboBox7.Text, metroComboBox9.Text, true) == 0)
            {
                metroLabel2.Visible = true;
            }
            else
            {
                metroLabel2.Visible = false;
            }
        }

        private void metroComboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.Compare(metroComboBox11.Text, metroComboBox13.Text, true) == 0)
            {
                metroLabel3.Visible = true;
            }
            else
            {
                metroLabel3.Visible = false;
            }
        }

        private void metroComboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.Compare(metroComboBox11.Text, metroComboBox13.Text, true) == 0)
            {
                metroLabel3.Visible = true;
            }
            else
            {
                metroLabel3.Visible = false;
            }
        }

        private void metroComboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.Compare(metroComboBox15.Text, metroComboBox17.Text, true) == 0)
            {
                metroLabel4.Visible = true;
            }
            else
            {
                metroLabel4.Visible = false;
            }
        }

        private void metroComboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.Compare(metroComboBox15.Text, metroComboBox17.Text, true) == 0)
            {
                metroLabel4.Visible = true;
            }
            else
            {
                metroLabel4.Visible = false;
            }
        }
    }
}
