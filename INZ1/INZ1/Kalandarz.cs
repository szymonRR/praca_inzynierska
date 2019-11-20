using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace INZ1
{
    public partial class Kalandarz : MetroForm
    {
        private Form1 form1;
        
        public Kalandarz(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            metroTextBox1.Text = metroDateTime1.Value.ToShortDateString();
            metroTextBox3.Text = form1.log;
        }

        private void Kalandarz_Load(object sender, EventArgs e)
        {

        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {
            metroTextBox1.Text = metroDateTime1.Value.ToShortDateString(); //Zmiana daty w TextBox
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (metroTextBox2.Text.Length > 0)
            {
                using (SqlConnection cn = new SqlConnection("Data Source=(local);Initial Catalog=INZ;Integrated Security=True"))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Calendar (Data, Plany, Login) VALUES (@Data, @Plany, @Login)");
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = cn;
                    cmd.Parameters.AddWithValue("@Data", metroTextBox1.Text);
                    cmd.Parameters.AddWithValue("@Plany", metroTextBox2.Text);
                    cmd.Parameters.AddWithValue("@Login", metroTextBox3.Text);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    
                                       
                    MessageBox.Show("Dodano");
                };
                }
                else{
                    MessageBox.Show("Pole plany jest puste");
                }

            }
        }
    }

