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
    
    public partial class Nauczyciele : MetroForm
    {
        bool usun = false;
        string login = "";
        SqlConnection cn = new SqlConnection("Data Source=(local);Initial Catalog=INZ;Integrated Security=True");
        public Nauczyciele()
        {
            InitializeComponent();
            AddNau();
        }
        public void AddNau()
        {
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Nauczyciele", cn);
            var t = new DataTable();
            da.Fill(t);
            dataGridView1.DataSource = t;
            cn.Close();

        }
        public void AddUser()
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Users (Login, Haslo) VALUES (@Login, @Haslo)");
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;
            cmd.Parameters.AddWithValue("@Login", T1.Text);
            cmd.Parameters.AddWithValue("@Haslo", T2.Text);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void AddNaucz()
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Nauczyciele (Nazwisko, Imię, Login, Język, Pensja, Telefon) VALUES (@Nazwisko, @Imię, @Login, @Język, @Pensja, @Telefon)");
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;
            cmd.Parameters.AddWithValue("@Nazwisko", T3.Text);
            cmd.Parameters.AddWithValue("@Imię", T4.Text);
            cmd.Parameters.AddWithValue("@Login", T1.Text);
            cmd.Parameters.AddWithValue("@Język", metroComboBox1.Text);
            cmd.Parameters.AddWithValue("@Pensja", T6.Text);
            cmd.Parameters.AddWithValue("@Telefon", T7.Text);
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if(T1.Text.Length>0 && T2.Text.Length > 0 && T3.Text.Length > 0 && T4.Text.Length > 0 &&  T6.Text.Length > 0 && T7.Text.Length > 0 )
            {
                AddUser();
                AddNaucz();
                MessageBox.Show("Dodano");
                AddNau();
            }
            else
            {
                MessageBox.Show("Któreś pole jest puste!");
      
            }
            

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            string a = "";
            metroTextBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            metroTextBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            metroTextBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
           login = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            metroTextBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            
            metroTextBox6.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            metroTextBox7.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text.Length > 0)
            {
                metroButton4.Visible = true;
                metroButton5.Visible = true;
                metroComboBox2.Visible = true;
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            metroButton4.Visible = false;
            metroButton5.Visible = false;
            metroComboBox2.Visible = false;
            metroButton5.Text = "Zapisz";
            metroTextBox1.Text = "";
            metroTextBox2.Text = "";
            metroTextBox3.Text = "";
            
            metroTextBox5.Text = "";
            metroTextBox6.Text = "";
            metroTextBox7.Text = "";
            usun = false;
        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroTextBox5.Text = metroComboBox2.Text;
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text.Length > 0)
            {
                metroButton4.Visible = true;
                metroButton5.Text = "Usuń";
                metroButton5.Visible = true;
                usun = true;
            }
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {

            if (usun == false) { aktnau(); MessageBox.Show("Zaktualizowano"); }
            else { usunau(); usulog();  MessageBox.Show("Usunięto!"); }
            
            metroButton4.Visible = false;
            metroButton5.Visible = false;
            metroComboBox2.Visible = false;
            metroButton5.Text = "Zapisz";
            metroTextBox1.Text = "";
            metroTextBox2.Text = "";
            metroTextBox3.Text = "";

            metroTextBox5.Text = "";
            metroTextBox6.Text = "";
            metroTextBox7.Text = "";
            usun = false;
            
            AddNau();
        }
        
       
        
        private void aktnau()
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("Update Nauczyciele SET Nazwisko = @Nazwisko, Imię=@Imię,Język=@Język,Pensja=@Pensja, Telefon=@Telefon  where Id_Nau= '" + metroTextBox1.Text + "'", cn);
            cmd.Parameters.AddWithValue("@Nazwisko", metroTextBox2.Text);
            cmd.Parameters.AddWithValue("@Imię", metroTextBox3.Text);

            cmd.Parameters.AddWithValue("@Język", metroTextBox5.Text);
            cmd.Parameters.AddWithValue("@Pensja", metroTextBox6.Text);
            cmd.Parameters.AddWithValue("@Telefon", metroTextBox7.Text);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        private void usulog()
        {
            cn.Open();

            SqlCommand cmd = new SqlCommand("DELETE From Users where Login = @Login", cn);
            cmd.Parameters.AddWithValue("@login", login);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        private void usunau()
        {
            cn.Open();

            SqlCommand cmd = new SqlCommand("DELETE From Nauczyciele where Login = @Login", cn);
            cmd.Parameters.AddWithValue("@login", login);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
    

}
