namespace Kavramatik.cs
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnlogSt = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtUsermail = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPasswordAgain = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Location = new System.Drawing.Point(293, 414);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(0, 13);
            this.lblErrorMessage.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(243, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 80;
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
            this.btnlogSt.ButtonText = "Kayıt";
            this.btnlogSt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogSt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogSt.ForeColor = System.Drawing.Color.Navy;
            this.btnlogSt.IdleBorderThickness = 1;
            this.btnlogSt.IdleCornerRadius = 20;
            this.btnlogSt.IdleFillColor = System.Drawing.Color.White;
            this.btnlogSt.IdleForecolor = System.Drawing.Color.Navy;
            this.btnlogSt.IdleLineColor = System.Drawing.Color.Navy;
            this.btnlogSt.Location = new System.Drawing.Point(245, 407);
            this.btnlogSt.Margin = new System.Windows.Forms.Padding(5);
            this.btnlogSt.Name = "btnlogSt";
            this.btnlogSt.Size = new System.Drawing.Size(104, 29);
            this.btnlogSt.TabIndex = 79;
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
            this.txtPassword.Location = new System.Drawing.Point(227, 321);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(143, 25);
            this.txtPassword.TabIndex = 78;
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
            this.txtUsermail.Location = new System.Drawing.Point(227, 200);
            this.txtUsermail.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsermail.Name = "txtUsermail";
            this.txtUsermail.Size = new System.Drawing.Size(143, 25);
            this.txtUsermail.TabIndex = 77;
            this.txtUsermail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(274, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 76;
            this.label3.Text = "Parola";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(255, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 75;
            this.label2.Text = "E-Mail Adresi";
            // 
            // txtUserName
            // 
            this.txtUserName.BorderColorFocused = System.Drawing.Color.Navy;
            this.txtUserName.BorderColorIdle = System.Drawing.Color.Navy;
            this.txtUserName.BorderColorMouseHover = System.Drawing.Color.Navy;
            this.txtUserName.BorderThickness = 1;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUserName.isPassword = false;
            this.txtUserName.Location = new System.Drawing.Point(227, 261);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(143, 25);
            this.txtUserName.TabIndex = 84;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(265, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 83;
            this.label4.Text = "Ad-Soyad";
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
            this.txtPasswordAgain.isPassword = true;
            this.txtPasswordAgain.Location = new System.Drawing.Point(227, 373);
            this.txtPasswordAgain.Margin = new System.Windows.Forms.Padding(4);
            this.txtPasswordAgain.Name = "txtPasswordAgain";
            this.txtPasswordAgain.Size = new System.Drawing.Size(143, 25);
            this.txtPasswordAgain.TabIndex = 86;
            this.txtPasswordAgain.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPasswordAgain.OnValueChanged += new System.EventHandler(this.bunifuMetroTextbox1_OnValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(254, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 15);
            this.label5.TabIndex = 85;
            this.label5.Text = "Parola Tekrar";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(405, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 87;
            this.button1.Text = "Girişe dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kavramatik.cs.Resource1.web1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(594, 474);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPasswordAgain);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnlogSt);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsermail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnlogSt;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPassword;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtUsermail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtUserName;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPasswordAgain;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}