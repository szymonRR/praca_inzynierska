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
using MetroFramework.Forms;

namespace INZ1
{
    public partial class Form1 : MetroForm
    {
        bool czyZamknac = true;
        public string ID_Nau { get; set; }
        public string log { get; set; }
        public string Rok { get; set; }
        public bool upr { get; set; }
        SqlConnection cn = new SqlConnection("Data Source=(local);Initial Catalog=INZ;Integrated Security=True");
        
        private Logowanie logowanie;
        public Form1(Logowanie logowanie)
        {
            InitializeComponent();
            upr = true;
            this.logowanie = logowanie;
            Log.Text = logowanie.LoginDoForm1;
            log = logowanie.LoginDoForm1;
            Rok = "2015/2016";
            uprawnienia();
            cn.Open();
            SqlCommand am = new SqlCommand("Select ID_Nau from Nauczyciele Where Login= '" + Log.Text  + "'",cn );
            SqlDataReader drr = am.ExecuteReader();
            while (drr.Read())
            {
                ID_Nau = drr["ID_Nau"].ToString();
            }

            cn.Close();
            
            metroLabel1.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();

            FillData();
            
            
           


        }
        void FillData()
        {


            
            
                cn.Open();

                
                using (SqlDataAdapter a = new SqlDataAdapter("SELECT Plany FROM Calendar where Data = '" +metroLabel1.Text+"' and Login ='"+ log +"' ", cn))
                {
                    var t = new DataTable();
                    a.Fill(t);

                    dataGridView1.DataSource = t;
                    cn.Close();
                }
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (czyZamknac == true)
            {
                Application.Exit();
            }
        }

        

      

        private void Form1_Load(object sender, EventArgs e)
        {
           
            

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Zmień_hasło F3 = new Zmień_hasło(this);
            F3.Show();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            metroLabel1.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
            using (SqlConnection cn = new SqlConnection("Data Source=(local);Initial Catalog=INZ;Integrated Security=True"))
            {
                cn.Open();

                
                using (SqlDataAdapter a = new SqlDataAdapter("SELECT Plany FROM Calendar where Data = '" + metroLabel1.Text + "' and Login ='" + log + "' ", cn))
                {
                    
                    var t = new DataTable();
                    a.Fill(t);

                    dataGridView1.DataSource = t;
                }
                cn.Close();
            }
                }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            Kalandarz F4 = new Kalandarz(this);
            F4.Show();
        }

        private void WylogujButton_Click(object sender, EventArgs e)
        {
            Logowanie l = new Logowanie();
            l.Show();
            czyZamknac = false;
            this.Close();
        }

        private void metroButton3_Click_1(object sender, EventArgs e)
        {
            Grupy gr = new Grupy(this);
            gr.Show();
        }

        private void metroButton4_Click_1(object sender, EventArgs e)
        {
            Nauczyciele Nu = new Nauczyciele();
            Nu.Show();
        }

        private void metroButton5_Click_1(object sender, EventArgs e)
        {
            Uczniowie Ucz = new Uczniowie(this);
            Ucz.Show();
        }

        private void metroButton6_Click_1(object sender, EventArgs e)
        {
            Plan plan = new Plan(this);
            plan.Show();
        }
        private void uprawnienia()
        {
            if (Log.Text != ("admin"))
            {
                if (Log.Text != ("admin2"))
                {
                    metroButton4.Enabled = false;
                    metroButton5.Enabled = false;
                    upr = false;
                }


            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Kalandarz F4 = new Kalandarz(this);
            F4.Show();
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            Zmień_hasło F3 = new Zmień_hasło(this);
            F3.Show();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            Nauczyciele Nu = new Nauczyciele();
            Nu.Show();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Grupy gr = new Grupy(this);
            gr.Show();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            Uczniowie Ucz = new Uczniowie(this);
            Ucz.Show();
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            Plan plan = new Plan(this);
            plan.Show();
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            Oceny oc = new Oceny(this);
            oc.Show();
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            Obecnosci ob = new Obecnosci(this);
            ob.Show();
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            Dyplom dy = new Dyplom(this);
            dy.Show();
        }
    }

    }

