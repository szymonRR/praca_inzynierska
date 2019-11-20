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
    public partial class EdytujUcz : MetroForm
    {
        SqlConnection cn = new SqlConnection("Data Source=(local);Initial Catalog=INZ;Integrated Security=True");
        public EdytujUcz()
        {
            InitializeComponent();
            metroComboBox3.SelectedIndex = 0;
        }

        public void AddData()
        {

            cn.Open();
            SqlCommand cm = new SqlCommand("Select * From Uczniowie Where Id_Uczen = '" + metroTextBox1.Text + "'", cn);

            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                metroTextBox2.Text = dr["Nazwisko"].ToString();
                metroTextBox3.Text = dr["Imię"].ToString();
                metroTextBox4.Text = dr["Grupa"].ToString();
                metroTextBox5.Text = dr["Adres"].ToString();
                metroTextBox6.Text = dr["Opłata"].ToString();
                metroTextBox7.Text = dr["Zapłacone"].ToString();
                metroTextBox8.Text = dr["Telefon"].ToString();
            }


            cn.Close();
        }

        private void AddCombo()
        {
            cn.Open();
            SqlCommand cm = new SqlCommand("Select Nazwa From Grupy Where Język = '" + metroComboBox3.Text + "'", cn);

            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {

                metroComboBox2.Items.Add(dr["Nazwa"]);
            }


            cn.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            AddData();
        }

        private void metroComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroComboBox2.Items.Clear();
            AddCombo();
        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cm = new SqlCommand("Select Imię From Uczniowie Where Grupa = '" + metroComboBox2.Text + "'", cn);

            SqlDataReader dr = cm.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                i++;

            }
            int a = 8 - i;
            metroLabel4.Text = "Wolne miejsca: " + a.ToString();
            if (a < 1)
            {
                metroButton2.Enabled = false;
                metroLabel5.Text = "Brak miejsc zmień grupę!";
            }
            cn.Close();
            metroTextBox4.Text = metroComboBox2.Text;
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroTextBox7.Text = metroComboBox1.Text;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cm = new SqlCommand("Update Uczniowie SET Nazwisko = @Nazwisko, Imię = @Imię, Grupa = @Grupa, Adres = @Adres, Opłata = @Opłata, Zapłacone = @Zapłacone, Telefon = @Telefon where Id_Uczen= '"+ metroTextBox1.Text +"'", cn);
            cm.Parameters.AddWithValue("@Nazwisko", metroTextBox2.Text);
            cm.Parameters.AddWithValue("@Imię", metroTextBox3.Text);
            cm.Parameters.AddWithValue("@Grupa", metroTextBox4.Text);
            cm.Parameters.AddWithValue("@Adres", metroTextBox5.Text);
            cm.Parameters.AddWithValue("@Opłata", metroTextBox6.Text);
            cm.Parameters.AddWithValue("@Zapłacone", metroTextBox7.Text);
            cm.Parameters.AddWithValue("@Telefon", metroTextBox8.Text);
            cm.ExecuteNonQuery();
            MessageBox.Show("Zmieniono");

            cn.Close();
        }
    }
}
