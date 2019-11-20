using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INZ1
{
    public partial class Obecnosci : MetroForm
    {
        SqlConnection cn = new SqlConnection("Data Source=(local);Initial Catalog=INZ;Integrated Security=True");
        private Form1 form1;
        int lID = 0;
        int ID1 = 0;
        int ID2 = 0;
        int ID3 = 0;
        int ID4 = 0;
        int ID5 = 0;
        int ID6 = 0;
        int ID7 = 0;
        int ID8 = 0;
        float y = 0;
        bool edi = false;
        string frek1 = "";
        
        string frek2 = "";
        string frek3 = "";
        string frek4 = "";
        string frek5 = "";
        string frek6 = "";
        string frek7 = "";
        string frek8 = "";
        public Obecnosci(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            ADDGRU();
            zerowanie();
            
        }
        private void ADDGRU()
        {
            cn.Open();
            SqlCommand cm = new SqlCommand("Select Nazwa From Grupy Where ID_Nau = '" + form1.ID_Nau + "'", cn);


            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                metroComboBox1.Items.Add(dr["Nazwa"]);
            }

            cn.Close();

        }
        private void zerowanie()
        {
            Imie_1.Text = "";
            Imie_2.Text = "";
            Imie_3.Text = "";
            Imie_4.Text = "";
            Imie_5.Text = "";
            Imie_6.Text = "";
            Imie_7.Text = "";
            Imie_8.Text = "";
            Nazwisko_1.Text = "";
            Nazwisko_2.Text = "";
            Nazwisko_3.Text = "";
            Nazwisko_4.Text = "";
            Nazwisko_5.Text = "";
            Nazwisko_6.Text = "";
            Nazwisko_7.Text = "";
            Nazwisko_8.Text = "";
            metroCheckBox1.Checked = true;
            metroCheckBox2.Checked = true;
            metroCheckBox3.Checked = true;
            metroCheckBox4.Checked = true;
            metroCheckBox5.Checked = true;
            metroCheckBox6.Checked = true;
            metroCheckBox7.Checked = true;
            metroCheckBox8.Checked = true;
            metroCheckBox1.Visible = false;
            metroCheckBox2.Visible = false;
            metroCheckBox3.Visible = false;
            metroCheckBox4.Visible = false;
            metroCheckBox5.Visible = false;
            metroCheckBox6.Visible = false;
            metroCheckBox7.Visible = false;
            metroCheckBox8.Visible = false;
            metroLabel6.Visible = false;
            metroDateTime1.Visible = false;
            metroButton3.Visible = false;
            metroButton4.Visible = false;
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cn.Open();
            metroButton1.Enabled = true;
            SqlCommand cm = new SqlCommand("Select ID_uczen, Nazwisko, Imię From Uczniowie Where Grupa = '" + metroComboBox1.Text + "'", cn);
            
            int i = 1;
            string id = "";
            zerowanie();
            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                id = "";
                if (i == 1) { id = dr["ID_Uczen"].ToString(); Int32.TryParse(id, out ID1); Nazwisko_1.Text = dr["Nazwisko"].ToString(); Imie_1.Text = dr["Imię"].ToString(); }
                if (i == 2) { id = dr["ID_Uczen"].ToString(); Int32.TryParse(id, out ID2); Nazwisko_2.Text = dr["Nazwisko"].ToString(); Imie_2.Text = dr["Imię"].ToString(); }
                if (i == 3) { id = dr["ID_Uczen"].ToString(); Int32.TryParse(id, out ID3); Nazwisko_3.Text = dr["Nazwisko"].ToString(); Imie_3.Text = dr["Imię"].ToString(); }
                if (i == 4) { id = dr["ID_Uczen"].ToString(); Int32.TryParse(id, out ID4); Nazwisko_4.Text = dr["Nazwisko"].ToString(); Imie_4.Text = dr["Imię"].ToString(); }
                if (i == 5) { id = dr["ID_Uczen"].ToString(); Int32.TryParse(id, out ID5); Nazwisko_5.Text = dr["Nazwisko"].ToString(); Imie_5.Text = dr["Imię"].ToString(); }
                if (i == 6) { id = dr["ID_Uczen"].ToString(); Int32.TryParse(id, out ID6); Nazwisko_6.Text = dr["Nazwisko"].ToString(); Imie_6.Text = dr["Imię"].ToString(); }
                if (i == 7) { id = dr["ID_Uczen"].ToString(); Int32.TryParse(id, out ID7); Nazwisko_7.Text = dr["Nazwisko"].ToString(); Imie_7.Text = dr["Imię"].ToString(); }
                if (i == 8) { id = dr["ID_Uczen"].ToString(); Int32.TryParse(id, out ID8); Nazwisko_8.Text = dr["Nazwisko"].ToString(); Imie_8.Text = dr["Imię"].ToString(); }
                i++;
            }

            cn.Close();
            AddNR();
            
        }
        private void AddNR()
        {
            metroComboBox2.Items.Clear();
            lID = 0;
            cn.Open();
            SqlCommand cm = new SqlCommand("Select NR_Zajęć From Obecności Where ID_Uczen = '" + ID1 + "'", cn);


            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                metroComboBox2.Items.Add(dr["NR_Zajęć"]);
                lID++;
            }

            cn.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (Imie_1.Text.Length>0) { metroCheckBox1.Visible = true; }
            if (Imie_2.Text.Length > 0) { metroCheckBox2.Visible = true; }
            if (Imie_3.Text.Length > 0) { metroCheckBox3.Visible = true; }
            if (Imie_4.Text.Length > 0) { metroCheckBox4.Visible = true; }
            if (Imie_5.Text.Length > 0) { metroCheckBox5.Visible = true; }
            if (Imie_6.Text.Length > 0) { metroCheckBox6.Visible = true; }
            if (Imie_7.Text.Length > 0) { metroCheckBox7.Visible = true; }
            if (Imie_8.Text.Length > 0) { metroCheckBox8.Visible = true; }
            metroLabel6.Visible = true;
            metroDateTime1.Visible = true;
            metroButton3.Visible = true;
            metroButton4.Visible = true;
            metroComboBox1.Enabled = false;
            metroComboBox2.Enabled = false;
            Datalabel.Visible = false;
            metroCheckBox1.Enabled = true;
            metroCheckBox2.Enabled = true;
            metroCheckBox3.Enabled = true;
            metroCheckBox4.Enabled = true;
            metroCheckBox5.Enabled = true;
            metroCheckBox6.Enabled = true;
            metroCheckBox7.Enabled = true;
            metroCheckBox8.Enabled = true;
            metroButton2.Enabled = false;
            metroDateTime1.Value = System.DateTime.Today;
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {

            metroCheckBox1.Checked = true;
            metroCheckBox2.Checked = true;
            metroCheckBox3.Checked = true;
            metroCheckBox4.Checked = true;
            metroCheckBox5.Checked = true;
            metroCheckBox6.Checked = true;
            metroCheckBox7.Checked = true;
            metroCheckBox8.Checked = true;
            metroCheckBox1.Visible = false;
            metroCheckBox2.Visible = false;
            metroCheckBox3.Visible = false;
            metroCheckBox4.Visible = false;
            metroCheckBox5.Visible = false;
            metroCheckBox6.Visible = false;
            metroCheckBox7.Visible = false;
            metroCheckBox8.Visible = false;
            metroLabel6.Visible = false;
            metroDateTime1.Visible = false;
            metroButton3.Visible = false;
            metroButton4.Visible = false;
            metroComboBox1.Enabled = true;
            metroComboBox2.Enabled = true;
            edi = false;
            metroButton1.Enabled = true;
            metroButton3.Text = "Dodaj";
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            cn.Open();

            if (edi == true)
            {
                if (Nazwisko_1.Text.Length > 0)
                {

                    SqlCommand cmd = new SqlCommand("Update Obecności SET Data = @Data, Obecny=@Obecny  where Id_Uczen= '" + ID1 + "' and NR_Zajęć ='" + metroComboBox2.Text + "'", cn);
                    cmd.Parameters.AddWithValue("Obecny", metroCheckBox1.Checked);
                    cmd.Parameters.AddWithValue("Data", metroDateTime1.Text);

                    cmd.ExecuteNonQuery();
                }
                if (Nazwisko_2.Text.Length > 0)
                {

                    SqlCommand cmd = new SqlCommand("Update Obecności SET Data = @Data, Obecny=@Obecny  where Id_Uczen= '" + ID2 + "' and NR_Zajęć ='" + metroComboBox2.Text + "'", cn);
                    cmd.Parameters.AddWithValue("Obecny", metroCheckBox2.Checked);
                    cmd.Parameters.AddWithValue("Data", metroDateTime1.Text);

                    cmd.ExecuteNonQuery();
                }
                if (Nazwisko_3.Text.Length > 0)
                {

                    SqlCommand cmd = new SqlCommand("Update Obecności SET Data = @Data, Obecny=@Obecny  where Id_Uczen= '" + ID3 + "' and NR_Zajęć ='" + metroComboBox2.Text + "'", cn);
                    cmd.Parameters.AddWithValue("Obecny", metroCheckBox3.Checked);
                    cmd.Parameters.AddWithValue("Data", metroDateTime1.Text);

                    cmd.ExecuteNonQuery();
                }
                if (Nazwisko_4.Text.Length > 0)
                {

                    SqlCommand cmd = new SqlCommand("Update Obecności SET Data = @Data, Obecny=@Obecny  where Id_Uczen= '" + ID4 + "' and NR_Zajęć ='" + metroComboBox2.Text + "'", cn);
                    cmd.Parameters.AddWithValue("Obecny", metroCheckBox4.Checked);
                    cmd.Parameters.AddWithValue("Data", metroDateTime1.Text);

                    cmd.ExecuteNonQuery();
                }
                if (Nazwisko_5.Text.Length > 0)
                {

                    SqlCommand cmd = new SqlCommand("Update Obecności SET Data = @Data, Obecny=@Obecny  where Id_Uczen= '" + ID5 + "' and NR_Zajęć ='" + metroComboBox2.Text + "'", cn);
                    cmd.Parameters.AddWithValue("Obecny", metroCheckBox5.Checked);
                    cmd.Parameters.AddWithValue("Data", metroDateTime1.Text);

                    cmd.ExecuteNonQuery();
                }
                if (Nazwisko_6.Text.Length > 0)
                {

                    SqlCommand cmd = new SqlCommand("Update Obecności SET Data = @Data, Obecny=@Obecny  where Id_Uczen= '" + ID6 + "' and NR_Zajęć ='" + metroComboBox2.Text + "'", cn);
                    cmd.Parameters.AddWithValue("Obecny", metroCheckBox6.Checked);
                    cmd.Parameters.AddWithValue("Data", metroDateTime1.Text);

                    cmd.ExecuteNonQuery();
                }
                if (Nazwisko_7.Text.Length > 0)
                {

                    SqlCommand cmd = new SqlCommand("Update Obecności SET Data = @Data, Obecny=@Obecny  where Id_Uczen= '" + ID7 + "' and NR_Zajęć ='" + metroComboBox2.Text + "'", cn);
                    cmd.Parameters.AddWithValue("Obecny", metroCheckBox7.Checked);
                    cmd.Parameters.AddWithValue("Data", metroDateTime1.Text);

                    cmd.ExecuteNonQuery();
                }
                if (Nazwisko_8.Text.Length > 0)
                {

                    SqlCommand cmd = new SqlCommand("Update Obecności SET Data = @Data, Obecny=@Obecny  where Id_Uczen= '" + ID8 + "' and NR_Zajęć ='" + metroComboBox2.Text + "'", cn);
                    cmd.Parameters.AddWithValue("Obecny", metroCheckBox8.Checked);
                    cmd.Parameters.AddWithValue("Data", metroDateTime1.Text);

                    cmd.ExecuteNonQuery();
                }
            }
            else
            {

                if (Nazwisko_1.Text.Length > 0)
                {

                    SqlCommand cmd = new SqlCommand("INSERT INTO Obecności (NR_Zajęć, ID_Uczen, Data, Obecny) VALUES (@NR_Zajęć, @ID_Uczen, @Data, @Obecny)");
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = cn;
                    cmd.Parameters.AddWithValue("@NR_Zajęć", lID + 1);
                    cmd.Parameters.AddWithValue("@ID_Uczen", ID1);
                    float.TryParse(metroComboBox1.Text, out y);
                    cmd.Parameters.AddWithValue("@Data", metroDateTime1.Text);
                    cmd.Parameters.AddWithValue("@Obecny", metroCheckBox1.Checked);
                    cmd.ExecuteNonQuery();

                }
                if (Nazwisko_2.Text.Length > 0)
                {

                    SqlCommand cmd = new SqlCommand("INSERT INTO Obecności (NR_Zajęć, ID_Uczen, Data, Obecny) VALUES (@NR_Zajęć, @ID_Uczen, @Data, @Obecny)");
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = cn;
                    cmd.Parameters.AddWithValue("@NR_Zajęć", lID + 1);
                    cmd.Parameters.AddWithValue("@ID_Uczen", ID2);
                    float.TryParse(metroComboBox1.Text, out y);
                    cmd.Parameters.AddWithValue("@Data", metroDateTime1.Text);
                    cmd.Parameters.AddWithValue("@Obecny", metroCheckBox2.Checked);
                    cmd.ExecuteNonQuery();

                }
                if (Nazwisko_3.Text.Length > 0)
                {

                    SqlCommand cmd = new SqlCommand("INSERT INTO Obecności (NR_Zajęć, ID_Uczen, Data, Obecny) VALUES (@NR_Zajęć, @ID_Uczen, @Data, @Obecny)");
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = cn;
                    cmd.Parameters.AddWithValue("@NR_Zajęć", lID + 1);
                    cmd.Parameters.AddWithValue("@ID_Uczen", ID3);
                    float.TryParse(metroComboBox1.Text, out y);
                    cmd.Parameters.AddWithValue("@Data", metroDateTime1.Text);
                    cmd.Parameters.AddWithValue("@Obecny", metroCheckBox3.Checked);
                    cmd.ExecuteNonQuery();

                }
                if (Nazwisko_4.Text.Length > 0)
                {

                    SqlCommand cmd = new SqlCommand("INSERT INTO Obecności (NR_Zajęć, ID_Uczen, Data, Obecny) VALUES (@NR_Zajęć, @ID_Uczen, @Data, @Obecny)");
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = cn;
                    cmd.Parameters.AddWithValue("@NR_Zajęć", lID + 1);
                    cmd.Parameters.AddWithValue("@ID_Uczen", ID4);
                    float.TryParse(metroComboBox1.Text, out y);
                    cmd.Parameters.AddWithValue("@Data", metroDateTime1.Text);
                    cmd.Parameters.AddWithValue("@Obecny", metroCheckBox4.Checked);
                    cmd.ExecuteNonQuery();

                }
                if (Nazwisko_5.Text.Length > 0)
                {

                    SqlCommand cmd = new SqlCommand("INSERT INTO Obecności (NR_Zajęć, ID_Uczen, Data, Obecny) VALUES (@NR_Zajęć, @ID_Uczen, @Data, @Obecny)");
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = cn;
                    cmd.Parameters.AddWithValue("@NR_Zajęć", lID + 1);
                    cmd.Parameters.AddWithValue("@ID_Uczen", ID5);
                    float.TryParse(metroComboBox1.Text, out y);
                    cmd.Parameters.AddWithValue("@Data", metroDateTime1.Text);
                    cmd.Parameters.AddWithValue("@Obecny", metroCheckBox5.Checked);
                    cmd.ExecuteNonQuery();

                }
                if (Nazwisko_6.Text.Length > 0)
                {

                    SqlCommand cmd = new SqlCommand("INSERT INTO Obecności (NR_Zajęć, ID_Uczen, Data, Obecny) VALUES (@NR_Zajęć, @ID_Uczen, @Data, @Obecny)");
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = cn;
                    cmd.Parameters.AddWithValue("@NR_Zajęć", lID + 1);
                    cmd.Parameters.AddWithValue("@ID_Uczen", ID6);
                    float.TryParse(metroComboBox1.Text, out y);
                    cmd.Parameters.AddWithValue("@Data", metroDateTime1.Text);
                    cmd.Parameters.AddWithValue("@Obecny", metroCheckBox6.Checked);
                    cmd.ExecuteNonQuery();

                }
                if (Nazwisko_7.Text.Length > 0)
                {

                    SqlCommand cmd = new SqlCommand("INSERT INTO Obecności (NR_Zajęć, ID_Uczen, Data, Obecny) VALUES (@NR_Zajęć, @ID_Uczen, @Data, @Obecny)");
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = cn;
                    cmd.Parameters.AddWithValue("@NR_Zajęć", lID + 1);
                    cmd.Parameters.AddWithValue("@ID_Uczen", ID7);
                    float.TryParse(metroComboBox1.Text, out y);
                    cmd.Parameters.AddWithValue("@Data", metroDateTime1.Text);
                    cmd.Parameters.AddWithValue("@Obecny", metroCheckBox7.Checked);
                    cmd.ExecuteNonQuery();

                }
                if (Nazwisko_8.Text.Length > 0)
                {

                    SqlCommand cmd = new SqlCommand("INSERT INTO Obecności (NR_Zajęć, ID_Uczen, Data, Obecny) VALUES (@NR_Zajęć, @ID_Uczen, @Data, @Obecny)");
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = cn;
                    cmd.Parameters.AddWithValue("@NR_Zajęć", lID + 1);
                    cmd.Parameters.AddWithValue("@ID_Uczen", ID8);
                    float.TryParse(metroComboBox1.Text, out y);
                    cmd.Parameters.AddWithValue("@Data", metroDateTime1.Text);
                    cmd.Parameters.AddWithValue("@Obecny", metroCheckBox8.Checked);
                    cmd.ExecuteNonQuery();

                }
            }
            cn.Close();
            AddNR();
            frek();
            DodFrek();
            if (edi ==false) { MessageBox.Show("Wstawiono"); }
            else { MessageBox.Show("Zaktualizowano"); }
            
            edi = false;
            metroCheckBox1.Checked = true;
            metroCheckBox2.Checked = true;
            metroCheckBox3.Checked = true;
            metroCheckBox4.Checked = true;
            metroCheckBox5.Checked = true;
            metroCheckBox6.Checked = true;
            metroCheckBox7.Checked = true;
            metroCheckBox8.Checked = true;
            metroCheckBox1.Visible = false;
            metroCheckBox2.Visible = false;
            metroCheckBox3.Visible = false;
            metroCheckBox4.Visible = false;
            metroCheckBox5.Visible = false;
            metroCheckBox6.Visible = false;
            metroCheckBox7.Visible = false;
            metroCheckBox8.Visible = false;
            metroLabel6.Visible = false;
            metroDateTime1.Visible = false;
            metroButton3.Visible = false;
            metroButton4.Visible = false;
            metroComboBox1.Enabled = true;
            metroComboBox2.Enabled = true;
            metroButton1.Enabled = true;
            metroButton3.Text = "Dodaj";
        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroButton2.Enabled = true;
            metroLabel6.Visible = true;
            if (Imie_1.Text.Length>0) { wcz1(); }
            if (Imie_2.Text.Length > 0) { wcz2(); }
            if (Imie_3.Text.Length > 0) { wcz3(); }
            if (Imie_4.Text.Length > 0) { wcz4(); }
            if (Imie_5.Text.Length > 0) { wcz5(); }
            if (Imie_6.Text.Length > 0) { wcz6(); }
            if (Imie_7.Text.Length > 0) { wcz7(); }
            if (Imie_8.Text.Length > 0) { wcz8(); }
            metroCheckBox1.Enabled = false;
            metroCheckBox2.Enabled = false;
            metroCheckBox3.Enabled = false;
            metroCheckBox4.Enabled = false;
            metroCheckBox5.Enabled = false;
            metroCheckBox6.Enabled = false;
            metroCheckBox7.Enabled = false;
            metroCheckBox8.Enabled = false;
            
        }

        private void wcz1()
        {
            cn.Open();
            Datalabel.Text = "";
            Datalabel.Visible = true;
            metroCheckBox1.Visible = true;
            SqlCommand cm = new SqlCommand("Select  Data, Obecny From Obecności Where ID_Uczen = '" + ID1 + "'and NR_Zajęć= '" + metroComboBox2.Text + "' ", cn);

            SqlDataReader dr = cm.ExecuteReader();
            string a = ""; 
            while (dr.Read())
            {

             Datalabel.Text = dr["Data"].ToString();
                a = dr["Obecny"].ToString();

            }
            int b = 0;
            int.TryParse(a, out b);
            if (b==1)
            {
                metroCheckBox1.Checked = true;
            }
            else
            {
                metroCheckBox1.Checked = false;
            }
            cn.Close();
            
        }
        private void wcz2()
        {
            cn.Open();
            Datalabel.Text = "";
            Datalabel.Visible = true;
            metroCheckBox2.Visible = true;
            SqlCommand cm = new SqlCommand("Select  Data, Obecny From Obecności Where ID_Uczen = '" + ID2 + "'and NR_Zajęć= '" + metroComboBox2.Text + "' ", cn);

            SqlDataReader dr = cm.ExecuteReader();
            string a = "";
            while (dr.Read())
            {

                Datalabel.Text = dr["Data"].ToString();
                a = dr["Obecny"].ToString();

            }
            int b = 0;
            int.TryParse(a, out b);
            if (b == 1)
            {
                metroCheckBox2.Checked = true;
            }
            else
            {
                metroCheckBox2.Checked = false;
            }
            cn.Close();

        }
        private void wcz3()
        {
            cn.Open();
            Datalabel.Text = "";
            Datalabel.Visible = true;
            metroCheckBox3.Visible = true;
            SqlCommand cm = new SqlCommand("Select  Data, Obecny From Obecności Where ID_Uczen = '" + ID3 + "'and NR_Zajęć= '" + metroComboBox2.Text + "' ", cn);

            SqlDataReader dr = cm.ExecuteReader();
            string a = "";
            while (dr.Read())
            {

                Datalabel.Text = dr["Data"].ToString();
                a = dr["Obecny"].ToString();

            }
            int b = 0;
            int.TryParse(a, out b);
            if (b == 1)
            {
                metroCheckBox3.Checked = true;
            }
            else
            {
                metroCheckBox3.Checked = false;
            }
            cn.Close();

        }
        private void wcz4()
        {
            cn.Open();
            Datalabel.Text = "";
            Datalabel.Visible = true;
            metroCheckBox4.Visible = true;
            SqlCommand cm = new SqlCommand("Select  Data, Obecny From Obecności Where ID_Uczen = '" + ID4 + "'and NR_Zajęć= '" + metroComboBox2.Text + "' ", cn);

            SqlDataReader dr = cm.ExecuteReader();
            string a = "";
            while (dr.Read())
            {

                Datalabel.Text = dr["Data"].ToString();
                a = dr["Obecny"].ToString();

            }
            int b = 0;
            int.TryParse(a, out b);
            if (b == 1)
            {
                metroCheckBox4.Checked = true;
            }
            else
            {
                metroCheckBox4.Checked = false;
            }
            cn.Close();

        }
        private void wcz5()
        {
            cn.Open();
            Datalabel.Text = "";
            Datalabel.Visible = true;
            metroCheckBox5.Visible = true;
            SqlCommand cm = new SqlCommand("Select  Data, Obecny From Obecności Where ID_Uczen = '" + ID5 + "'and NR_Zajęć= '" + metroComboBox2.Text + "' ", cn);

            SqlDataReader dr = cm.ExecuteReader();
            string a = "";
            while (dr.Read())
            {

                Datalabel.Text = dr["Data"].ToString();
                a = dr["Obecny"].ToString();

            }
            int b = 0;
            int.TryParse(a, out b);
            if (b == 1)
            {
                metroCheckBox5.Checked = true;
            }
            else
            {
                metroCheckBox5.Checked = false;
            }
            cn.Close();

        }
        private void wcz6()
        {
            cn.Open();
            Datalabel.Text = "";
            Datalabel.Visible = true;
            metroCheckBox6.Visible = true;
            SqlCommand cm = new SqlCommand("Select  Data, Obecny From Obecności Where ID_Uczen = '" + ID6 + "'and NR_Zajęć= '" + metroComboBox2.Text + "' ", cn);

            SqlDataReader dr = cm.ExecuteReader();
            string a = "";
            while (dr.Read())
            {

                Datalabel.Text = dr["Data"].ToString();
                a = dr["Obecny"].ToString();

            }
            int b = 0;
            int.TryParse(a, out b);
            if (b == 1)
            {
                metroCheckBox6.Checked = true;
            }
            else
            {
                metroCheckBox6.Checked = false;
            }
            cn.Close();

        }
        private void wcz7()
        {
            cn.Open();
            Datalabel.Text = "";
            Datalabel.Visible = true;
            metroCheckBox7.Visible = true;
            SqlCommand cm = new SqlCommand("Select  Data, Obecny From Obecności Where ID_Uczen = '" + ID7 + "'and NR_Zajęć= '" + metroComboBox2.Text + "' ", cn);

            SqlDataReader dr = cm.ExecuteReader();
            string a = "";
            while (dr.Read())
            {

                Datalabel.Text = dr["Data"].ToString();
                a = dr["Obecny"].ToString();

            }
            int b = 0;
            int.TryParse(a, out b);
            if (b == 1)
            {
                metroCheckBox7.Checked = true;
            }
            else
            {
                metroCheckBox7.Checked = false;
            }
            cn.Close();

        }
        private void wcz8()
        {
            cn.Open();
            Datalabel.Text = "";
            Datalabel.Visible = true;
            metroCheckBox8.Visible = true;
            SqlCommand cm = new SqlCommand("Select  Data, Obecny From Obecności Where ID_Uczen = '" + ID8 + "'and NR_Zajęć= '" + metroComboBox2.Text + "' ", cn);

            SqlDataReader dr = cm.ExecuteReader();
            string a = "";
            while (dr.Read())
            {

                Datalabel.Text = dr["Data"].ToString();
                a = dr["Obecny"].ToString();

            }
            int b = 0;
            int.TryParse(a, out b);
            if (b == 1)
            {
                metroCheckBox8.Checked = true;
            }
            else
            {
                metroCheckBox8.Checked = false;
            }
            cn.Close();

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (Imie_1.Text.Length > 0) { metroCheckBox1.Visible = true; }
            if (Imie_2.Text.Length > 0) { metroCheckBox2.Visible = true; }
            if (Imie_3.Text.Length > 0) { metroCheckBox3.Visible = true; }
            if (Imie_4.Text.Length > 0) { metroCheckBox4.Visible = true; }
            if (Imie_5.Text.Length > 0) { metroCheckBox5.Visible = true; }
            if (Imie_6.Text.Length > 0) { metroCheckBox6.Visible = true; }
            if (Imie_7.Text.Length > 0) { metroCheckBox7.Visible = true; }
            if (Imie_8.Text.Length > 0) { metroCheckBox8.Visible = true; }
            metroLabel6.Visible = true;
            metroDateTime1.Visible = true;
            metroButton3.Visible = true;
            metroButton4.Visible = true;
            metroComboBox1.Enabled = false;
            metroComboBox2.Enabled = false;
            Datalabel.Visible = false;
            metroCheckBox1.Enabled = true;
            metroCheckBox2.Enabled = true;
            metroCheckBox3.Enabled = true;
            metroCheckBox4.Enabled = true;
            metroCheckBox5.Enabled = true;
            metroCheckBox6.Enabled = true;
            metroCheckBox7.Enabled = true;
            metroCheckBox8.Enabled = true;
            metroDateTime1.Text = Datalabel.Text;
            metroButton1.Enabled = false;
            metroButton3.Text = "Aktualizuj";
            edi = true;
        }
        private void frek()
        {
            if (Imie_1.Text.Length > 0)
            {

                cn.Open();
                SqlCommand cmd = new SqlCommand("Select Obecny from Obecności Where ID_Uczen = '" + ID1 + "'", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                string a = "";
                float licz = 0;
                float obec = 0;
                int b = 0;
                while (dr.Read())
                {
                    a = "";
                    a = dr["Obecny"].ToString();
                    b = 0;
                    int.TryParse(a, out b);
                    if (b == 1) { obec++; }
                    licz++;

                }
                float fr = 0;
                if (licz == 0) { licz = 1; }
                fr = obec / licz;
                frek1 = string.Format("{0:0}", fr * 100);

                cn.Close();
            }
            if (Imie_2.Text.Length > 0)
            {

                cn.Open();
                SqlCommand cmd = new SqlCommand("Select Obecny from Obecności Where ID_Uczen = '" + ID2 + "'", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                string a = "";
                float licz = 0;
                float obec = 0;
                int b = 0;
                while (dr.Read())
                {
                    a = "";
                    a = dr["Obecny"].ToString();
                    b = 0;
                    int.TryParse(a, out b);
                    if (b == 1) { obec++; }
                    licz++;

                }
                float fr = 0;
                if (licz == 0) { licz = 1; }
                fr = obec / licz;
                frek2 = string.Format("{0:0}", fr * 100);

                cn.Close();
            }
            if (Imie_3.Text.Length > 0)
            {

                cn.Open();
                SqlCommand cmd = new SqlCommand("Select Obecny from Obecności Where ID_Uczen = '" + ID3 + "'", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                string a = "";
                float licz = 0;
                float obec = 0;
                int b = 0;
                while (dr.Read())
                {
                    a = "";
                    a = dr["Obecny"].ToString();
                    b = 0;
                    int.TryParse(a, out b);
                    if (b == 1) { obec++; }
                    licz++;

                }
                float fr = 0;
                if (licz == 0) { licz = 1; }
                fr = obec / licz;
                frek3 = string.Format("{0:0}", fr * 100);

                cn.Close();
            }
            if (Imie_4.Text.Length > 0)
            {

                cn.Open();
                SqlCommand cmd = new SqlCommand("Select Obecny from Obecności Where ID_Uczen = '" + ID4 + "'", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                string a = "";
                float licz = 0;
                float obec = 0;
                int b = 0;
                while (dr.Read())
                {
                    a = "";
                    a = dr["Obecny"].ToString();
                    b = 0;
                    int.TryParse(a, out b);
                    if (b == 1) { obec++; }
                    licz++;

                }
                float fr = 0;
                if (licz == 0) { licz = 1; }
                fr = obec / licz;
                frek4 = string.Format("{0:0}", fr * 100);

                cn.Close();
            }
            if (Imie_5.Text.Length > 0)
            {

                cn.Open();
                SqlCommand cmd = new SqlCommand("Select Obecny from Obecności Where ID_Uczen = '" + ID5 + "'", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                string a = "";
                float licz = 0;
                float obec = 0;
                int b = 0;
                while (dr.Read())
                {
                    a = "";
                    a = dr["Obecny"].ToString();
                    b = 0;
                    int.TryParse(a, out b);
                    if (b == 1) { obec++; }
                    licz++;

                }
                float fr = 0;
                if (licz == 0) { licz = 1; }
                fr = obec / licz;
                frek5 = string.Format("{0:0}", fr * 100);

                cn.Close();
            }
            if (Imie_6.Text.Length > 0)
            {

                cn.Open();
                SqlCommand cmd = new SqlCommand("Select Obecny from Obecności Where ID_Uczen = '" + ID6 + "'", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                string a = "";
                float licz = 0;
                float obec = 0;
                int b = 0;
                while (dr.Read())
                {
                    a = "";
                    a = dr["Obecny"].ToString();
                    b = 0;
                    int.TryParse(a, out b);
                    if (b == 1) { obec++; }
                    licz++;

                }
                float fr = 0;
                if (licz == 0) { licz = 1; }
                fr = obec / licz;
                frek6 = string.Format("{0:0}", fr * 100);

                cn.Close();
            }
            if (Imie_7.Text.Length > 0)
            {

                cn.Open();
                SqlCommand cmd = new SqlCommand("Select Obecny from Obecności Where ID_Uczen = '" + ID7 + "'", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                string a = "";
                float licz = 0;
                float obec = 0;
                int b = 0;
                while (dr.Read())
                {
                    a = "";
                    a = dr["Obecny"].ToString();
                    b = 0;
                    int.TryParse(a, out b);
                    if (b == 1) { obec++; }
                    licz++;

                }
                float fr = 0;
                if (licz == 0) { licz = 1; }
                fr = obec / licz;
                frek7 = string.Format("{0:0}", fr * 100);

                cn.Close();
            }
            if (Imie_8.Text.Length > 0)
            {

                cn.Open();
                SqlCommand cmd = new SqlCommand("Select Obecny from Obecności Where ID_Uczen = '" + ID8 + "'", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                string a = "";
                float licz = 0;
                float obec = 0;
                int b = 0;
                while (dr.Read())
                {
                    a = "";
                    a = dr["Obecny"].ToString();
                    b = 0;
                    int.TryParse(a, out b);
                    if (b == 1) { obec++; }
                    licz++;

                }
                float fr = 0;
                if (licz == 0) { licz = 1; }
                fr = obec / licz;
                frek8 = string.Format("{0:0}", fr * 100);

                cn.Close();
            }
        }
        private void DodFrek()
        {
            cn.Open();
            if (Imie_1.Text.Length > 0)
            {
                SqlCommand cmd = new SqlCommand("Update Uczniowie SET Frekwencja = @Frekwencja  where Id_Uczen= '" + ID1 + "'", cn);
                cmd.Parameters.AddWithValue("Frekwencja", frek1 + "%");
                

                cmd.ExecuteNonQuery();
            }
            if (Imie_2.Text.Length > 0)
            {
                SqlCommand cmd = new SqlCommand("Update Uczniowie SET Frekwencja = @Frekwencja  where Id_Uczen= '" + ID2 + "'", cn);
                cmd.Parameters.AddWithValue("Frekwencja", frek2 + "%");


                cmd.ExecuteNonQuery();
            }
            if (Imie_3.Text.Length > 0)
            {
                SqlCommand cmd = new SqlCommand("Update Uczniowie SET Frekwencja = @Frekwencja  where Id_Uczen= '" + ID3 + "'", cn);
                cmd.Parameters.AddWithValue("Frekwencja", frek3 + "%");


                cmd.ExecuteNonQuery();
            }
            if (Imie_4.Text.Length > 0)
            {
                SqlCommand cmd = new SqlCommand("Update Uczniowie SET Frekwencja = @Frekwencja  where Id_Uczen= '" + ID4 + "'", cn);
                cmd.Parameters.AddWithValue("Frekwencja", frek4 + "%");


                cmd.ExecuteNonQuery();
            }
            if (Imie_5.Text.Length > 0)
            {
                SqlCommand cmd = new SqlCommand("Update Uczniowie SET Frekwencja = @Frekwencja  where Id_Uczen= '" + ID5 + "'", cn);
                cmd.Parameters.AddWithValue("Frekwencja", frek5 + "%");


                cmd.ExecuteNonQuery();
            }
            if (Imie_6.Text.Length > 0)
            {
                SqlCommand cmd = new SqlCommand("Update Uczniowie SET Frekwencja = @Frekwencja  where Id_Uczen= '" + ID6 + "'", cn);
                cmd.Parameters.AddWithValue("Frekwencja", frek6 + "%");


                cmd.ExecuteNonQuery();
            }
            if (Imie_7.Text.Length > 0)
            {
                SqlCommand cmd = new SqlCommand("Update Uczniowie SET Frekwencja = @Frekwencja  where Id_Uczen= '" + ID7 + "'", cn);
                cmd.Parameters.AddWithValue("Frekwencja", frek7 + "%");


                cmd.ExecuteNonQuery();
            }
            if (Imie_8.Text.Length > 0)
            {
                SqlCommand cmd = new SqlCommand("Update Uczniowie SET Frekwencja = @Frekwencja  where Id_Uczen= '" + ID8 + "'", cn);
                cmd.Parameters.AddWithValue("Frekwencja", frek8 + "%");


                cmd.ExecuteNonQuery();
            }

            cn.Close();
        }
    }
}
