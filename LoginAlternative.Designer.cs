namespace Kavramatik.cs
{
    partial class LoginAlternative
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginAlternative));
            this.txtPassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtUsername = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnlogSt = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAnonym = new Bunifu.Framework.UI.BunifuThinButton2();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.BorderColorFocused = System.Drawing.Color.Navy;
            this.txtPassword.BorderColorIdle = System.Drawing.Color.Navy;
            this.txtPassword.BorderColorMouseHover = System.Drawing.Color.Navy;
            this.txtPassword.BorderThickness = 1;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.isPassword = true;
            this.txtPassword.Location = new System.Drawing.Point(209, 270);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(143, 25);
            this.txtPassword.TabIndex = 65;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.OnValueChanged += new System.EventHandler(this.txtPassword_OnValueChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.BorderColorFocused = System.Drawing.Color.Navy;
            this.txtUsername.BorderColorIdle = System.Drawing.Color.Navy;
            this.txtUsername.BorderColorMouseHover = System.Drawing.Color.Navy;
            this.txtUsername.BorderThickness = 1;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername.isPassword = false;
            this.txtUsername.Location = new System.Drawing.Point(209, 209);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(143, 25);
            this.txtUsername.TabIndex = 64;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsername.OnValueChanged += new System.EventHandler(this.txtUserS_OnValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(256, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 63;
            this.label3.Text = "Parola";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(237, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 62;
            this.label2.Text = "Kullanıcı Adı";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnlogSt
            // 
            this.btnlogSt.ActiveBorderThickness = 1;
            this.btnlogSt.ActiveCornerRadius = 20;
            this.btnlogSt.ActiveFillColor = System.Drawing.Color.Navy;
            this.btnlogSt.ActiveForecolor = System.Drawing.Color.White;
            this.btnlogSt.ActiveLineColor = System.Drawing.Color.FloralWhite;
            this.btnlogSt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnlogSt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlogSt.BackgroundImage")));
            this.btnlogSt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnlogSt.ButtonText = "Giriş";
            this.btnlogSt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogSt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogSt.ForeColor = System.Drawing.Color.Navy;
            this.btnlogSt.IdleBorderThickness = 1;
            this.btnlogSt.IdleCornerRadius = 20;
            this.btnlogSt.IdleFillColor = System.Drawing.Color.White;
            this.btnlogSt.IdleForecolor = System.Drawing.Color.Navy;
            this.btnlogSt.IdleLineColor = System.Drawing.Color.Navy;
            this.btnlogSt.Location = new System.Drawing.Point(229, 304);
            this.btnlogSt.Margin = new System.Windows.Forms.Padding(5);
            this.btnlogSt.Name = "btnlogSt";
            this.btnlogSt.Size = new System.Drawing.Size(104, 29);
            this.btnlogSt.TabIndex = 66;
            this.btnlogSt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnlogSt.Click += new System.EventHandler(this.btnlogSt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(225, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 68;
            this.label1.Text = "KAVRAMATİK";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Location = new System.Drawing.Point(270, 382);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(0, 13);
            this.lblErrorMessage.TabIndex = 69;
            this.lblErrorMessage.Click += new System.EventHandler(this.lblErrorMessage_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 73;
            this.label4.Text = "Hesabınız yok mu ? ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(303, 368);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(83, 13);
            this.linkLabel1.TabIndex = 74;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Şimdi kayıt olun.";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(237, 395);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(81, 13);
            this.linkLabel2.TabIndex = 75;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Şifremi Unuttum";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 76;
            // 
            // btnAnonym
            // 
            this.btnAnonym.ActiveBorderThickness = 1;
            this.btnAnonym.ActiveCornerRadius = 20;
            this.btnAnonym.ActiveFillColor = System.Drawing.Color.Navy;
            this.btnAnonym.ActiveForecolor = System.Drawing.Color.White;
            this.btnAnonym.ActiveLineColor = System.Drawing.Color.FloralWhite;
            this.btnAnonym.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAnonym.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAnonym.BackgroundImage")));
            this.btnAnonym.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAnonym.ButtonText = "Anonim";
            this.btnAnonym.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnonym.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnonym.ForeColor = System.Drawing.Color.Navy;
            this.btnAnonym.IdleBorderThickness = 1;
            this.btnAnonym.IdleCornerRadius = 20;
            this.btnAnonym.IdleFillColor = System.Drawing.Color.White;
            this.btnAnonym.IdleForecolor = System.Drawing.Color.Navy;
            this.btnAnonym.IdleLineColor = System.Drawing.Color.Navy;
            this.btnAnonym.Location = new System.Drawing.Point(454, 366);
            this.btnAnonym.Margin = new System.Windows.Forms.Padding(5);
            this.btnAnonym.Name = "btnAnonym";
            this.btnAnonym.Size = new System.Drawing.Size(104, 29);
            this.btnAnonym.TabIndex = 77;
            this.btnAnonym.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAnonym.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Kavramatik.cs.Resource1.aaaaaaaaaaaaaaaaa;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(552, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 26);
            this.button1.TabIndex = 78;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginAlternative
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::Kavramatik.cs.Resource1.web1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(589, 417);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAnonym);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnlogSt);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginAlternative";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginAlternative";
            this.Load += new System.EventHandler(this.LoginAlternative_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btnlogSt;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPassword;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAnonym;
        private System.Windows.Forms.Button button1;
    }
}