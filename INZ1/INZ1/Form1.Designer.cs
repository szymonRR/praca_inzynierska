namespace INZ1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNZDataSet = new INZ1.INZDataSet();
            this.usersTableAdapter = new INZ1.INZDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new INZ1.INZDataSetTableAdapters.TableAdapterManager();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.iNZDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.metroButton9 = new MetroFramework.Controls.MetroButton();
            this.metroButton8 = new MetroFramework.Controls.MetroButton();
            this.metroButton7 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.WylogujButton = new MetroFramework.Controls.MetroButton();
            this.calendarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNZDataSet1 = new INZ1.INZDataSet1();
            this.usersBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter1 = new INZ1.INZDataSet1TableAdapters.UsersTableAdapter();
            this.tableAdapterManager1 = new INZ1.INZDataSet1TableAdapters.TableAdapterManager();
            this.calendarTableAdapter = new INZ1.INZDataSet1TableAdapters.CalendarTableAdapter();
            this.iNZDataSet2 = new INZ1.INZDataSet2();
            this.nauczycieleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nauczycieleTableAdapter = new INZ1.INZDataSet2TableAdapters.NauczycieleTableAdapter();
            this.tableAdapterManager2 = new INZ1.INZDataSet2TableAdapters.TableAdapterManager();
            this.Log = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNZDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNZDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calendarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNZDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNZDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nauczycieleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.iNZDataSet;
            // 
            // iNZDataSet
            // 
            this.iNZDataSet.DataSetName = "INZDataSet";
            this.iNZDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CalendarTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = INZ1.INZDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "Users";
            this.usersBindingSource1.DataSource = this.iNZDataSet;
            // 
            // usersBindingSource2
            // 
            this.usersBindingSource2.DataMember = "Users";
            this.usersBindingSource2.DataSource = this.iNZDataSet;
            // 
            // iNZDataSetBindingSource
            // 
            this.iNZDataSetBindingSource.DataSource = this.iNZDataSet;
            this.iNZDataSetBindingSource.Position = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(23, 53);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel1);
            this.splitContainer1.Panel1.Controls.Add(this.monthCalendar1);
            this.splitContainer1.Panel1.Controls.Add(this.metroButton2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.metroTabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(597, 380);
            this.splitContainer1.SplitterDistance = 272;
            this.splitContainer1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(266, 196);
            this.dataGridView1.TabIndex = 3;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(0, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(81, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "metroLabel1";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(0, 218);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // metroButton2
            // 
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton2.Location = new System.Drawing.Point(87, 0);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(182, 16);
            this.metroButton2.TabIndex = 10;
            this.metroButton2.Text = "Dodaj do\r\nkalendarza";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabPage1);
            this.metroTabControl1.Controls.Add(this.tabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(3, 3);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(317, 377);
            this.metroTabControl1.TabIndex = 3;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage1.Controls.Add(this.metroButton6);
            this.tabPage1.Controls.Add(this.metroButton5);
            this.tabPage1.Controls.Add(this.metroButton4);
            this.tabPage1.Controls.Add(this.metroButton3);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(309, 335);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Organizacja";
            // 
            // metroButton6
            // 
            this.metroButton6.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton6.Location = new System.Drawing.Point(180, 20);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(113, 85);
            this.metroButton6.TabIndex = 14;
            this.metroButton6.Text = "Plan zajęć";
            this.metroButton6.UseSelectable = true;
            this.metroButton6.Click += new System.EventHandler(this.metroButton6_Click);
            // 
            // metroButton5
            // 
            this.metroButton5.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton5.Location = new System.Drawing.Point(20, 20);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(113, 85);
            this.metroButton5.TabIndex = 13;
            this.metroButton5.Text = "Uczniowie";
            this.metroButton5.UseSelectable = true;
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton4.Location = new System.Drawing.Point(20, 125);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(113, 85);
            this.metroButton4.TabIndex = 12;
            this.metroButton4.Text = "Nauczyciele";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton3.Location = new System.Drawing.Point(180, 125);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(113, 85);
            this.metroButton3.TabIndex = 11;
            this.metroButton3.Text = "Grupy";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage2.Controls.Add(this.metroButton9);
            this.tabPage2.Controls.Add(this.metroButton8);
            this.tabPage2.Controls.Add(this.metroButton7);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(309, 335);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nauczanie";
            // 
            // metroButton9
            // 
            this.metroButton9.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton9.Location = new System.Drawing.Point(20, 125);
            this.metroButton9.Name = "metroButton9";
            this.metroButton9.Size = new System.Drawing.Size(113, 85);
            this.metroButton9.TabIndex = 13;
            this.metroButton9.Text = "Dyplomy";
            this.metroButton9.UseSelectable = true;
            this.metroButton9.Click += new System.EventHandler(this.metroButton9_Click);
            // 
            // metroButton8
            // 
            this.metroButton8.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton8.Location = new System.Drawing.Point(180, 20);
            this.metroButton8.Name = "metroButton8";
            this.metroButton8.Size = new System.Drawing.Size(113, 85);
            this.metroButton8.TabIndex = 12;
            this.metroButton8.Text = "Obecności";
            this.metroButton8.UseSelectable = true;
            this.metroButton8.Click += new System.EventHandler(this.metroButton8_Click);
            // 
            // metroButton7
            // 
            this.metroButton7.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton7.Location = new System.Drawing.Point(20, 20);
            this.metroButton7.Name = "metroButton7";
            this.metroButton7.Size = new System.Drawing.Size(113, 85);
            this.metroButton7.TabIndex = 11;
            this.metroButton7.Text = "Oceny";
            this.metroButton7.UseSelectable = true;
            this.metroButton7.Click += new System.EventHandler(this.metroButton7_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.Location = new System.Drawing.Point(419, 19);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(87, 31);
            this.metroButton1.TabIndex = 9;
            this.metroButton1.Text = "Profil";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // WylogujButton
            // 
            this.WylogujButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.WylogujButton.Location = new System.Drawing.Point(512, 19);
            this.WylogujButton.Name = "WylogujButton";
            this.WylogujButton.Size = new System.Drawing.Size(87, 31);
            this.WylogujButton.TabIndex = 3;
            this.WylogujButton.Text = "Wyloguj";
            this.WylogujButton.UseSelectable = true;
            this.WylogujButton.Click += new System.EventHandler(this.WylogujButton_Click);
            // 
            // calendarBindingSource
            // 
            this.calendarBindingSource.DataMember = "Calendar";
            this.calendarBindingSource.DataSource = this.iNZDataSet1;
            // 
            // iNZDataSet1
            // 
            this.iNZDataSet1.DataSetName = "INZDataSet1";
            this.iNZDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource3
            // 
            this.usersBindingSource3.DataMember = "Users";
            this.usersBindingSource3.DataSource = this.iNZDataSet;
            // 
            // usersBindingSource4
            // 
            this.usersBindingSource4.DataMember = "Users";
            this.usersBindingSource4.DataSource = this.iNZDataSet;
            // 
            // usersBindingSource5
            // 
            this.usersBindingSource5.DataMember = "Users";
            this.usersBindingSource5.DataSource = this.iNZDataSet1;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CalendarTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = INZ1.INZDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.UsersTableAdapter = this.usersTableAdapter1;
            // 
            // calendarTableAdapter
            // 
            this.calendarTableAdapter.ClearBeforeFill = true;
            // 
            // iNZDataSet2
            // 
            this.iNZDataSet2.DataSetName = "INZDataSet2";
            this.iNZDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nauczycieleBindingSource
            // 
            this.nauczycieleBindingSource.DataMember = "Nauczyciele";
            this.nauczycieleBindingSource.DataSource = this.iNZDataSet2;
            // 
            // nauczycieleTableAdapter
            // 
            this.nauczycieleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.CalendarTableAdapter = null;
            this.tableAdapterManager2.GrupyTableAdapter = null;
            this.tableAdapterManager2.NauczycieleTableAdapter = this.nauczycieleTableAdapter;
            this.tableAdapterManager2.UczniowieTableAdapter = null;
            this.tableAdapterManager2.UpdateOrder = INZ1.INZDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager2.UsersTableAdapter = null;
            // 
            // Log
            // 
            this.Log.AutoSize = true;
            this.Log.Location = new System.Drawing.Point(326, 31);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(41, 19);
            this.Log.TabIndex = 4;
            this.Log.Text = "Login";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 468);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.WylogujButton);
            this.Controls.Add(this.metroButton1);
            this.Name = "Form1";
            this.Text = "Szkoła";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNZDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNZDataSetBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.calendarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNZDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNZDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nauczycieleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private INZDataSet iNZDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private INZDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private INZDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private System.Windows.Forms.BindingSource usersBindingSource2;
        private System.Windows.Forms.BindingSource iNZDataSetBindingSource;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.BindingSource usersBindingSource3;
        private System.Windows.Forms.BindingSource usersBindingSource4;
        private INZDataSet1 iNZDataSet1;
        private System.Windows.Forms.BindingSource usersBindingSource5;
        private INZDataSet1TableAdapters.UsersTableAdapter usersTableAdapter1;
        private INZDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource calendarBindingSource;
        private INZDataSet1TableAdapters.CalendarTableAdapter calendarTableAdapter;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton WylogujButton;
        private INZDataSet2 iNZDataSet2;
        private System.Windows.Forms.BindingSource nauczycieleBindingSource;
        private INZDataSet2TableAdapters.NauczycieleTableAdapter nauczycieleTableAdapter;
        private INZDataSet2TableAdapters.TableAdapterManager tableAdapterManager2;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private MetroFramework.Controls.MetroButton metroButton6;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.TabPage tabPage2;
        private MetroFramework.Controls.MetroLabel Log;
        private MetroFramework.Controls.MetroButton metroButton7;
        private MetroFramework.Controls.MetroButton metroButton8;
        private MetroFramework.Controls.MetroButton metroButton9;
    }
}

