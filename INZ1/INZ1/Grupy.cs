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
    public partial class Grupy : MetroForm
    {
        SqlConnection cn = new SqlConnection("Data Source=(local);Initial Catalog=INZ;Integrated Security=True");
        string id = "";
        int x = 0;
        private Form1 form1;
        public Grupy(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
            uprawnienia();
            
            RokComboBox.SelectedIndex = 0;
            JezykComboBox.SelectedIndex = 0;
            DodajJezykCombo.SelectedIndex = 0;
            DodajRokCombo.SelectedIndex = 0;
            GrupaComboBox.Items.Clear();
            DodajNauCombo.Items.Clear();
            AddCombo();
            ADDID();
            AddNau();
        }
        public void AddCombo()
        {
            
            cn.Open();
            SqlCommand cm = new SqlCommand("Select Nazwa From Grupy Where Rok = '" + RokComboBox.Text + "' And Język = '" + JezykComboBox.Text + "'", cn);

            
                SqlDataReader dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    GrupaComboBox.Items.Add(dr["Nazwa"]);
                }

            cn.Close();
        }
        public void AddNau()
        {
            cn.Open();
            SqlCommand cm = new SqlCommand("Select Nazwisko From Nauczyciele Where Język = '" + DodajJezykCombo.Text + "'", cn);


            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                DodajNauCombo.Items.Add(dr["Nazwisko"]);
            }
            DodajNauCombo.SelectedIndex = 0;
            cn.Close();
        }

        private void RokComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GrupaComboBox.Items.Clear();
            AddCombo();
        }

        private void JezykComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GrupaComboBox.Items.Clear();
            AddCombo();
        }

        private void GrupaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cn.Open();
            SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM Uczniowie where Grupa = '" + GrupaComboBox.Text + "' ", cn);
            var t = new DataTable();
            a.Fill(t);

            dataGridView1.DataSource = t;
            cn.Close();
        }

        private void DodajJezykCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DodajNauCombo.Items.Clear();
            AddNau();
        }

        private void dodajButt_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text.Length > 0)
            {
                
                ADDID();
                cn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Grupy (Nazwa, Język, Nauczyciel, ID_Nau, Rok) VALUES (@Nazwa, @Język, @Nauczyciel, @ID_Nau, @Rok)");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cn;
                cmd.Parameters.AddWithValue("@Nazwa", metroTextBox1.Text);
                cmd.Parameters.AddWithValue("@Język", DodajJezykCombo.Text);
                cmd.Parameters.AddWithValue("@Nauczyciel", DodajNauCombo.Text);
                cmd.Parameters.AddWithValue("@ID_Nau",x );
                cmd.Parameters.AddWithValue("@Rok", DodajRokCombo.Text);
               
                cmd.ExecuteNonQuery();
                cn.Close();
                metroTextBox1.Refresh();
                GrupaComboBox.Items.Clear();
                AddCombo();
                MessageBox.Show("Dodano");
            }
            else
            { MessageBox.Show("Pole Nazwa jest puste"); }
        }

        private void ADDID()
        {

            cn.Open();
            SqlCommand cm = new SqlCommand("Select ID_Nau From Nauczyciele Where Nazwisko = '" + DodajNauCombo.Text + "'", cn);

            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {

                id = dr["ID_Nau"].ToString();
            }


            Int32.TryParse(id, out x);
            cn.Close();
        }
        private void uprawnienia()
        {
            if (form1.upr ==false)
            {
                dodajButt.Visible = false;
                metroLabel4.Visible = false;
                metroLabel5.Visible = false;
                metroLabel6.Visible = false;
                metroLabel7.Visible = false;
                metroLabel8.Visible = false;
                metroTextBox1.Visible = false;
                DodajJezykCombo.Visible = false;
                DodajNauCombo.Visible = false;
                DodajRokCombo.Visible = false;
            }
        }
    }

}
