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

namespace INZ1
{
    public partial class Zmień_hasło : MetroForm
    {
        SqlConnection cn = new SqlConnection("Data Source=(local);Initial Catalog=INZ;Integrated Security=True");

        
        private Form1 form1;
        public Zmień_hasło(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            LogLabel1.Text = form1.log;
            Odswiez();
            WczyDane();
        }
        void Odswiez()
        {
            cn.Open();
            SqlCommand am = new SqlCommand("Select Haslo from Users  Where Login= '" + LogLabel1.Text  + "'", cn);
            SqlDataReader dr = am.ExecuteReader();
            while (dr.Read())
            {
                passLabel.Text = dr["Haslo"].ToString();
                
            }

            cn.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text.Length > 0)
            {


                cn.Open();
                SqlCommand cm = new SqlCommand("Update Users SET Haslo=@Haslo where Login=@Login", cn);
                cm.Parameters.AddWithValue("@Login", LogLabel1.Text);
                cm.Parameters.AddWithValue("@Haslo", metroTextBox1.Text);
                cm.ExecuteNonQuery();
                MessageBox.Show("Zmieniono");
                
                cn.Close();
                Odswiez();
            }
            else { MessageBox.Show("Należy wpisać nowe hasło"); }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if(metroTextBox2.Text.Length>0 && metroTextBox3.Text.Length>0 && metroTextBox4.Text.Length > 0)
            {
                cn.Open();
                SqlCommand cm = new SqlCommand("Update Nauczyciele SET Imię=@Imię, Nazwisko=@Nazwisko, Telefon=@telefon where Login = '"+ form1.log +"'", cn);
                cm.Parameters.AddWithValue("@Imię", metroTextBox2.Text);
                cm.Parameters.AddWithValue("@Nazwisko", metroTextBox3.Text);
                cm.Parameters.AddWithValue("@Telefon", metroTextBox4.Text);
                cm.ExecuteNonQuery();
                MessageBox.Show("Zmieniono");

                cn.Close();
            }
            else { MessageBox.Show("Któreś pole jest puste!"); }
        }
        private void WczyDane()
        {
            cn.Open();
            SqlCommand am = new SqlCommand("Select Imię, Nazwisko, Telefon from Nauczyciele  Where Login= '" + form1.log + "'", cn);
            SqlDataReader dr = am.ExecuteReader();
            while (dr.Read())
            {
                metroTextBox2.Text = dr["Imię"].ToString();
                metroTextBox3.Text = dr["Nazwisko"].ToString();
                metroTextBox4.Text = dr["Telefon"].ToString();

            }

            cn.Close();
        }
    }

       

        
    }

