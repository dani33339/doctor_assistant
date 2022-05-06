namespace Doctor_assistant.Forms
{
    partial class Diagnosis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Diagnosis));
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.question_label = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
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
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            this.label2.Size = new System.Drawing.Size(153, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "אבחון המחלה";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label2);
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
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1234, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 41);
            this.button1.TabIndex = 28;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // question_label
            // 
            this.question_label.AutoSize = true;
            this.question_label.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question_label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.question_label.Location = new System.Drawing.Point(384, 113);
            this.question_label.Name = "question_label";
            this.question_label.Size = new System.Drawing.Size(192, 33);
            this.question_label.TabIndex = 29;
            this.question_label.Text = "?האם אתה מעשן";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(591, 216);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(201, 156);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(211, 216);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(201, 156);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 48;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
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
            this.panel1.TabIndex = 49;
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
            // Diagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 836);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.question_label);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Diagnosis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diagnosis";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.Label question_label;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.Button button1;
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
    }
}