namespace INZ1
{
    partial class Grupy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RokComboBox = new MetroFramework.Controls.MetroComboBox();
            this.JezykComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.GrupaComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.DodajJezykCombo = new MetroFramework.Controls.MetroComboBox();
            this.DodajNauCombo = new MetroFramework.Controls.MetroComboBox();
            this.DodajRokCombo = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.dodajButt = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RokComboBox
            // 
            this.RokComboBox.FormattingEnabled = true;
            this.RokComboBox.ItemHeight = 23;
            this.RokComboBox.Items.AddRange(new object[] {
            "2015/2016"});
            this.RokComboBox.Location = new System.Drawing.Point(23, 107);
            this.RokComboBox.Name = "RokComboBox";
            this.RokComboBox.Size = new System.Drawing.Size(121, 29);
            this.RokComboBox.TabIndex = 0;
            this.RokComboBox.UseSelectable = true;
            this.RokComboBox.SelectedIndexChanged += new System.EventHandler(this.RokComboBox_SelectedIndexChanged);
            // 
            // JezykComboBox
            // 
            this.JezykComboBox.FormattingEnabled = true;
            this.JezykComboBox.ItemHeight = 23;
            this.JezykComboBox.Items.AddRange(new object[] {
            "Angielski",
            "Francuski"});
            this.JezykComboBox.Location = new System.Drawing.Point(170, 107);
            this.JezykComboBox.Name = "JezykComboBox";
            this.JezykComboBox.Size = new System.Drawing.Size(121, 29);
            this.JezykComboBox.TabIndex = 1;
            this.JezykComboBox.UseSelectable = true;
            this.JezykComboBox.SelectedIndexChanged += new System.EventHandler(this.JezykComboBox_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 85);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(78, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Rok Szkolny";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(170, 85);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(39, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Język";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(485, 162);
            this.dataGridView1.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(490, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItem1.Text = "Opcje";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 150);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(45, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Grupa";
            // 
            // GrupaComboBox
            // 
            this.GrupaComboBox.FormattingEnabled = true;
            this.GrupaComboBox.ItemHeight = 23;
            this.GrupaComboBox.Location = new System.Drawing.Point(23, 172);
            this.GrupaComboBox.Name = "GrupaComboBox";
            this.GrupaComboBox.Size = new System.Drawing.Size(121, 29);
            this.GrupaComboBox.TabIndex = 7;
            this.GrupaComboBox.UseSelectable = true;
            this.GrupaComboBox.SelectedIndexChanged += new System.EventHandler(this.GrupaComboBox_SelectedIndexChanged);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.dodajButt);
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.DodajRokCombo);
            this.metroPanel1.Controls.Add(this.DodajNauCombo);
            this.metroPanel1.Controls.Add(this.DodajJezykCombo);
            this.metroPanel1.Controls.Add(this.metroTextBox1);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(297, 26);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(200, 199);
            this.metroPanel1.TabIndex = 8;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(4, 4);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(83, 19);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Dodaj grupę";
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(74, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(104, 30);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.Size = new System.Drawing.Size(96, 23);
            this.metroTextBox1.TabIndex = 3;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // DodajJezykCombo
            // 
            this.DodajJezykCombo.FormattingEnabled = true;
            this.DodajJezykCombo.ItemHeight = 23;
            this.DodajJezykCombo.Items.AddRange(new object[] {
            "Angielski",
            "Francuski"});
            this.DodajJezykCombo.Location = new System.Drawing.Point(104, 69);
            this.DodajJezykCombo.Name = "DodajJezykCombo";
            this.DodajJezykCombo.Size = new System.Drawing.Size(96, 29);
            this.DodajJezykCombo.TabIndex = 4;
            this.DodajJezykCombo.UseSelectable = true;
            this.DodajJezykCombo.SelectedIndexChanged += new System.EventHandler(this.DodajJezykCombo_SelectedIndexChanged);
            // 
            // DodajNauCombo
            // 
            this.DodajNauCombo.FormattingEnabled = true;
            this.DodajNauCombo.ItemHeight = 23;
            this.DodajNauCombo.Location = new System.Drawing.Point(104, 104);
            this.DodajNauCombo.Name = "DodajNauCombo";
            this.DodajNauCombo.Size = new System.Drawing.Size(96, 29);
            this.DodajNauCombo.TabIndex = 5;
            this.DodajNauCombo.UseSelectable = true;
            // 
            // DodajRokCombo
            // 
            this.DodajRokCombo.FormattingEnabled = true;
            this.DodajRokCombo.ItemHeight = 23;
            this.DodajRokCombo.Items.AddRange(new object[] {
            "2015/2016"});
            this.DodajRokCombo.Location = new System.Drawing.Point(104, 139);
            this.DodajRokCombo.Name = "DodajRokCombo";
            this.DodajRokCombo.Size = new System.Drawing.Size(96, 29);
            this.DodajRokCombo.TabIndex = 6;
            this.DodajRokCombo.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(4, 33);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(48, 19);
            this.metroLabel5.TabIndex = 7;
            this.metroLabel5.Text = "Nazwa";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(4, 79);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(39, 19);
            this.metroLabel6.TabIndex = 8;
            this.metroLabel6.Text = "Język";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(4, 114);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(70, 19);
            this.metroLabel7.TabIndex = 9;
            this.metroLabel7.Text = "Nauczyciel";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(4, 149);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(78, 19);
            this.metroLabel8.TabIndex = 10;
            this.metroLabel8.Text = "Rok Szkolny";
            // 
            // dodajButt
            // 
            this.dodajButt.Location = new System.Drawing.Point(104, 175);
            this.dodajButt.Name = "dodajButt";
            this.dodajButt.Size = new System.Drawing.Size(75, 23);
            this.dodajButt.TabIndex = 11;
            this.dodajButt.Text = "Dodaj";
            this.dodajButt.UseSelectable = true;
            this.dodajButt.Click += new System.EventHandler(this.dodajButt_Click);
            // 
            // Grupy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 404);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.GrupaComboBox);
            this.Controls.Add(this.JezykComboBox);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.RokComboBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Grupy";
            this.Text = "Grupy";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox RokComboBox;
        private MetroFramework.Controls.MetroComboBox JezykComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox GrupaComboBox;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton dodajButt;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox DodajRokCombo;
        private MetroFramework.Controls.MetroComboBox DodajNauCombo;
        private MetroFramework.Controls.MetroComboBox DodajJezykCombo;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}