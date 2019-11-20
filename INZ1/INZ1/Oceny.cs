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
    public partial class Oceny : MetroForm
    {
        SqlConnection cn = new SqlConnection("Data Source=(local);Initial Catalog=INZ;Integrated Security=True");
        private Form1 form1;
        string id = "";
        int x = 0;
        float y = 0;
        int lID = 0;
        int ID1 = 0;
        int ID2 = 0;
        int ID3 = 0;
        int ID4 = 0;
        int ID5 = 0;
        int ID6 = 0;
        int ID7 = 0;
        int ID8 = 0;
        string sr1 = "";
        string sr2 = "";
        string sr3 = "";
        string sr4 = "";
        string sr5 = "";
        string sr6 = "";
        string sr7 = "";
        string sr8 = "";
        bool popraw = false;
        public Oceny(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            string IDnau = form1.ID_Nau;
            
            ADDGRU();
            Zerowanie();
        }

        private void ADDGRU()
        {
            cn.Open();
            SqlCommand cm = new SqlCommand("Select Nazwa From Grupy Where ID_Nau = '"+ form1.ID_Nau +"'", cn);


            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                Grupa_combo.Items.Add(dr["Nazwa"]);
            }

            cn.Close();
            
        }

        private void Grupa_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cm = new SqlCommand("Select ID_uczen, Nazwisko, Imię From Uczniowie Where Grupa = '" + Grupa_combo.Text + "'", cn);
            Dodaj_ocene.Enabled = true;
            int i = 1;
            string id = "";
            Zerowanie();
            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                id = "";
                if (i == 1) { id = dr["ID_Uczen"].ToString(); Int32.TryParse(id, out ID1); Ucz_1.Text = dr["Nazwisko"].ToString(); Imie_1.Text = dr["Imię"].ToString(); }
                if (i == 2) { id = dr["ID_Uczen"].ToString(); Int32.TryParse(id, out ID2); Ucz_2.Text = dr["Nazwisko"].ToString(); Imie_2.Text = dr["Imię"].ToString(); }
                if (i == 3) { id = dr["ID_Uczen"].ToString(); Int32.TryParse(id, out ID3); Ucz_3.Text = dr["Nazwisko"].ToString(); Imie_3.Text = dr["Imię"].ToString(); }
                if (i == 4) { id = dr["ID_Uczen"].ToString(); Int32.TryParse(id, out ID4); Ucz_4.Text = dr["Nazwisko"].ToString(); Imie_4.Text = dr["Imię"].ToString(); }
                if (i == 5) { id = dr["ID_Uczen"].ToString(); Int32.TryParse(id, out ID5); Ucz_5.Text = dr["Nazwisko"].ToString(); Imie_5.Text = dr["Imię"].ToString(); }
                if (i == 6) { id = dr["ID_Uczen"].ToString(); Int32.TryParse(id, out ID6); Ucz_6.Text = dr["Nazwisko"].ToString(); Imie_6.Text = dr["Imię"].ToString(); }
                if (i == 7) { id = dr["ID_Uczen"].ToString(); Int32.TryParse(id, out ID7); Ucz_7.Text = dr["Nazwisko"].ToString(); Imie_7.Text = dr["Imię"].ToString(); }
                if (i == 8) { id = dr["ID_Uczen"].ToString(); Int32.TryParse(id, out ID8); Ucz_8.Text = dr["Nazwisko"].ToString(); Imie_8.Text = dr["Imię"].ToString(); }
                i++;
            }

            cn.Close();
            IDUCZ();
            ADDIDOCENY();
        }
        private void Zerowanie()
        {
            Ucz_1.Text = "";
            Ucz_2.Text = "";
            Ucz_3.Text = "";
            Ucz_4.Text = "";
            Ucz_5.Text = "";
            Ucz_6.Text = "";
            Ucz_7.Text = "";
            Ucz_8.Text = "";
            Imie_1.Text = "";
            Imie_2.Text = "";
            Imie_3.Text = "";
            Imie_4.Text = "";
            Imie_5.Text = "";
            Imie_6.Text = "";
            Imie_7.Text = "";
            Imie_8.Text = "";
        }

        private void Dodaj_ocene_Click(object sender, EventArgs e)
        {
            metroLabel2.Visible = true;
            metroLabel2.Text = "Typ Oceny:";
            metroLabel3.Visible = true;
            metroLabel3.Text = "Data:";
            metroLabel4.Visible = false;
            metroLabel5.Visible = false;
            if (Ucz_1.Text.Length>0) { metroComboBox1.Visible = true; }
            if (Ucz_2.Text.Length > 0) { metroComboBox2.Visible = true; }
            if (Ucz_3.Text.Length > 0) { metroComboBox3.Visible = true; }
            if (Ucz_4.Text.Length > 0) { metroComboBox4.Visible = true; }
            if (Ucz_5.Text.Length > 0) { metroComboBox5.Visible = true; }
            if (Ucz_6.Text.Length > 0) { metroComboBox6.Visible = true; }
            if (Ucz_7.Text.Length > 0) { metroComboBox7.Visible = true; }
            if (Ucz_8.Text.Length > 0) { metroComboBox8.Visible = true; }
            metroDateTime1.Visible = true;
            metroDateTime1.Value = System.DateTime.Today;
            Wstaw.Visible = true;
            Anuluj_Butt.Visible = true;
            Popraw.Enabled = false;
            ocena_1.Text = "Ocena:";
            ocena_2.Text = "Ocena:";
            ocena_3.Text = "Ocena:";
            ocena_4.Text = "Ocena:";
            ocena_5.Text = "Ocena:";
            ocena_6.Text = "Ocena:";
            ocena_7.Text = "Ocena:";
            ocena_8.Text = "Ocena:";
            if (Ucz_1.Text.Length > 0) { ocena_1.Visible = true; }
            if (Ucz_2.Text.Length > 0) { ocena_2.Visible = true; }
            if (Ucz_3.Text.Length > 0) { ocena_3.Visible = true; }
            if (Ucz_4.Text.Length > 0) { ocena_4.Visible = true; }
            if (Ucz_5.Text.Length > 0) { ocena_5.Visible = true; }
            if (Ucz_6.Text.Length > 0) { ocena_6.Visible = true; }
            if (Ucz_7.Text.Length > 0) { ocena_7.Visible = true; }
            if (Ucz_8.Text.Length > 0) { ocena_8.Visible = true; }
            metroComboBox9.SelectedIndex = 0;
            metroComboBox1.SelectedIndex = 0;
            metroComboBox2.SelectedIndex = 0;
            metroComboBox3.SelectedIndex = 0;
            metroComboBox4.SelectedIndex = 0;
            metroComboBox5.SelectedIndex = 0;
            metroComboBox6.SelectedIndex = 0;
            metroComboBox7.SelectedIndex = 0;
            metroComboBox8.SelectedIndex = 0;
            metroComboBox9.Visible = true;
            Wstaw.Text = "Wstaw";
        }
        private void ADDIDOCENY()
        {
            Ocena_combo.Items.Clear();
            Ocena_combo.Items.Add("Wszystkie");
            lID = 1;
            cn.Open();
            SqlCommand cm = new SqlCommand("Select ID From Oceny Where ID_Uczen = '" + x + "'", cn);


            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                Ocena_combo.Items.Add(dr["ID"]);
                lID++;
            }
            
            cn.Close();
        }
        private void IDUCZ()
        {
            x = 0;
            id = "";
            cn.Open();
            SqlCommand cm = new SqlCommand("Select ID_Uczen From Uczniowie Where Nazwisko = '" + Ucz_1.Text + "' and Grupa = '"+ Grupa_combo.Text+ "' and Imię = '" + Imie_1.Text + "'", cn);

            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {

                id = dr["ID_Uczen"].ToString();
            }


            Int32.TryParse(id, out x);
            

            cn.Close();
        }

        private void Wstaw_Click(object sender, EventArgs e)
        {
            cn.Open();

            if (popraw == true)
            {
                if (Ucz_1.Text.Length > 0)
                {
                               
                    SqlCommand cmd = new SqlCommand("Update Oceny SET Ocena = @Ocena, Typ_Oceny = @Typ_Oceny, Data = @Data  where ID = '" + Ocena_combo.Text + "' and Id_Uczen= '" + ID1 + "' and Rok ='" + form1.Rok + "'", cn);
                    float.TryParse(metroComboBox1.Text, out y);
                    cmd.Parameters.AddWithValue("Ocena", y);
                    cmd.Parameters.AddWithValue("Typ_Oceny", metroComboBox9.Text);
                    cmd.Parameters.AddWithValue("Data", metroDateTime1.Text);

                    cmd.ExecuteNonQuery();
                }
                if (Ucz_2.Text.Length > 0)
                {

                    SqlCommand cmd = new SqlCommand("Update Oceny SET Ocena = @Ocena, Typ_Oceny = @Typ_Oceny, Data = @Data  where ID = '" + Ocena_combo.Text + "' and Id_Uczen= '" + ID2 + "' and Rok ='" + form1.Rok + "'", cn);
                    float.TryParse(metroComboBox2.Text, out y);
                    cmd.Parameters.AddWithValue("Ocena", y);
                    cmd.Parameters.AddWithValue("Typ_Oceny", metroComboBox9.Text);
                    cmd.Parameters.AddWithValue("Data", metroDateTime1.Text);

                    cmd.ExecuteNonQuery();
                }
                if (Ucz_3.Text.Length > 0)
                {

                    SqlCommand cmd = new SqlCommand("Update Oceny SET Ocena = @Ocena, Typ_Oceny = @Typ_Oceny, Data = @Data  where ID = '" + Ocena_combo.Text + "' and Id_Uczen= '" + ID3 + "' and Rok ='" + form1.Rok + "'", cn);
                    float.TryParse(metroComboBox3.Text, out y);
                    cmd.Parameters.AddWithValue("Ocena", y);
                    cmd.Parameters.AddWithValue("Typ_Oceny", metroComboBox9.Text);
                    cmd.Parameters.AddWithValue("Data", metroDateTime1.Text);

                    cmd.ExecuteNonQuery();
                }
                if (Ucz_4.Text.Length > 0)
                {

                    SqlCommand cmd = new SqlCommand("Update Oceny SET Ocena = @Ocena, Typ_Oceny = @Typ_Oceny, Data = @Data  where ID = '" + Ocena_combo.Text + "' and Id_Uczen= '" + ID4 + "' and Rok ='" + form1.Rok + "'", cn);
                    float.TryParse(metroComboBox4.Text, out y);
                    cmd.Parameters.AddWithValue("Ocena", y);
                    cmd.Parameters.AddWithValue("Typ_Oceny", metroComboBox9.Text);
                    cmd.Parameters.AddWithValue("Data", metroDateTime1.Text);

                    cmd.ExecuteNonQuery();
                }
                if (Ucz_5.Text.Length > 0)
                {

                    SqlCommand cmd = new SqlCommand("Update Oceny SET Ocena = @Ocena, Typ_Oceny = @Typ_Oceny, Data = @Data  where ID = '" + Ocena_combo.Text + "' and Id_Uczen= '" + ID5 + "' and Rok ='" + form1.Rok + "'", cn);
                    float.TryParse(metroComboBox5.Text, out y);
                    cmd.Parameters.AddWithValue("Ocena", y);
                    cmd.Parameters.AddWithValue("Typ_Oceny", metroComboBox9.Text);
                    cmd.Parameters.AddWithValue("Data", metroDateTime1.Text);

                    cmd.ExecuteNonQuery();
                }
                if (Ucz_6.Text.Length > 0)
                {

                    SqlCommand cmd = new SqlCommand("Update Oceny SET Ocena = @Ocena, Typ_Oceny = @Typ_Oceny, Data = @Data  where ID = '" + Ocena_combo.Text + "' and Id_Uczen= '" + ID6 + "' and Rok ='" + form1.Rok + "'", cn);
                    float.TryParse(metroComboBox6.Text, out y);
                    cmd.Parameters.AddWithValue("Ocena", y);
                    cmd.Parameters.AddWithValue("Typ_Oceny", metroComboBox9.Text);
                    cmd.Parameters.AddWithValue("Data", metroDateTime1.Text);

                    cmd.ExecuteNonQuery();
                }
                if (Ucz_7.Text.Length > 0)
                {

                    SqlCommand cmd = new SqlCommand("Update Oceny SET Ocena = @Ocena, Typ_Oceny = @Typ_Oceny, Data = @Data  where ID = '" + Ocena_combo.Text + "' and Id_Uczen= '" + ID7 + "' and Rok ='" + form1.Rok + "'", cn);
                    float.TryParse(metroComboBox7.Text, out y);
                    cmd.Parameters.AddWithValue("Ocena", y);
                    cmd.Parameters.AddWithValue("Typ_Oceny", metroComboBox9.Text);
                    cmd.Parameters.AddWithValue("Data", metroDateTime1.Text);

                    cmd.ExecuteNonQuery();
                }
                if (Ucz_8.Text.Length > 0)
                {

                    SqlCommand cmd = new SqlCommand("Update Oceny SET Ocena = @Ocena, Typ_Oceny = @Typ_Oceny, Data = @Data  where ID = '" + Ocena_combo.Text + "' and Id_Uczen= '" + ID8 + "' and Rok ='" + form1.Rok + "'", cn);
                    float.TryParse(metroComboBox8.Text, out y);
                    cmd.Parameters.AddWithValue("Ocena", y);
                    cmd.Parameters.AddWithValue("Typ_Oceny", metroComboBox9.Text);
                    cmd.Parameters.AddWithValue("Data", metroDateTime1.Text);

                    cmd.ExecuteNonQuery();
                }
            }
            else
            {
                if (Ucz_1.Text.Length > 0)
                {


                    SqlCommand cmd = new SqlCommand("INSERT INTO Oceny (ID, ID_Uczen, Ocena, Rok, Typ_Oceny,Data) VALUES (@ID, @ID_Uczen, @Ocena, @Rok, @Typ_Oceny,@Data)");
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = cn;
                    cmd.Parameters.AddWithValue("@ID", lID);
                    cmd.Parameters.AddWithValue("@ID_Uczen", ID1);
                    float.TryParse(metroComboBox1.Text, out y);
                    cmd.Parameters.AddWithValue("@Ocena", y);
                    cmd.Parameters.AddWithValue("@Rok", form1.Rok);
                    cmd.Parameters.AddWithValue("@Typ_Oceny", metroComboBox9.Text);
                    cmd.Parameters.AddWithValue("@Data", metroDateTime1.Text);
                    cmd.ExecuteNonQuery();


                }
                if (Ucz_2.Text.Length > 0)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Oceny (ID, ID_Uczen, Ocena, Rok, Typ_Oceny,Data) VALUES (@ID, @ID_Uczen, @Ocena, @Rok, @Typ_Oceny,@Data)");
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = cn;
                    cmd.Parameters.AddWithValue("@ID", lID);
                    cmd.Parameters.AddWithValue("@ID_Uczen", ID2);
                    float.TryParse(metroComboBox2.Text, out y);
                    cmd.Parameters.AddWithValue("@Ocena", y);
                    cmd.Parameters.AddWithValue("@Rok", form1.Rok);
                    cmd.Parameters.AddWithValue("@Typ_Oceny", metroComboBox9.Text);
                    cmd.Parameters.AddWithValue("@Data", metroDateTime1.Text);
                    cmd.ExecuteNonQuery();
                }
                if (Ucz_3.Text.Length > 0)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Oceny (ID, ID_Uczen, Ocena, Rok, Typ_Oceny,Data) VALUES (@ID, @ID_Uczen, @Ocena, @Rok, @Typ_Oceny,@Data)");
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = cn;
                    cmd.Parameters.AddWithValue("@ID", lID);
                    cmd.Parameters.AddWithValue("@ID_Uczen", ID3);
                    float.TryParse(metroComboBox3.Text, out y);
                    cmd.Parameters.AddWithValue("@Ocena", y);
                    cmd.Parameters.AddWithValue("@Rok", form1.Rok);
                    cmd.Parameters.AddWithValue("@Typ_Oceny", metroComboBox9.Text);
                    cmd.Parameters.AddWithValue("@Data", metroDateTime1.Text);
                    cmd.ExecuteNonQuery();
                }
                if (Ucz_4.Text.Length > 0)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Oceny (ID, ID_Uczen, Ocena, Rok, Typ_Oceny,Data) VALUES (@ID, @ID_Uczen, @Ocena, @Rok, @Typ_Oceny,@Data)");
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = cn;
                    cmd.Parameters.AddWithValue("@ID", lID);
                    cmd.Parameters.AddWithValue("@ID_Uczen", ID4);
                    float.TryParse(metroComboBox4.Text, out y);
                    cmd.Parameters.AddWithValue("@Ocena", y);
                    cmd.Parameters.AddWithValue("@Rok", form1.Rok);
                    cmd.Parameters.AddWithValue("@Typ_Oceny", metroComboBox9.Text);
                    cmd.Parameters.AddWithValue("@Data", metroDateTime1.Text);
                    cmd.ExecuteNonQuery();
                }
                if (Ucz_5.Text.Length > 0)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Oceny (ID, ID_Uczen, Ocena, Rok, Typ_Oceny,Data) VALUES (@ID, @ID_Uczen, @Ocena, @Rok, @Typ_Oceny,@Data)");
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = cn;
                    cmd.Parameters.AddWithValue("@ID", lID);
                    cmd.Parameters.AddWithValue("@ID_Uczen", ID5);
                    float.TryParse(metroComboBox5.Text, out y);
                    cmd.Parameters.AddWithValue("@Ocena", y);
                    cmd.Parameters.AddWithValue("@Rok", form1.Rok);
                    cmd.Parameters.AddWithValue("@Typ_Oceny", metroComboBox9.Text);
                    cmd.Parameters.AddWithValue("@Data", metroDateTime1.Text);
                    cmd.ExecuteNonQuery();
                }
                if (Ucz_6.Text.Length > 0)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Oceny (ID, ID_Uczen, Ocena, Rok, Typ_Oceny) VALUES (@ID, @ID_Uczen, @Ocena, @Rok, @Typ_Oceny,@Data)");
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = cn;
                    cmd.Parameters.AddWithValue("@ID", lID);
                    cmd.Parameters.AddWithValue("@ID_Uczen", ID6);
                    float.TryParse(metroComboBox6.Text, out y);
                    cmd.Parameters.AddWithValue("@Ocena", y);
                    cmd.Parameters.AddWithValue("@Rok", form1.Rok);
                    cmd.Parameters.AddWithValue("@Typ_Oceny", metroComboBox9.Text);
                    cmd.Parameters.AddWithValue("@Data", metroDateTime1.Text);
                    cmd.ExecuteNonQuery();
                }
                if (Ucz_7.Text.Length > 0)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Oceny (ID, ID_Uczen, Ocena, Rok, Typ_Oceny,Data) VALUES (@ID, @ID_Uczen, @Ocena, @Rok, @Typ_Oceny,@Data)");
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = cn;
                    cmd.Parameters.AddWithValue("@ID", lID);
                    cmd.Parameters.AddWithValue("@ID_Uczen", ID7);
                    float.TryParse(metroComboBox7.Text, out y);
                    cmd.Parameters.AddWithValue("@Ocena", y);
                    cmd.Parameters.AddWithValue("@Rok", form1.Rok);
                    cmd.Parameters.AddWithValue("@Typ_Oceny", metroComboBox9.Text);
                    cmd.Parameters.AddWithValue("@Data", metroDateTime1.Text);
                    cmd.ExecuteNonQuery();
                }
                if (Ucz_8.Text.Length > 0)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Oceny (ID, ID_Uczen, Ocena, Rok, Typ_Oceny,Data) VALUES (@ID, @ID_Uczen, @Ocena, @Rok, @Typ_Oceny,@Data)");
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = cn;
                    cmd.Parameters.AddWithValue("@ID", lID);
                    cmd.Parameters.AddWithValue("@ID_Uczen", ID8);
                    float.TryParse(metroComboBox8.Text, out y);
                    cmd.Parameters.AddWithValue("@Ocena", y);
                    cmd.Parameters.AddWithValue("@Rok", form1.Rok);
                    cmd.Parameters.AddWithValue("@Typ_Oceny", metroComboBox9.Text);
                    cmd.Parameters.AddWithValue("@Data", metroDateTime1.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            cn.Close();
            Srednia();
            DodSred();
            if (popraw != true) { MessageBox.Show("Dodano!"); }
            else { MessageBox.Show("Zaktualizowano!"); }
            metroLabel2.Visible = false;
            metroLabel3.Visible = false;
            metroComboBox1.Visible = false;
            metroComboBox2.Visible = false;
            metroComboBox3.Visible = false;
            metroComboBox4.Visible = false;
            metroComboBox5.Visible = false;
            metroComboBox6.Visible = false;
            metroComboBox7.Visible = false;
            metroComboBox8.Visible = false;
            metroComboBox9.Visible = false;
            metroDateTime1.Visible = false;
            Wstaw.Visible = false;
            Anuluj_Butt.Visible = false;
            ocena_1.Visible = false;
            ocena_2.Visible = false;
            ocena_3.Visible = false;
            ocena_4.Visible = false;
            ocena_5.Visible = false;
            ocena_6.Visible = false;
            ocena_7.Visible = false;
            ocena_8.Visible = false;
            Grupa_combo.Enabled = true;
            Ocena_combo.Enabled = true;
            ADDIDOCENY();
            Ocena_combo.SelectedIndex = 0;
            Popraw.Enabled = true;
            popraw = false;
            
        }

        private void Anuluj_Butt_Click(object sender, EventArgs e)
        {
            metroLabel2.Visible = false;
            metroLabel3.Visible = false;
            metroComboBox1.Visible = false;
            metroComboBox2.Visible = false;
            metroComboBox3.Visible = false;
            metroComboBox4.Visible = false;
            metroComboBox5.Visible = false;
            metroComboBox6.Visible = false;
            metroComboBox7.Visible = false;
            metroComboBox8.Visible = false;
            metroComboBox9.Visible = false;
            metroDateTime1.Visible = false;
            Wstaw.Visible = false;
            Anuluj_Butt.Visible = false;
            ocena_1.Visible = false;
            ocena_2.Visible = false;
            ocena_3.Visible = false;
            ocena_4.Visible = false;
            ocena_5.Visible = false;
            ocena_6.Visible = false;
            ocena_7.Visible = false;
            ocena_8.Visible = false;
            Popraw.Enabled = true;
            Grupa_combo.Enabled = true;
            Ocena_combo.Enabled = true;
            Ocena_combo.SelectedIndex = 0;
            popraw = false;
        }

        private void Ocena_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Popraw.Enabled = true;
            ocena_1.Text = "";
            ocena_2.Text = "";
            ocena_3.Text = "";
            ocena_4.Text = "";
            ocena_5.Text = "";
            ocena_6.Text = "";
            ocena_7.Text = "";
            ocena_8.Text = "";

            if (Ocena_combo.Text == "Wszystkie")
            {
                Popraw.Enabled = false;
                metroLabel2.Visible = false;
                metroLabel3.Visible = false;
                metroLabel4.Visible = false;
                metroLabel5.Visible = false;

            }
            else
            {
                metroLabel2.Visible = true;
                metroLabel3.Visible = true;
                metroLabel4.Visible = true;
                metroLabel5.Visible = true;
            }
            if(Ucz_1.Text.Length > 0) { wcz1(); }
            if (Ucz_2.Text.Length > 0) { wcz2(); }
            if (Ucz_3.Text.Length > 0) { wcz3(); }
            if (Ucz_4.Text.Length > 0) { wcz4(); }
            if (Ucz_5.Text.Length > 0) { wcz5(); }
            if (Ucz_6.Text.Length > 0) { wcz6(); }
            if (Ucz_7.Text.Length > 0) { wcz7(); }
            if (Ucz_8.Text.Length > 0) { wcz8(); }
        }
        private void wcz1()
        {
            cn.Open();
            if (Ocena_combo.Text == "Wszystkie")
            {

                ocena_1.Text = "";
                ocena_1.Visible = true;
                SqlCommand cm = new SqlCommand("Select Ocena From Oceny Where ID_Uczen = '" +ID1+ "' ", cn);

                SqlDataReader dr = cm.ExecuteReader();

                while (dr.Read())
                {

                    ocena_1.Text = ocena_1.Text + dr["Ocena"]+ "  ";
                }

            }
            else
            {
                ocena_1.Text = "";
                ocena_1.Visible = true;
                SqlCommand cm = new SqlCommand("Select Ocena, Typ_Oceny, Data From Oceny Where ID_Uczen = '" + ID1 + "'and ID= '"+Ocena_combo.Text +"' ", cn);

                SqlDataReader dr = cm.ExecuteReader();

                while (dr.Read())
                {

                    ocena_1.Text = dr["Ocena"].ToString();
                    metroLabel2.Text = dr["Typ_Oceny"].ToString();
                    metroLabel3.Text = dr["Data"].ToString();

                }
            }


            cn.Close();
        }
        private void wcz2()
        {
            cn.Open();
            if (Ocena_combo.Text == "Wszystkie")
            {

                ocena_2.Text = "";
                ocena_2.Visible = true;
                SqlCommand cm = new SqlCommand("Select Ocena From Oceny Where ID_Uczen = '" + ID2 + "' ", cn);

                SqlDataReader dr = cm.ExecuteReader();

                while (dr.Read())
                {

                    ocena_2.Text = ocena_2.Text + dr["Ocena"] + "  ";
                }

            }
            else
            {
                ocena_2.Text = "";
                ocena_2.Visible = true;
                SqlCommand cm = new SqlCommand("Select Ocena From Oceny Where ID_Uczen = '" + ID2 + "'and ID= '" + Ocena_combo.Text + "' ", cn);

                SqlDataReader dr = cm.ExecuteReader();

                while (dr.Read())
                {

                    ocena_2.Text = dr["Ocena"].ToString();
                }
            }


            cn.Close();
        }
        private void wcz3()
        {
            cn.Open();
            if (Ocena_combo.Text == "Wszystkie")
            {

                ocena_3.Text = "";
                ocena_3.Visible = true;
                SqlCommand cm = new SqlCommand("Select Ocena From Oceny Where ID_Uczen = '" + ID3 + "' ", cn);

                SqlDataReader dr = cm.ExecuteReader();

                while (dr.Read())
                {

                    ocena_3.Text = ocena_3.Text + dr["Ocena"] + "  ";
                }

            }
            else
            {
                ocena_3.Text = "";
                ocena_3.Visible = true;
                SqlCommand cm = new SqlCommand("Select Ocena From Oceny Where ID_Uczen = '" + ID3 + "'and ID= '" + Ocena_combo.Text + "' ", cn);

                SqlDataReader dr = cm.ExecuteReader();

                while (dr.Read())
                {

                    ocena_3.Text = dr["Ocena"].ToString();
                }
            }


            cn.Close();
        }
        private void wcz4()
        {
            cn.Open();
            if (Ocena_combo.Text == "Wszystkie")
            {

                ocena_4.Text = "";
                ocena_4.Visible = true;
                SqlCommand cm = new SqlCommand("Select Ocena From Oceny Where ID_Uczen = '" + ID4 + "' ", cn);

                SqlDataReader dr = cm.ExecuteReader();

                while (dr.Read())
                {

                    ocena_4.Text = ocena_4.Text + dr["Ocena"] + "  ";
                }

            }
            else
            {
                ocena_4.Text = "";
                ocena_4.Visible = true;
                SqlCommand cm = new SqlCommand("Select Ocena From Oceny Where ID_Uczen = '" + ID4 + "'and ID= '" + Ocena_combo.Text + "' ", cn);

                SqlDataReader dr = cm.ExecuteReader();

                while (dr.Read())
                {

                    ocena_4.Text = dr["Ocena"].ToString();
                }
            }


            cn.Close();
        }
        private void wcz5()
        {
            cn.Open();
            if (Ocena_combo.Text == "Wszystkie")
            {

                ocena_5.Text = "";
                ocena_5.Visible = true;
                SqlCommand cm = new SqlCommand("Select Ocena From Oceny Where ID_Uczen = '" + ID5 + "' ", cn);

                SqlDataReader dr = cm.ExecuteReader();

                while (dr.Read())
                {

                    ocena_5.Text = ocena_5.Text + dr["Ocena"] + "  ";
                }

            }
            else
            {
                ocena_5.Text = "";
                ocena_5.Visible = true;
                SqlCommand cm = new SqlCommand("Select Ocena From Oceny Where ID_Uczen = '" + ID5 + "'and ID= '" + Ocena_combo.Text + "' ", cn);

                SqlDataReader dr = cm.ExecuteReader();

                while (dr.Read())
                {

                    ocena_5.Text = dr["Ocena"].ToString();
                }
            }


            cn.Close();
        }
        private void wcz6()
        {
            cn.Open();
            if (Ocena_combo.Text == "Wszystkie")
            {

                ocena_6.Text = "";
                ocena_6.Visible = true;
                SqlCommand cm = new SqlCommand("Select Ocena From Oceny Where ID_Uczen = '" + ID6 + "' ", cn);

                SqlDataReader dr = cm.ExecuteReader();

                while (dr.Read())
                {

                    ocena_6.Text = ocena_6.Text + dr["Ocena"] + "  ";
                }

            }
            else
            {
                ocena_6.Text = "";
                ocena_6.Visible = true;
                SqlCommand cm = new SqlCommand("Select Ocena From Oceny Where ID_Uczen = '" + ID6 + "'and ID= '" + Ocena_combo.Text + "' ", cn);

                SqlDataReader dr = cm.ExecuteReader();

                while (dr.Read())
                {

                    ocena_6.Text = dr["Ocena"].ToString();
                }
            }


            cn.Close();
        }
        private void wcz7()
        {
            cn.Open();
            if (Ocena_combo.Text == "Wszystkie")
            {

                ocena_7.Text = "";
                ocena_7.Visible = true;
                SqlCommand cm = new SqlCommand("Select Ocena From Oceny Where ID_Uczen = '" + ID7 + "' ", cn);

                SqlDataReader dr = cm.ExecuteReader();

                while (dr.Read())
                {

                    ocena_7.Text = ocena_7.Text + dr["Ocena"] + "  ";
                }

            }
            else
            {
                ocena_7.Text = "";
                ocena_7.Visible = true;
                SqlCommand cm = new SqlCommand("Select Ocena From Oceny Where ID_Uczen = '" + ID7 + "'and ID= '" + Ocena_combo.Text + "' ", cn);

                SqlDataReader dr = cm.ExecuteReader();

                while (dr.Read())
                {

                    ocena_7.Text = dr["Ocena"].ToString();
                }
            }


            cn.Close();
        }
        private void wcz8()
        {
            cn.Open();
            if (Ocena_combo.Text == "Wszystkie")
            {

                ocena_8.Text = "";
                ocena_8.Visible = true;
                SqlCommand cm = new SqlCommand("Select Ocena From Oceny Where ID_Uczen = '" + ID8 + "' ", cn);

                SqlDataReader dr = cm.ExecuteReader();

                while (dr.Read())
                {

                    ocena_8.Text = ocena_8.Text + dr["Ocena"] + "  ";
                }

            }
            else
            {
                ocena_8.Text = "";
                ocena_8.Visible = true;
                SqlCommand cm = new SqlCommand("Select Ocena From Oceny Where ID_Uczen = '" + ID8 + "'and ID= '" + Ocena_combo.Text + "' ", cn);

                SqlDataReader dr = cm.ExecuteReader();

                while (dr.Read())
                {

                    ocena_8.Text = dr["Ocena"].ToString();
                }
            }


            cn.Close();
        }

        private void Popraw_Click(object sender, EventArgs e)
        {
            metroDateTime1.Text = metroLabel3.Text;
            metroComboBox9.Text = metroLabel2.Text;
            metroLabel2.Visible = true;
            metroLabel2.Text = "Typ Oceny:";
            metroLabel3.Visible = true;
            metroLabel3.Text = "Data:";
            metroLabel4.Visible = false;
            metroLabel5.Visible = false;
            if (Ucz_1.Text.Length > 0) { metroComboBox1.Visible = true; }
            if (Ucz_2.Text.Length > 0) { metroComboBox2.Visible = true; }
            if (Ucz_3.Text.Length > 0) { metroComboBox3.Visible = true; }
            if (Ucz_4.Text.Length > 0) { metroComboBox4.Visible = true; }
            if (Ucz_5.Text.Length > 0) { metroComboBox5.Visible = true; }
            if (Ucz_6.Text.Length > 0) { metroComboBox6.Visible = true; }
            if (Ucz_7.Text.Length > 0) { metroComboBox7.Visible = true; }
            if (Ucz_8.Text.Length > 0) { metroComboBox8.Visible = true; }
            metroComboBox9.Visible = true;
            metroDateTime1.Visible = true;
            Wstaw.Visible = true;
            Anuluj_Butt.Visible = true;
            Popraw.Enabled = false;
            Wstaw.Text = "Aktualizuj";
            ocena_1.Visible = true;
            ocena_2.Visible = true;
            ocena_3.Visible = true;
            ocena_4.Visible = true;
            ocena_5.Visible = true;
            ocena_6.Visible = true;
            ocena_7.Visible = true;
            ocena_8.Visible = true;
            
            metroComboBox1.SelectedIndex = 0;
            metroComboBox2.SelectedIndex = 0;
            metroComboBox3.SelectedIndex = 0;
            metroComboBox4.SelectedIndex = 0;
            metroComboBox5.SelectedIndex = 0;
            metroComboBox6.SelectedIndex = 0;
            metroComboBox7.SelectedIndex = 0;
            metroComboBox8.SelectedIndex = 0;
            Grupa_combo.Enabled = false;
            Ocena_combo.Enabled = false;
            popraw = true;
            if (Ucz_1.Text.Length > 0) { metroComboBox1.Text = ocena_1.Text; }
            if (Ucz_2.Text.Length > 0) { metroComboBox2.Text = ocena_2.Text; }
            if (Ucz_3.Text.Length > 0) { metroComboBox3.Text = ocena_3.Text; }
            if (Ucz_4.Text.Length > 0) { metroComboBox4.Text = ocena_4.Text; }
            if (Ucz_5.Text.Length > 0) { metroComboBox5.Text = ocena_5.Text; }
            if (Ucz_6.Text.Length > 0) { metroComboBox6.Text = ocena_6.Text; }
            if (Ucz_7.Text.Length > 0) { metroComboBox7.Text = ocena_7.Text; }
            if (Ucz_8.Text.Length > 0) { metroComboBox8.Text = ocena_8.Text; }
        }
        private void Srednia()
        {
            if (Ucz_1.Text.Length > 0)
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("Select Ocena from Oceny Where ID_Uczen = '" + ID1 + "'", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                string a = "";
                float b = 0;
                float licz = 0;
                float sum = 0;
                
                while (dr.Read())
                {
                    a = "";
                    a = dr["Ocena"].ToString();
                    float.TryParse(a,out b);
                    sum = sum + b;
                    licz++;

                }
                float fr = 0;
                if (licz == 0) { licz = 1; }
                fr = sum / licz;
                sr1 = string.Format("{0:0.00}", fr );
                
                cn.Close();
            }
            if (Ucz_2.Text.Length > 0)
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("Select Ocena from Oceny Where ID_Uczen = '" + ID2 + "'", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                string a = "";
                float b = 0;
                float licz = 0;
                float sum = 0;

                while (dr.Read())
                {
                    a = "";
                    a = dr["Ocena"].ToString();
                    float.TryParse(a, out b);
                    sum = sum + b;
                    licz++;

                }
                float fr = 0;
                if (licz == 0) { licz = 1; }
                fr = sum / licz;
                sr2 = string.Format("{0:0.00}", fr);

                cn.Close();
            }
            if (Ucz_3.Text.Length > 0)
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("Select Ocena from Oceny Where ID_Uczen = '" + ID3 + "'", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                string a = "";
                float b = 0;
                float licz = 0;
                float sum = 0;

                while (dr.Read())
                {
                    a = "";
                    a = dr["Ocena"].ToString();
                    float.TryParse(a, out b);
                    sum = sum + b;
                    licz++;

                }
                float fr = 0;
                if (licz == 0) { licz = 1; }
                fr = sum / licz;
                sr3 = string.Format("{0:0.00}", fr);

                cn.Close();
            }
            if (Ucz_4.Text.Length > 0)
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("Select Ocena from Oceny Where ID_Uczen = '" + ID4 + "'", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                string a = "";
                float b = 0;
                float licz = 0;
                float sum = 0;

                while (dr.Read())
                {
                    a = "";
                    a = dr["Ocena"].ToString();
                    float.TryParse(a, out b);
                    sum = sum + b;
                    licz++;

                }
                float fr = 0;
                if (licz == 0) { licz = 1; }
                fr = sum / licz;
                sr4 = string.Format("{0:0.00}", fr);

                cn.Close();
            }
            if (Ucz_5.Text.Length > 0)
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("Select Ocena from Oceny Where ID_Uczen = '" + ID5 + "'", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                string a = "";
                float b = 0;
                float licz = 0;
                float sum = 0;

                while (dr.Read())
                {
                    a = "";
                    a = dr["Ocena"].ToString();
                    float.TryParse(a, out b);
                    sum = sum + b;
                    licz++;

                }
                float fr = 0;
                if (licz == 0) { licz = 1; }
                fr = sum / licz;
                sr5 = string.Format("{0:0.00}", fr);

                cn.Close();
            }
            if (Ucz_6.Text.Length > 0)
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("Select Ocena from Oceny Where ID_Uczen = '" + ID6 + "'", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                string a = "";
                float b = 0;
                float licz = 0;
                float sum = 0;

                while (dr.Read())
                {
                    a = "";
                    a = dr["Ocena"].ToString();
                    float.TryParse(a, out b);
                    sum = sum + b;
                    licz++;

                }
                float fr = 0;
                if (licz == 0) { licz = 1; }
                fr = sum / licz;
                sr6 = string.Format("{0:0.00}", fr);

                cn.Close();
            }
            if (Ucz_7.Text.Length > 0)
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("Select Ocena from Oceny Where ID_Uczen = '" + ID7 + "'", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                string a = "";
                float b = 0;
                float licz = 0;
                float sum = 0;

                while (dr.Read())
                {
                    a = "";
                    a = dr["Ocena"].ToString();
                    float.TryParse(a, out b);
                    sum = sum + b;
                    licz++;

                }
                float fr = 0;
                if (licz == 0) { licz = 1; }
                fr = sum / licz;
                sr7 = string.Format("{0:0.00}", fr);

                cn.Close();
            }
            if (Ucz_8.Text.Length > 0)
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("Select Ocena from Oceny Where ID_Uczen = '" + ID8 + "'", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                string a = "";
                float b = 0;
                float licz = 0;
                float sum = 0;

                while (dr.Read())
                {
                    a = "";
                    a = dr["Ocena"].ToString();
                    float.TryParse(a, out b);
                    sum = sum + b;
                    licz++;

                }
                float fr = 0;
                if (licz == 0) { licz = 1; }
                fr = sum / licz;
                sr8 = string.Format("{0:0.00}", fr);

                cn.Close();
            }

           
        }
        private void DodSred()
        {
            cn.Open();
            if (Ucz_1.Text.Length > 0)
            {
                SqlCommand cmd = new SqlCommand("Update Uczniowie SET Średnia = @Średnia  where Id_Uczen= '" + ID1 + "'", cn);
                cmd.Parameters.AddWithValue("Średnia", sr1);


                cmd.ExecuteNonQuery();
            }
            if (Ucz_2.Text.Length > 0)
            {
                SqlCommand cmd = new SqlCommand("Update Uczniowie SET Średnia = @Średnia  where Id_Uczen= '" + ID2 + "'", cn);
                cmd.Parameters.AddWithValue("Średnia", sr2);


                cmd.ExecuteNonQuery();
            }
            if (Ucz_3.Text.Length > 0)
            {
                SqlCommand cmd = new SqlCommand("Update Uczniowie SET Średnia = @Średnia  where Id_Uczen= '" + ID3 + "'", cn);
                cmd.Parameters.AddWithValue("Średnia", sr3);


                cmd.ExecuteNonQuery();
            }
            if (Ucz_4.Text.Length > 0)
            {
                SqlCommand cmd = new SqlCommand("Update Uczniowie SET Średnia = @Średnia  where Id_Uczen= '" + ID4 + "'", cn);
                cmd.Parameters.AddWithValue("Średnia", sr4);


                cmd.ExecuteNonQuery();
            }
            if (Ucz_5.Text.Length > 0)
            {
                SqlCommand cmd = new SqlCommand("Update Uczniowie SET Średnia = @Średnia  where Id_Uczen= '" + ID5 + "'", cn);
                cmd.Parameters.AddWithValue("Średnia", sr5);


                cmd.ExecuteNonQuery();
            }
            if (Ucz_6.Text.Length > 0)
            {
                SqlCommand cmd = new SqlCommand("Update Uczniowie SET Średnia = @Średnia  where Id_Uczen= '" + ID6 + "'", cn);
                cmd.Parameters.AddWithValue("Średnia", sr6);


                cmd.ExecuteNonQuery();
            }
            if (Ucz_7.Text.Length > 0)
            {
                SqlCommand cmd = new SqlCommand("Update Uczniowie SET Średnia = @Średnia  where Id_Uczen= '" + ID7 + "'", cn);
                cmd.Parameters.AddWithValue("Średnia", sr7);


                cmd.ExecuteNonQuery();
            }
            if (Ucz_8.Text.Length > 0)
            {
                SqlCommand cmd = new SqlCommand("Update Uczniowie SET Średnia = @Średnia  where Id_Uczen= '" + ID8 + "'", cn);
                cmd.Parameters.AddWithValue("Średnia", sr8);


                cmd.ExecuteNonQuery();
            }

            cn.Close();
        }
    }
}




