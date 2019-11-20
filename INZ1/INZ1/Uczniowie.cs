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
    public partial class Uczniowie : MetroForm
    {
        private Form1 form1;
        SqlConnection cn = new SqlConnection("Data Source=(local);Initial Catalog=INZ;Integrated Security=True");
        public Uczniowie(Form1 form1)
        {
            
            InitializeComponent();
            this.form1 = form1;
            metroComboBox1.SelectedIndex = 0;
            metroComboBox2.Items.Clear();
            AddData();
            AddCombo();
        }
        private void AddData()
        {
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Uczniowie", cn);
            var t = new DataTable();
            da.Fill(t);
            dataGridView1.DataSource = t;
            cn.Close();
        }
        public void AddCombo()
        {

            
            cn.Open();
            SqlCommand cm = new SqlCommand("Select Nazwa From Grupy Where Język = '" + metroComboBox1.Text + "'", cn);
            
            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {

                metroComboBox2.Items.Add(dr["Nazwa"]);
            }

           
            cn.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Grupy gr = new Grupy(form1);
            gr.Show();
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
            metroLabel11.Text ="Wolne miejsca: " + a.ToString();
            if (a < 1)
            {
                metroButton2.Enabled = false;
                metroLabel12.Text = "Brak miejsc zmień grupę!";
            }
            cn.Close();
        }
        

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if(metroTextBox1.Text.Length>0 && metroTextBox2.Text.Length > 0 && metroTextBox3.Text.Length > 0 && metroTextBox4.Text.Length > 0 && metroComboBox3.Text.Length > 0 && metroTextBox6.Text.Length > 0 && metroComboBox2.Text.Length>0 )
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Uczniowie (Nazwisko, Imię, Grupa, Adres, Opłata, Zapłacone, Telefon, Frekwencja) VALUES (@Nazwisko, @Imię, @Grupa, @Adres, @Opłata, @Zapłacone, @Telefon, @Frekwencja)");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cn;
                cmd.Parameters.AddWithValue("@Nazwisko", metroTextBox1.Text);
                cmd.Parameters.AddWithValue("@Imię", metroTextBox2.Text);
                cmd.Parameters.AddWithValue("@Grupa", metroComboBox2.Text);
                cmd.Parameters.AddWithValue("@Adres", metroTextBox3.Text);
                cmd.Parameters.AddWithValue("@Opłata", metroTextBox4.Text);
                cmd.Parameters.AddWithValue("@Zapłacone", metroComboBox3.Text);
                cmd.Parameters.AddWithValue("@Telefon", metroTextBox6.Text);
                cmd.Parameters.AddWithValue("@Frekwencja", 0);
                cmd.Parameters.AddWithValue("@Średnia", 0);
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Dodano");
                AddData();
                metroTextBox1.Text = "";
                metroTextBox2.Text = "";
                metroTextBox3.Text = "";
                metroTextBox4.Text = "";
                metroTextBox6.Text = "";
                AddCombo();
            }
            else
            {
                MessageBox.Show("Któreś pole jest puste!");
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            EdytujUcz EU = new EdytujUcz();
            EU.Show();
        }

       
    }
}
