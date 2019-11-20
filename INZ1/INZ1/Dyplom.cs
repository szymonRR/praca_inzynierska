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
    public partial class Dyplom : MetroForm
    {
        SqlConnection cn = new SqlConnection("Data Source=(local);Initial Catalog=INZ;Integrated Security=True");
        private Form1 form1;
        string jez = "";
        string oc = "";
        public Dyplom(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            ADDGRU();
        }
        private void ADDGRU()
        {
            cn.Open();
            SqlCommand cm = new SqlCommand("Select Nazwa,Język From Grupy Where ID_Nau = '" + form1.ID_Nau + "'", cn);


            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                Grupa_combo.Items.Add(dr["Nazwa"]);
                jez = dr["Język"].ToString();
            }
            if(jez == "Angielski") { jez = "angielskiego"; }
            else { jez = "francuskiego"; }
            cn.Close();

        }

        private void Grupa_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cn.Open();
            metroComboBox2.Items.Clear();
            SqlCommand cm = new SqlCommand("Select Nazwisko From Uczniowie Where Grupa = '" + Grupa_combo.Text + "'", cn);


            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                metroComboBox2.Items.Add(dr["Nazwisko"]);
            }

            cn.Close();
        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cm = new SqlCommand("Select Imię,Frekwencja,Średnia From Uczniowie Where Nazwisko = '" + metroComboBox2.Text + "' and Grupa = '"+ Grupa_combo.Text+"'", cn);


            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                metroLabel4.Text = dr["Imię"].ToString();
                metroLabel7.Text = dr["Frekwencja"].ToString();
                metroLabel5.Text = dr["Średnia"].ToString();
            }

            cn.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = Properties.Resources.dyplom;
            Image newImage =bmp;
            e.Graphics.DrawImage(newImage, 0, 0);
            e.Graphics.DrawString(metroComboBox2.Text + " "+ metroLabel4.Text+",", new Font("Arial", 42, FontStyle.Bold), Brushes.Black, 130, 452);
            e.Graphics.DrawString(jez+".", new Font("Arial", 42, FontStyle.Italic), Brushes.Black, 308, 598);
            e.Graphics.DrawString(" "+ oc, new Font("Arial", 42, FontStyle.Italic), Brushes.Black, 360, 709);

        }

        private void metroComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroComboBox3.SelectedIndex == 0) { oc = "dopuszczającą"; }
            if (metroComboBox3.SelectedIndex == 1) { oc = "dostateczną"; }
            if (metroComboBox3.SelectedIndex == 2) { oc = "dobrą"; }
            if (metroComboBox3.SelectedIndex == 3) { oc = "bardzo dobrą"; }
            if (metroComboBox3.SelectedIndex == 4) { oc = "celującą"; }
        }
    }
}
