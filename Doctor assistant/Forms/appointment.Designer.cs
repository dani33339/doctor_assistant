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
            this.label2 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.patientname_label = new System.Windows.Forms.Label();
            this.medicalindices_textbox = new System.Windows.Forms.TextBox();
            this.diagnosis_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddPatients_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.MyPatients_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.exit = new System.Windows.Forms.Button();
            this.patient_picturebox = new System.Windows.Forms.PictureBox();
            this.docname_label = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.addpatient_picturebox = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patient_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
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
            this.name.Location = new System.Drawing.Point(848, 66);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(106, 33);
            this.name.TabIndex = 28;
            this.name.Text = ":שם מלא";
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
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.appointment_label);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1280, 45);
            this.panel2.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(828, 186);
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
            // medicalindices_textbox
            // 
            this.medicalindices_textbox.BackColor = System.Drawing.Color.SkyBlue;
            this.medicalindices_textbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicalindices_textbox.Location = new System.Drawing.Point(70, 224);
            this.medicalindices_textbox.Multiline = true;
            this.medicalindices_textbox.Name = "medicalindices_textbox";
            this.medicalindices_textbox.Size = new System.Drawing.Size(900, 229);
            this.medicalindices_textbox.TabIndex = 40;
            this.medicalindices_textbox.TextChanged += new System.EventHandler(this.medicalindices_textbox_TextChanged);
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
            this.diagnosis_btn.Location = new System.Drawing.Point(336, 528);
            this.diagnosis_btn.Margin = new System.Windows.Forms.Padding(6);
            this.diagnosis_btn.Name = "diagnosis_btn";
            this.diagnosis_btn.Size = new System.Drawing.Size(371, 46);
            this.diagnosis_btn.TabIndex = 41;
            this.diagnosis_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.AddPatients_btn);
            this.panel1.Controls.Add(this.MyPatients_btn);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.patient_picturebox);
            this.panel1.Controls.Add(this.docname_label);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.addpatient_picturebox);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
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
            this.dataGridView.Location = new System.Drawing.Point(386, 168);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(240, 150);
            this.dataGridView.TabIndex = 43;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 836);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.diagnosis_btn);
            this.Controls.Add(this.medicalindices_textbox);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
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
        private System.Windows.Forms.TextBox medicalindices_textbox;
        private Bunifu.Framework.UI.BunifuThinButton2 diagnosis_btn;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 AddPatients_btn;
        private Bunifu.Framework.UI.BunifuThinButton2 MyPatients_btn;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.PictureBox patient_picturebox;
        private System.Windows.Forms.Label docname_label;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox addpatient_picturebox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}