﻿namespace Doctor_assistant.Forms
{
    partial class Patients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patients));
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.search_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HouseNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Steet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.City = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddPatients_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.MyPatients_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.patient_picturebox = new System.Windows.Forms.PictureBox();
            this.docname_label = new System.Windows.Forms.Label();
            this.addpatient_picturebox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.stopfilter = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patient_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addpatient_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(818, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "המטופלים שלי";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1296, 45);
            this.panel2.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.AllowDrop = true;
            this.button1.AutoEllipsis = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1250, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 41);
            this.button1.TabIndex = 45;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.SkyBlue;
            this.searchBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(834, 117);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(137, 27);
            this.searchBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(769, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 33);
            this.label4.TabIndex = 27;
            this.label4.Text = "הזן את שם המטופל";
            // 
            // search_btn
            // 
            this.search_btn.ActiveBorderThickness = 1;
            this.search_btn.ActiveCornerRadius = 20;
            this.search_btn.ActiveFillColor = System.Drawing.Color.SlateGray;
            this.search_btn.ActiveForecolor = System.Drawing.SystemColors.Window;
            this.search_btn.ActiveLineColor = System.Drawing.Color.DarkSlateGray;
            this.search_btn.BackColor = System.Drawing.SystemColors.Control;
            this.search_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search_btn.BackgroundImage")));
            this.search_btn.ButtonText = "חיפוש";
            this.search_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_btn.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.search_btn.IdleBorderThickness = 1;
            this.search_btn.IdleCornerRadius = 20;
            this.search_btn.IdleFillColor = System.Drawing.Color.LightSkyBlue;
            this.search_btn.IdleForecolor = System.Drawing.Color.DarkSlateGray;
            this.search_btn.IdleLineColor = System.Drawing.Color.LightSlateGray;
            this.search_btn.Location = new System.Drawing.Point(576, 102);
            this.search_btn.Margin = new System.Windows.Forms.Padding(6);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(142, 47);
            this.search_btn.TabIndex = 42;
            this.search_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // listView
            // 
            this.listView.BackColor = System.Drawing.Color.LightGray;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.HouseNumber,
            this.Steet,
            this.City,
            this.PhoneNumber,
            this.Age,
            this.Gender,
            this.Id,
            this.LastName,
            this.FirstName});
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(33, 177);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(938, 556);
            this.listView.TabIndex = 9;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged_1);
            this.listView.Click += new System.EventHandler(this.listView_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 0;
            // 
            // HouseNumber
            // 
            this.HouseNumber.Text = "מס דירה";
            this.HouseNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HouseNumber.Width = 70;
            // 
            // Steet
            // 
            this.Steet.Text = "רחוב";
            this.Steet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Steet.Width = 141;
            // 
            // City
            // 
            this.City.Text = "עיר";
            this.City.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.City.Width = 136;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Text = "מספר פלאפון";
            this.PhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PhoneNumber.Width = 134;
            // 
            // Age
            // 
            this.Age.Text = "גיל";
            this.Age.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Age.Width = 53;
            // 
            // Gender
            // 
            this.Gender.Text = "מגדר";
            this.Gender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Gender.Width = 54;
            // 
            // Id
            // 
            this.Id.Text = "תעודת זהות";
            this.Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Id.Width = 118;
            // 
            // LastName
            // 
            this.LastName.Text = "שם משפחה";
            this.LastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LastName.Width = 125;
            // 
            // FirstName
            // 
            this.FirstName.Text = "שם";
            this.FirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FirstName.Width = 102;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.AddPatients_btn);
            this.panel1.Controls.Add(this.MyPatients_btn);
            this.panel1.Controls.Add(this.patient_picturebox);
            this.panel1.Controls.Add(this.docname_label);
            this.panel1.Controls.Add(this.addpatient_picturebox);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(990, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 830);
            this.panel1.TabIndex = 43;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // AddPatients_btn
            // 
            this.AddPatients_btn.ActiveBorderThickness = 1;
            this.AddPatients_btn.ActiveCornerRadius = 20;
            this.AddPatients_btn.ActiveFillColor = System.Drawing.Color.SlateGray;
            this.AddPatients_btn.ActiveForecolor = System.Drawing.Color.Transparent;
            this.AddPatients_btn.ActiveLineColor = System.Drawing.Color.DarkSlateGray;
            this.AddPatients_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.AddPatients_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddPatients_btn.BackgroundImage")));
            this.AddPatients_btn.ButtonText = "הוספת מטופלים";
            this.AddPatients_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddPatients_btn.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPatients_btn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.AddPatients_btn.IdleBorderThickness = 1;
            this.AddPatients_btn.IdleCornerRadius = 20;
            this.AddPatients_btn.IdleFillColor = System.Drawing.Color.LightSkyBlue;
            this.AddPatients_btn.IdleForecolor = System.Drawing.Color.DarkSlateGray;
            this.AddPatients_btn.IdleLineColor = System.Drawing.Color.LightSlateGray;
            this.AddPatients_btn.Location = new System.Drawing.Point(6, 456);
            this.AddPatients_btn.Margin = new System.Windows.Forms.Padding(6);
            this.AddPatients_btn.Name = "AddPatients_btn";
            this.AddPatients_btn.Size = new System.Drawing.Size(189, 44);
            this.AddPatients_btn.TabIndex = 26;
            this.AddPatients_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddPatients_btn.Click += new System.EventHandler(this.AddPatients_btn_Click);
            // 
            // MyPatients_btn
            // 
            this.MyPatients_btn.ActiveBorderThickness = 1;
            this.MyPatients_btn.ActiveCornerRadius = 20;
            this.MyPatients_btn.ActiveFillColor = System.Drawing.Color.SlateGray;
            this.MyPatients_btn.ActiveForecolor = System.Drawing.Color.Transparent;
            this.MyPatients_btn.ActiveLineColor = System.Drawing.Color.DarkSlateGray;
            this.MyPatients_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.MyPatients_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MyPatients_btn.BackgroundImage")));
            this.MyPatients_btn.ButtonText = "המטופלים שלי";
            this.MyPatients_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MyPatients_btn.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyPatients_btn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.MyPatients_btn.IdleBorderThickness = 1;
            this.MyPatients_btn.IdleCornerRadius = 20;
            this.MyPatients_btn.IdleFillColor = System.Drawing.Color.LightSkyBlue;
            this.MyPatients_btn.IdleForecolor = System.Drawing.Color.DarkSlateGray;
            this.MyPatients_btn.IdleLineColor = System.Drawing.Color.LightSlateGray;
            this.MyPatients_btn.Location = new System.Drawing.Point(26, 360);
            this.MyPatients_btn.Margin = new System.Windows.Forms.Padding(6);
            this.MyPatients_btn.Name = "MyPatients_btn";
            this.MyPatients_btn.Size = new System.Drawing.Size(163, 44);
            this.MyPatients_btn.TabIndex = 25;
            this.MyPatients_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MyPatients_btn.Click += new System.EventHandler(this.MyPatients_btn_Click);
            // 
            // patient_picturebox
            // 
            this.patient_picturebox.Image = ((System.Drawing.Image)(resources.GetObject("patient_picturebox.Image")));
            this.patient_picturebox.Location = new System.Drawing.Point(203, 360);
            this.patient_picturebox.Name = "patient_picturebox";
            this.patient_picturebox.Size = new System.Drawing.Size(100, 50);
            this.patient_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.patient_picturebox.TabIndex = 10;
            this.patient_picturebox.TabStop = false;
            // 
            // docname_label
            // 
            this.docname_label.AutoSize = true;
            this.docname_label.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docname_label.Location = new System.Drawing.Point(60, 216);
            this.docname_label.Name = "docname_label";
            this.docname_label.Size = new System.Drawing.Size(199, 33);
            this.docname_label.TabIndex = 9;
            this.docname_label.Text = "שלום דוקטור אנטון";
            // 
            // addpatient_picturebox
            // 
            this.addpatient_picturebox.Image = ((System.Drawing.Image)(resources.GetObject("addpatient_picturebox.Image")));
            this.addpatient_picturebox.Location = new System.Drawing.Point(203, 456);
            this.addpatient_picturebox.Name = "addpatient_picturebox";
            this.addpatient_picturebox.Size = new System.Drawing.Size(100, 50);
            this.addpatient_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addpatient_picturebox.TabIndex = 6;
            this.addpatient_picturebox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(53, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // stopfilter
            // 
            this.stopfilter.ActiveBorderThickness = 1;
            this.stopfilter.ActiveCornerRadius = 20;
            this.stopfilter.ActiveFillColor = System.Drawing.Color.SlateGray;
            this.stopfilter.ActiveForecolor = System.Drawing.SystemColors.Window;
            this.stopfilter.ActiveLineColor = System.Drawing.Color.DarkSlateGray;
            this.stopfilter.BackColor = System.Drawing.SystemColors.Control;
            this.stopfilter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stopfilter.BackgroundImage")));
            this.stopfilter.ButtonText = "בטל חיפוש";
            this.stopfilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stopfilter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopfilter.ForeColor = System.Drawing.Color.DodgerBlue;
            this.stopfilter.IdleBorderThickness = 1;
            this.stopfilter.IdleCornerRadius = 20;
            this.stopfilter.IdleFillColor = System.Drawing.Color.LightSkyBlue;
            this.stopfilter.IdleForecolor = System.Drawing.Color.DarkSlateGray;
            this.stopfilter.IdleLineColor = System.Drawing.Color.LightSlateGray;
            this.stopfilter.Location = new System.Drawing.Point(730, 114);
            this.stopfilter.Margin = new System.Windows.Forms.Padding(4);
            this.stopfilter.Name = "stopfilter";
            this.stopfilter.Size = new System.Drawing.Size(97, 30);
            this.stopfilter.TabIndex = 44;
            this.stopfilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.stopfilter.Click += new System.EventHandler(this.stopfilter_Click);
            // 
            // Patients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 875);
            this.Controls.Add(this.stopfilter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Patients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patients";
            this.Load += new System.EventHandler(this.Patients_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patient_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addpatient_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuThinButton2 search_btn;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader HouseNumber;
        private System.Windows.Forms.ColumnHeader Steet;
        private System.Windows.Forms.ColumnHeader City;
        private System.Windows.Forms.ColumnHeader PhoneNumber;
        private System.Windows.Forms.ColumnHeader Age;
        private System.Windows.Forms.ColumnHeader Gender;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 AddPatients_btn;
        private Bunifu.Framework.UI.BunifuThinButton2 MyPatients_btn;
        private System.Windows.Forms.PictureBox patient_picturebox;
        private System.Windows.Forms.Label docname_label;
        private System.Windows.Forms.PictureBox addpatient_picturebox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        public System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuThinButton2 stopfilter;
    }
}