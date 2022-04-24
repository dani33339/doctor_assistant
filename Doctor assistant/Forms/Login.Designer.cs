namespace Doctor_assistant.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.login_button = new Bunifu.Framework.UI.BunifuThinButton2();
            this.registration_button = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(425, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 402);
            this.panel1.TabIndex = 0;
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
            this.label4.Location = new System.Drawing.Point(-4, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "שירותי בריאות מנצחים";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(87, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "מערכת לניהול מטופלים";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(172, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // username_textbox
            // 
            this.username_textbox.BackColor = System.Drawing.Color.SkyBlue;
            this.username_textbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_textbox.Location = new System.Drawing.Point(75, 193);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(225, 27);
            this.username_textbox.TabIndex = 3;
            this.username_textbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // password_textbox
            // 
            this.password_textbox.BackColor = System.Drawing.Color.SkyBlue;
            this.password_textbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_textbox.Location = new System.Drawing.Point(75, 243);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(225, 27);
            this.password_textbox.TabIndex = 4;
            this.password_textbox.TextChanged += new System.EventHandler(this.password_textbox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(321, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "שם משתמש";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(361, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "סיסמה";
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            this.login_button.ButtonText = "כניסה";
            this.login_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_button.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.ForeColor = System.Drawing.Color.DodgerBlue;
            this.login_button.IdleBorderThickness = 1;
            this.login_button.IdleCornerRadius = 20;
            this.login_button.IdleFillColor = System.Drawing.Color.LightSkyBlue;
            this.login_button.IdleForecolor = System.Drawing.Color.DarkSlateGray;
            this.login_button.IdleLineColor = System.Drawing.Color.LightSlateGray;
            this.login_button.Location = new System.Drawing.Point(143, 279);
            this.login_button.Margin = new System.Windows.Forms.Padding(6);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(157, 51);
            this.login_button.TabIndex = 7;
            this.login_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // registration_button
            // 
            this.registration_button.ActiveBorderThickness = 1;
            this.registration_button.ActiveCornerRadius = 20;
            this.registration_button.ActiveFillColor = System.Drawing.Color.SlateGray;
            this.registration_button.ActiveForecolor = System.Drawing.Color.White;
            this.registration_button.ActiveLineColor = System.Drawing.Color.DarkSlateGray;
            this.registration_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registration_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("registration_button.BackgroundImage")));
            this.registration_button.ButtonText = "משתמש חדש";
            this.registration_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registration_button.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registration_button.ForeColor = System.Drawing.Color.DodgerBlue;
            this.registration_button.IdleBorderThickness = 1;
            this.registration_button.IdleCornerRadius = 20;
            this.registration_button.IdleFillColor = System.Drawing.Color.Transparent;
            this.registration_button.IdleForecolor = System.Drawing.Color.DarkSlateGray;
            this.registration_button.IdleLineColor = System.Drawing.Color.Transparent;
            this.registration_button.Location = new System.Drawing.Point(143, 336);
            this.registration_button.Margin = new System.Windows.Forms.Padding(6);
            this.registration_button.Name = "registration_button";
            this.registration_button.Size = new System.Drawing.Size(157, 51);
            this.registration_button.TabIndex = 8;
            this.registration_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(649, 402);
            this.Controls.Add(this.registration_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.username_textbox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 login_button;
        private Bunifu.Framework.UI.BunifuThinButton2 registration_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}