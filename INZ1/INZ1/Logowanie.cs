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
    public partial class Logowanie : MetroForm
    {
        bool czyZam = true;
        public Logowanie()
        {
            InitializeComponent();
        }

        public string LoginDoForm1 { get; set; }
       

        private void Logowanie_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (czyZam == true)
            {
                Application.Exit();
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=(local);Initial Catalog=INZ;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from users where Login = '" + textBox1.Text + "'  and Haslo = '" + textBox2.Text + "'", cn);

            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            int count = 0;
            while (dr.Read())
            {
                count += 1;
            }

            if (count == 1)
            {
                MessageBox.Show("Zalogowano pomyślnie");
                czyZam = false;
                LoginDoForm1 = textBox1.Text;
                Form1 F1 = new Form1(this);
                F1.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Zły login lub hasło");
            }
        }

        private void Logowanie_Load(object sender, EventArgs e)
        {
            AcceptButton = metroButton1;
        }
    }
}
