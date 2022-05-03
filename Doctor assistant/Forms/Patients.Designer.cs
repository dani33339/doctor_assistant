namespace Doctor_assistant.Forms
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
            this.exit = new System.Windows.Forms.Button();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.search_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.listView = new System.Windows.Forms.ListView();
            this.HouseNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Steet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.City = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddPatients_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.MyPatients_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.patient_picturebox = new System.Windows.Forms.PictureBox();
            this.docname_label = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.addpatient_picturebox = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Star_Appointment = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patient_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
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
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(991, 45);
            this.panel2.TabIndex = 26;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.exit_Paint);
            // 
            // exit
            // 
            this.exit.AllowDrop = true;
            this.exit.AutoEllipsis = true;
            this.exit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exit.BackColor = System.Drawing.Color.DodgerBlue;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(263, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(43, 41);
            this.exit.TabIndex = 25;
            this.exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.exit.UseCompatibleTextRendering = true;
            this.exit.UseVisualStyleBackColor = false;
            
            // 
            // name_textbox
            // 
            this.name_textbox.BackColor = System.Drawing.Color.SkyBlue;
            this.name_textbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_textbox.Location = new System.Drawing.Point(834, 117);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(137, 27);
            this.name_textbox.TabIndex = 6;
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
            this.search_btn.Location = new System.Drawing.Point(605, 102);
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
            this.HouseNumber,
            this.Steet,
            this.City,
            this.PhoneNumber,
            this.Age,
            this.Gender,
            this.Id,
            this.FirstName,
            this.LastName});
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
            // 
            // HouseNumber
            // 
            this.HouseNumber.Text = "מס דירה";
            this.HouseNumber.Width = 113;
            // 
            // Steet
            // 
            this.Steet.Text = "רחוב";
            this.Steet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Steet.Width = 117;
            // 
            // City
            // 
            this.City.Text = "עיר";
            this.City.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.City.Width = 114;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Text = "מספר פלאפון";
            this.PhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PhoneNumber.Width = 135;
            // 
            // Age
            // 
            this.Age.Text = "גיל";
            this.Age.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Age.Width = 72;
            // 
            // Gender
            // 
            this.Gender.Text = "מגדר";
            this.Gender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Gender.Width = 83;
            // 
            // Id
            // 
            this.Id.Text = "תעודת זהות";
            this.Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Id.Width = 116;
            // 
            // FirstName
            // 
            this.FirstName.Text = "שם";
            this.FirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FirstName.Width = 72;
            // 
            // LastName
            // 
            this.LastName.Text = "שם משפחה";
            this.LastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LastName.Width = 114;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.AddPatients_btn);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.MyPatients_btn);
            this.panel1.Controls.Add(this.patient_picturebox);
            this.panel1.Controls.Add(this.docname_label);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.addpatient_picturebox);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(990, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 875);
            this.panel1.TabIndex = 43;
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
            this.docname_label.Location = new System.Drawing.Point(60, 272);
            this.docname_label.Name = "docname_label";
            this.docname_label.Size = new System.Drawing.Size(199, 33);
            this.docname_label.TabIndex = 9;
            this.docname_label.Text = "שלום דוקטור אנטון";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(183, 671);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 50);
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(183, 552);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 50);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
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
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 646);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(179, 33);
            this.label14.TabIndex = 4;
            this.label14.Text = "הוספת מטופלים";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(5, 552);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(179, 33);
            this.label13.TabIndex = 3;
            this.label13.Text = "הוספת מטופלים";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(51, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Star_Appointment
            // 
            this.Star_Appointment.ActiveBorderThickness = 1;
            this.Star_Appointment.ActiveCornerRadius = 20;
            this.Star_Appointment.ActiveFillColor = System.Drawing.Color.SlateGray;
            this.Star_Appointment.ActiveForecolor = System.Drawing.SystemColors.Window;
            this.Star_Appointment.ActiveLineColor = System.Drawing.Color.DarkSlateGray;
            this.Star_Appointment.BackColor = System.Drawing.SystemColors.Control;
            this.Star_Appointment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Star_Appointment.BackgroundImage")));
            this.Star_Appointment.ButtonText = "התחל ביקור";
            this.Star_Appointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Star_Appointment.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Star_Appointment.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Star_Appointment.IdleBorderThickness = 1;
            this.Star_Appointment.IdleCornerRadius = 20;
            this.Star_Appointment.IdleFillColor = System.Drawing.Color.LightSkyBlue;
            this.Star_Appointment.IdleForecolor = System.Drawing.Color.DarkSlateGray;
            this.Star_Appointment.IdleLineColor = System.Drawing.Color.LightSlateGray;
            this.Star_Appointment.Location = new System.Drawing.Point(439, 102);
            this.Star_Appointment.Margin = new System.Windows.Forms.Padding(6);
            this.Star_Appointment.Name = "Star_Appointment";
            this.Star_Appointment.Size = new System.Drawing.Size(142, 47);
            this.Star_Appointment.TabIndex = 44;
            this.Star_Appointment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Star_Appointment.Click += new System.EventHandler(this.Star_Appointment_Click);
            // 
            // Patients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 875);
            this.Controls.Add(this.Star_Appointment);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Patients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patients";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patient_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addpatient_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox name_textbox;
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
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox addpatient_picturebox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 Star_Appointment;
        public System.Windows.Forms.Button exit;
    }
}