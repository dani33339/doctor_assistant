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
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.login_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.signup_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(420, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 420);
            this.panel1.TabIndex = 0;
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
            this.button1.Location = new System.Drawing.Point(178, 4);
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
            this.label4.Location = new System.Drawing.Point(-1, 61);
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
            this.pictureBox1.Location = new System.Drawing.Point(156, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
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
            // login_btn
            // 
            this.login_btn.ActiveBorderThickness = 1;
            this.login_btn.ActiveCornerRadius = 20;
            this.login_btn.ActiveFillColor = System.Drawing.Color.SlateGray;
            this.login_btn.ActiveForecolor = System.Drawing.Color.White;
            this.login_btn.ActiveLineColor = System.Drawing.Color.DarkSlateGray;
            this.login_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.login_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("login_btn.BackgroundImage")));
            this.login_btn.ButtonText = "התחבר";
            this.login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_btn.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.login_btn.IdleBorderThickness = 1;
            this.login_btn.IdleCornerRadius = 20;
            this.login_btn.IdleFillColor = System.Drawing.Color.LightSkyBlue;
            this.login_btn.IdleForecolor = System.Drawing.Color.DarkSlateGray;
            this.login_btn.IdleLineColor = System.Drawing.Color.LightSlateGray;
            this.login_btn.Location = new System.Drawing.Point(143, 284);
            this.login_btn.Margin = new System.Windows.Forms.Padding(6);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(157, 51);
            this.login_btn.TabIndex = 17;
            this.login_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.login_btn.Click += new System.EventHandler(this.login_button_Click_1);
            // 
            // signup_btn
            // 
            this.signup_btn.ActiveBorderThickness = 1;
            this.signup_btn.ActiveCornerRadius = 20;
            this.signup_btn.ActiveFillColor = System.Drawing.Color.SlateGray;
            this.signup_btn.ActiveForecolor = System.Drawing.Color.White;
            this.signup_btn.ActiveLineColor = System.Drawing.Color.DarkSlateGray;
            this.signup_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signup_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("signup_btn.BackgroundImage")));
            this.signup_btn.ButtonText = "צור משתמש חדש";
            this.signup_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_btn.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_btn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.signup_btn.IdleBorderThickness = 1;
            this.signup_btn.IdleCornerRadius = 20;
            this.signup_btn.IdleFillColor = System.Drawing.Color.LightSkyBlue;
            this.signup_btn.IdleForecolor = System.Drawing.Color.DarkSlateGray;
            this.signup_btn.IdleLineColor = System.Drawing.Color.LightSlateGray;
            this.signup_btn.Location = new System.Drawing.Point(143, 347);
            this.signup_btn.Margin = new System.Windows.Forms.Padding(6);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(157, 40);
            this.signup_btn.TabIndex = 18;
            this.signup_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signup_btn.Click += new System.EventHandler(this.signup_btn_Click);
            // 
            // Login
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(649, 420);
            this.Controls.Add(this.signup_btn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.username_textbox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuThinButton2 login_btn;
        private Bunifu.Framework.UI.BunifuThinButton2 signup_btn;
        public System.Windows.Forms.Button button1;
    }
}