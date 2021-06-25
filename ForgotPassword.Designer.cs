namespace Kavramatik.cs
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            this.button1 = new System.Windows.Forms.Button();
            this.txtVerificationCode = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPasswordAgain = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnlogSt = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtUsermail = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGonder = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(538, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 100;
            this.button1.Text = "Girişe dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtVerificationCode
            // 
            this.txtVerificationCode.BorderColorFocused = System.Drawing.Color.Navy;
            this.txtVerificationCode.BorderColorIdle = System.Drawing.Color.Navy;
            this.txtVerificationCode.BorderColorMouseHover = System.Drawing.Color.Navy;
            this.txtVerificationCode.BorderThickness = 1;
            this.txtVerificationCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVerificationCode.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtVerificationCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtVerificationCode.isPassword = true;
            this.txtVerificationCode.Location = new System.Drawing.Point(362, 241);
            this.txtVerificationCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtVerificationCode.Name = "txtVerificationCode";
            this.txtVerificationCode.Size = new System.Drawing.Size(143, 25);
            this.txtVerificationCode.TabIndex = 99;
            this.txtVerificationCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(387, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 15);
            this.label5.TabIndex = 98;
            this.label5.Text = "Parola Tekrar";
            // 
            // txtPasswordAgain
            // 
            this.txtPasswordAgain.BorderColorFocused = System.Drawing.Color.Navy;
            this.txtPasswordAgain.BorderColorIdle = System.Drawing.Color.Navy;
            this.txtPasswordAgain.BorderColorMouseHover = System.Drawing.Color.Navy;
            this.txtPasswordAgain.BorderThickness = 1;
            this.txtPasswordAgain.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPasswordAgain.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPasswordAgain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPasswordAgain.isPassword = false;
            this.txtPasswordAgain.Location = new System.Drawing.Point(362, 336);
            this.txtPasswordAgain.Margin = new System.Windows.Forms.Padding(4);
            this.txtPasswordAgain.Name = "txtPasswordAgain";
            this.txtPasswordAgain.Size = new System.Drawing.Size(143, 25);
            this.txtPasswordAgain.TabIndex = 97;
            this.txtPasswordAgain.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(414, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 96;
            this.label4.Text = "Parola";
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Location = new System.Drawing.Point(426, 400);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(0, 13);
            this.lblErrorMessage.TabIndex = 94;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(373, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 93;
            this.label1.Text = "KAVRAMATİK";
            // 
            // btnlogSt
            // 
            this.btnlogSt.ActiveBorderThickness = 1;
            this.btnlogSt.ActiveCornerRadius = 20;
            this.btnlogSt.ActiveFillColor = System.Drawing.Color.Navy;
            this.btnlogSt.ActiveForecolor = System.Drawing.Color.White;
            this.btnlogSt.ActiveLineColor = System.Drawing.Color.FloralWhite;
            this.btnlogSt.BackColor = System.Drawing.SystemColors.Control;
            this.btnlogSt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlogSt.BackgroundImage")));
            this.btnlogSt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnlogSt.ButtonText = "Doğrulama";
            this.btnlogSt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogSt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogSt.ForeColor = System.Drawing.Color.Navy;
            this.btnlogSt.IdleBorderThickness = 1;
            this.btnlogSt.IdleCornerRadius = 20;
            this.btnlogSt.IdleFillColor = System.Drawing.Color.White;
            this.btnlogSt.IdleForecolor = System.Drawing.Color.Navy;
            this.btnlogSt.IdleLineColor = System.Drawing.Color.Navy;
            this.btnlogSt.Location = new System.Drawing.Point(377, 235);
            this.btnlogSt.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.btnlogSt.Name = "btnlogSt";
            this.btnlogSt.Size = new System.Drawing.Size(114, 31);
            this.btnlogSt.TabIndex = 92;
            this.btnlogSt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnlogSt.Click += new System.EventHandler(this.btnlogSt_Click);
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
            this.txtPassword.Location = new System.Drawing.Point(362, 284);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(143, 25);
            this.txtPassword.TabIndex = 91;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtUsermail
            // 
            this.txtUsermail.BorderColorFocused = System.Drawing.Color.Navy;
            this.txtUsermail.BorderColorIdle = System.Drawing.Color.Navy;
            this.txtUsermail.BorderColorMouseHover = System.Drawing.Color.Navy;
            this.txtUsermail.BorderThickness = 1;
            this.txtUsermail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsermail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUsermail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsermail.isPassword = false;
            this.txtUsermail.Location = new System.Drawing.Point(362, 186);
            this.txtUsermail.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsermail.Name = "txtUsermail";
            this.txtUsermail.Size = new System.Drawing.Size(143, 25);
            this.txtUsermail.TabIndex = 90;
            this.txtUsermail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsermail.OnValueChanged += new System.EventHandler(this.txtUsermail_OnValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(380, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 15);
            this.label3.TabIndex = 89;
            this.label3.Text = "Doğrulama Kodu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(388, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 88;
            this.label2.Text = "E-Mail Adresi";
            // 
            // btnGonder
            // 
            this.btnGonder.ActiveBorderThickness = 1;
            this.btnGonder.ActiveCornerRadius = 20;
            this.btnGonder.ActiveFillColor = System.Drawing.Color.Navy;
            this.btnGonder.ActiveForecolor = System.Drawing.Color.White;
            this.btnGonder.ActiveLineColor = System.Drawing.Color.FloralWhite;
            this.btnGonder.BackColor = System.Drawing.SystemColors.Control;
            this.btnGonder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGonder.BackgroundImage")));
            this.btnGonder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGonder.ButtonText = "Gönder";
            this.btnGonder.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGonder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGonder.ForeColor = System.Drawing.Color.Navy;
            this.btnGonder.IdleBorderThickness = 1;
            this.btnGonder.IdleCornerRadius = 20;
            this.btnGonder.IdleFillColor = System.Drawing.Color.White;
            this.btnGonder.IdleForecolor = System.Drawing.Color.Navy;
            this.btnGonder.IdleLineColor = System.Drawing.Color.Navy;
            this.btnGonder.Location = new System.Drawing.Point(377, 369);
            this.btnGonder.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(114, 31);
            this.btnGonder.TabIndex = 101;
            this.btnGonder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kavramatik.cs.Resource1.web1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtVerificationCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPasswordAgain);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnlogSt);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsermail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifremi Unuttum";
            this.Load += new System.EventHandler(this.ForgotPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtVerificationCode;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPasswordAgain;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnlogSt;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPassword;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtUsermail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGonder;
    }
}