﻿namespace Doctor_assistant.Forms
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.login_button = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label6 = new System.Windows.Forms.Label();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.id_textbox = new System.Windows.Forms.TextBox();
            this.repassword_textbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.returnBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.returnBtn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(414, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 527);
            this.panel1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.AllowDrop = true;
            this.button1.AutoEllipsis = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(186, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 41);
            this.button1.TabIndex = 45;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DodgerBlue;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Menu;
            this.label5.Location = new System.Drawing.Point(93, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 33);
            this.label5.TabIndex = 3;
            this.label5.Text = "יעילות גבוה";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DodgerBlue;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Menu;
            this.label4.Location = new System.Drawing.Point(3, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "שירותי בריאות מנצחים";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(339, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "סיסמה";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(299, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "שם משתמש";
            // 
            // password_textbox
            // 
            this.password_textbox.BackColor = System.Drawing.Color.SkyBlue;
            this.password_textbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_textbox.Location = new System.Drawing.Point(37, 243);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(225, 27);
            this.password_textbox.TabIndex = 13;
            // 
            // username_textbox
            // 
            this.username_textbox.BackColor = System.Drawing.Color.SkyBlue;
            this.username_textbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_textbox.Location = new System.Drawing.Point(37, 193);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(225, 27);
            this.username_textbox.TabIndex = 12;
            this.username_textbox.TextChanged += new System.EventHandler(this.username_textbox_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(118, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 36);
            this.label1.TabIndex = 10;
            this.label1.Text = "מערכת לניהול מטופלים";
            // 
            // login_button
            // 
            this.login_button.ActiveBorderThickness = 1;
            this.login_button.ActiveCornerRadius = 20;
            this.login_button.ActiveFillColor = System.Drawing.Color.SlateGray;
            this.login_button.ActiveForecolor = System.Drawing.Color.White;
            this.login_button.ActiveLineColor = System.Drawing.Color.DarkSlateGray;
            this.login_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.login_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("login_button.BackgroundImage")));
            this.login_button.ButtonText = "הירשם";
            this.login_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_button.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.ForeColor = System.Drawing.Color.DodgerBlue;
            this.login_button.IdleBorderThickness = 1;
            this.login_button.IdleCornerRadius = 20;
            this.login_button.IdleFillColor = System.Drawing.Color.LightSkyBlue;
            this.login_button.IdleForecolor = System.Drawing.Color.DarkSlateGray;
            this.login_button.IdleLineColor = System.Drawing.Color.LightSlateGray;
            this.login_button.Location = new System.Drawing.Point(118, 461);
            this.login_button.Margin = new System.Windows.Forms.Padding(6);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(144, 51);
            this.login_button.TabIndex = 16;
            this.login_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(329, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 22);
            this.label6.TabIndex = 17;
            this.label6.Text = "שם מלא";
            // 
            // name_textbox
            // 
            this.name_textbox.BackColor = System.Drawing.Color.SkyBlue;
            this.name_textbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_textbox.Location = new System.Drawing.Point(37, 358);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(225, 27);
            this.name_textbox.TabIndex = 18;
            this.name_textbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Location = new System.Drawing.Point(304, 425);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 22);
            this.label7.TabIndex = 19;
            this.label7.Text = "תעודת זהות";
            // 
            // id_textbox
            // 
            this.id_textbox.BackColor = System.Drawing.Color.SkyBlue;
            this.id_textbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_textbox.Location = new System.Drawing.Point(37, 425);
            this.id_textbox.Name = "id_textbox";
            this.id_textbox.Size = new System.Drawing.Size(225, 27);
            this.id_textbox.TabIndex = 20;
            this.id_textbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // repassword_textbox
            // 
            this.repassword_textbox.BackColor = System.Drawing.Color.SkyBlue;
            this.repassword_textbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repassword_textbox.Location = new System.Drawing.Point(37, 302);
            this.repassword_textbox.Name = "repassword_textbox";
            this.repassword_textbox.Size = new System.Drawing.Size(225, 27);
            this.repassword_textbox.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label8.Location = new System.Drawing.Point(273, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 22);
            this.label8.TabIndex = 22;
            this.label8.Text = "חזור על הסיסמא";
            // 
            // returnBtn
            // 
            this.returnBtn.ActiveBorderThickness = 1;
            this.returnBtn.ActiveCornerRadius = 20;
            this.returnBtn.ActiveFillColor = System.Drawing.Color.SlateGray;
            this.returnBtn.ActiveForecolor = System.Drawing.Color.White;
            this.returnBtn.ActiveLineColor = System.Drawing.Color.DarkSlateGray;
            this.returnBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.returnBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("returnBtn.BackgroundImage")));
            this.returnBtn.ButtonText = "חזרה";
            this.returnBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnBtn.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.returnBtn.IdleBorderThickness = 1;
            this.returnBtn.IdleCornerRadius = 20;
            this.returnBtn.IdleFillColor = System.Drawing.Color.LightSkyBlue;
            this.returnBtn.IdleForecolor = System.Drawing.Color.DarkSlateGray;
            this.returnBtn.IdleLineColor = System.Drawing.Color.LightSlateGray;
            this.returnBtn.Location = new System.Drawing.Point(149, 470);
            this.returnBtn.Margin = new System.Windows.Forms.Padding(6);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(72, 42);
            this.returnBtn.TabIndex = 46;
            this.returnBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(649, 527);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.repassword_textbox);
            this.Controls.Add(this.id_textbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.username_textbox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signup";
            this.Load += new System.EventHandler(this.Signup_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 login_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox id_textbox;
        private System.Windows.Forms.TextBox repassword_textbox;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuThinButton2 returnBtn;
    }
}