namespace Doctor_assistant.Forms
{
    partial class appointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(appointment));
            this.imortfile_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pantientid_label = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.appointment_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.patientname_label = new System.Windows.Forms.Label();
            this.diagnosis_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddPatients_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.MyPatients_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.exit = new System.Windows.Forms.Button();
            this.patient_picturebox = new System.Windows.Forms.PictureBox();
            this.docname_label = new System.Windows.Forms.Label();
            this.addpatient_picturebox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.testexists_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.heat_textbox = new System.Windows.Forms.TextBox();
            this.pulse = new System.Windows.Forms.Label();
            this.pulse_textBox = new System.Windows.Forms.TextBox();
            this.bloodpressure = new System.Windows.Forms.Label();
            this.bloodpressure_textBox = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patient_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addpatient_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // imortfile_btn
            // 
            this.imortfile_btn.ActiveBorderThickness = 1;
            this.imortfile_btn.ActiveCornerRadius = 20;
            this.imortfile_btn.ActiveFillColor = System.Drawing.Color.SlateGray;
            this.imortfile_btn.ActiveForecolor = System.Drawing.SystemColors.Window;
            this.imortfile_btn.ActiveLineColor = System.Drawing.Color.DarkSlateGray;
            this.imortfile_btn.BackColor = System.Drawing.SystemColors.Control;
            this.imortfile_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imortfile_btn.BackgroundImage")));
            this.imortfile_btn.ButtonText = "לחץ לייבוא קובץ של בדיקות הדם";
            this.imortfile_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imortfile_btn.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imortfile_btn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.imortfile_btn.IdleBorderThickness = 1;
            this.imortfile_btn.IdleCornerRadius = 20;
            this.imortfile_btn.IdleFillColor = System.Drawing.Color.LightSkyBlue;
            this.imortfile_btn.IdleForecolor = System.Drawing.Color.DarkSlateGray;
            this.imortfile_btn.IdleLineColor = System.Drawing.Color.LightSlateGray;
            this.imortfile_btn.Location = new System.Drawing.Point(223, 84);
            this.imortfile_btn.Margin = new System.Windows.Forms.Padding(6);
            this.imortfile_btn.Name = "imortfile_btn";
            this.imortfile_btn.Size = new System.Drawing.Size(371, 46);
            this.imortfile_btn.TabIndex = 35;
            this.imortfile_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.imortfile_btn.Click += new System.EventHandler(this.imortfile_btn_Click);
            // 
            // pantientid_label
            // 
            this.pantientid_label.AutoSize = true;
            this.pantientid_label.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pantientid_label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.pantientid_label.Location = new System.Drawing.Point(628, 113);
            this.pantientid_label.Name = "pantientid_label";
            this.pantientid_label.Size = new System.Drawing.Size(150, 33);
            this.pantientid_label.TabIndex = 32;
            this.pantientid_label.Text = "329997731";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.name.Location = new System.Drawing.Point(824, 66);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(144, 33);
            this.name.TabIndex = 28;
            this.name.Text = ":שם המטופל";
            // 
            // appointment_label
            // 
            this.appointment_label.AutoSize = true;
            this.appointment_label.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointment_label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.appointment_label.Location = new System.Drawing.Point(818, 9);
            this.appointment_label.Name = "appointment_label";
            this.appointment_label.Size = new System.Drawing.Size(169, 33);
            this.appointment_label.TabIndex = 2;
            this.appointment_label.Text = "צור ביקור ליונתן";
            this.appointment_label.Click += new System.EventHandler(this.appointment_label_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.appointment_label);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1280, 45);
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
            this.button1.Location = new System.Drawing.Point(1234, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 41);
            this.button1.TabIndex = 44;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(818, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 33);
            this.label2.TabIndex = 37;
            this.label2.Text = ":הכנס מדדים";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.id.Location = new System.Drawing.Point(628, 66);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(139, 33);
            this.id.TabIndex = 38;
            this.id.Text = ":תעודת זהות";
            // 
            // patientname_label
            // 
            this.patientname_label.AutoSize = true;
            this.patientname_label.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientname_label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.patientname_label.Location = new System.Drawing.Point(848, 113);
            this.patientname_label.Name = "patientname_label";
            this.patientname_label.Size = new System.Drawing.Size(90, 33);
            this.patientname_label.TabIndex = 39;
            this.patientname_label.Text = "יוסי כהן";
            this.patientname_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // diagnosis_btn
            // 
            this.diagnosis_btn.ActiveBorderThickness = 1;
            this.diagnosis_btn.ActiveCornerRadius = 20;
            this.diagnosis_btn.ActiveFillColor = System.Drawing.Color.SlateGray;
            this.diagnosis_btn.ActiveForecolor = System.Drawing.SystemColors.Window;
            this.diagnosis_btn.ActiveLineColor = System.Drawing.Color.DarkSlateGray;
            this.diagnosis_btn.BackColor = System.Drawing.SystemColors.Control;
            this.diagnosis_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("diagnosis_btn.BackgroundImage")));
            this.diagnosis_btn.ButtonText = "אבחן את המחלה";
            this.diagnosis_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.diagnosis_btn.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diagnosis_btn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.diagnosis_btn.IdleBorderThickness = 1;
            this.diagnosis_btn.IdleCornerRadius = 20;
            this.diagnosis_btn.IdleFillColor = System.Drawing.Color.LightSkyBlue;
            this.diagnosis_btn.IdleForecolor = System.Drawing.Color.DarkSlateGray;
            this.diagnosis_btn.IdleLineColor = System.Drawing.Color.LightSlateGray;
            this.diagnosis_btn.Location = new System.Drawing.Point(336, 592);
            this.diagnosis_btn.Margin = new System.Windows.Forms.Padding(6);
            this.diagnosis_btn.Name = "diagnosis_btn";
            this.diagnosis_btn.Size = new System.Drawing.Size(371, 46);
            this.diagnosis_btn.TabIndex = 41;
            this.diagnosis_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.diagnosis_btn.Click += new System.EventHandler(this.diagnosis_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.AddPatients_btn);
            this.panel1.Controls.Add(this.MyPatients_btn);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.patient_picturebox);
            this.panel1.Controls.Add(this.docname_label);
            this.panel1.Controls.Add(this.addpatient_picturebox);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(974, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 791);
            this.panel1.TabIndex = 42;
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
            this.AddPatients_btn.Click += new System.EventHandler(this.AddPatients_btn_Click_1);
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
            this.MyPatients_btn.Click += new System.EventHandler(this.MyPatients_btn_Click_1);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(206, 826);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 25;
            this.exit.Text = "יצאה";
            this.exit.UseVisualStyleBackColor = true;
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
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(26, 261);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(934, 72);
            this.dataGridView.TabIndex = 43;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // testexists_label
            // 
            this.testexists_label.AutoSize = true;
            this.testexists_label.Location = new System.Drawing.Point(704, 217);
            this.testexists_label.Name = "testexists_label";
            this.testexists_label.Size = new System.Drawing.Size(256, 21);
            this.testexists_label.TabIndex = 44;
            this.testexists_label.Text = ":קיימים למטופל בדיקות דם במערכת";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(907, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 33);
            this.label3.TabIndex = 46;
            this.label3.Text = "חום";
            this.label3.Click += new System.EventHandler(this.heat_Click);
            // 
            // heat_textbox
            // 
            this.heat_textbox.BackColor = System.Drawing.Color.SkyBlue;
            this.heat_textbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heat_textbox.Location = new System.Drawing.Point(823, 467);
            this.heat_textbox.Name = "heat_textbox";
            this.heat_textbox.Size = new System.Drawing.Size(137, 27);
            this.heat_textbox.TabIndex = 45;
            this.heat_textbox.TextChanged += new System.EventHandler(this.name_heat_TextChanged);
            // 
            // pulse
            // 
            this.pulse.AutoSize = true;
            this.pulse.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pulse.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.pulse.Location = new System.Drawing.Point(701, 422);
            this.pulse.Name = "pulse";
            this.pulse.Size = new System.Drawing.Size(62, 33);
            this.pulse.TabIndex = 48;
            this.pulse.Text = "דופק";
            // 
            // pulse_textBox
            // 
            this.pulse_textBox.BackColor = System.Drawing.Color.SkyBlue;
            this.pulse_textBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pulse_textBox.Location = new System.Drawing.Point(626, 467);
            this.pulse_textBox.Name = "pulse_textBox";
            this.pulse_textBox.Size = new System.Drawing.Size(137, 27);
            this.pulse_textBox.TabIndex = 47;
            this.pulse_textBox.TextChanged += new System.EventHandler(this.pulse_textBox_TextChanged);
            // 
            // bloodpressure
            // 
            this.bloodpressure.AutoSize = true;
            this.bloodpressure.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloodpressure.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bloodpressure.Location = new System.Drawing.Point(477, 422);
            this.bloodpressure.Name = "bloodpressure";
            this.bloodpressure.Size = new System.Drawing.Size(88, 33);
            this.bloodpressure.TabIndex = 50;
            this.bloodpressure.Text = "לחץ דם";
            // 
            // bloodpressure_textBox
            // 
            this.bloodpressure_textBox.BackColor = System.Drawing.Color.SkyBlue;
            this.bloodpressure_textBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloodpressure_textBox.Location = new System.Drawing.Point(428, 467);
            this.bloodpressure_textBox.Name = "bloodpressure_textBox";
            this.bloodpressure_textBox.Size = new System.Drawing.Size(137, 27);
            this.bloodpressure_textBox.TabIndex = 49;
            this.bloodpressure_textBox.TextChanged += new System.EventHandler(this.bloodpressure_textBox_TextChanged);
            // 
            // appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 836);
            this.Controls.Add(this.bloodpressure);
            this.Controls.Add(this.bloodpressure_textBox);
            this.Controls.Add(this.pulse);
            this.Controls.Add(this.pulse_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.heat_textbox);
            this.Controls.Add(this.testexists_label);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.diagnosis_btn);
            this.Controls.Add(this.patientname_label);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imortfile_btn);
            this.Controls.Add(this.pantientid_label);
            this.Controls.Add(this.name);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "appointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "appointment";
            this.Load += new System.EventHandler(this.appointment_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patient_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addpatient_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuThinButton2 imortfile_btn;
        private System.Windows.Forms.Label pantientid_label;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label appointment_label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label patientname_label;
        private Bunifu.Framework.UI.BunifuThinButton2 diagnosis_btn;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 AddPatients_btn;
        private Bunifu.Framework.UI.BunifuThinButton2 MyPatients_btn;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.PictureBox patient_picturebox;
        private System.Windows.Forms.Label docname_label;
        private System.Windows.Forms.PictureBox addpatient_picturebox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label testexists_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox heat_textbox;
        private System.Windows.Forms.Label pulse;
        private System.Windows.Forms.TextBox pulse_textBox;
        private System.Windows.Forms.Label bloodpressure;
        private System.Windows.Forms.TextBox bloodpressure_textBox;
    }
}