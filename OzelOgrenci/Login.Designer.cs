namespace sampleframe.cs
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserS = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtPwS = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnlogSt = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BtnClose = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblTitle.Location = new System.Drawing.Point(626, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(88, 37);
            this.lblTitle.TabIndex = 45;
            this.lblTitle.Text = "Giriş";
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.BackColor = System.Drawing.Color.Transparent;
            this.lblUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserType.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblUserType.Location = new System.Drawing.Point(372, 119);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(120, 25);
            this.lblUserType.TabIndex = 46;
            this.lblUserType.Text = "User Type";
            this.lblUserType.Click += new System.EventHandler(this.lblUserType_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(410, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 49;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(410, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 50;
            this.label3.Text = "Parola";
            // 
            // txtUserS
            // 
            this.txtUserS.BorderColorFocused = System.Drawing.Color.Navy;
            this.txtUserS.BorderColorIdle = System.Drawing.Color.Navy;
            this.txtUserS.BorderColorMouseHover = System.Drawing.Color.Navy;
            this.txtUserS.BorderThickness = 3;
            this.txtUserS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserS.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUserS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUserS.isPassword = false;
            this.txtUserS.Location = new System.Drawing.Point(514, 177);
            this.txtUserS.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserS.Name = "txtUserS";
            this.txtUserS.Size = new System.Drawing.Size(370, 44);
            this.txtUserS.TabIndex = 59;
            this.txtUserS.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPwS
            // 
            this.txtPwS.BorderColorFocused = System.Drawing.Color.Navy;
            this.txtPwS.BorderColorIdle = System.Drawing.Color.Navy;
            this.txtPwS.BorderColorMouseHover = System.Drawing.Color.Navy;
            this.txtPwS.BorderThickness = 3;
            this.txtPwS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPwS.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPwS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPwS.isPassword = true;
            this.txtPwS.Location = new System.Drawing.Point(514, 251);
            this.txtPwS.Margin = new System.Windows.Forms.Padding(4);
            this.txtPwS.Name = "txtPwS";
            this.txtPwS.Size = new System.Drawing.Size(370, 44);
            this.txtPwS.TabIndex = 60;
            this.txtPwS.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.btnlogSt.ButtonText = "Giriş";
            this.btnlogSt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogSt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogSt.ForeColor = System.Drawing.Color.Navy;
            this.btnlogSt.IdleBorderThickness = 1;
            this.btnlogSt.IdleCornerRadius = 20;
            this.btnlogSt.IdleFillColor = System.Drawing.Color.White;
            this.btnlogSt.IdleForecolor = System.Drawing.Color.Navy;
            this.btnlogSt.IdleLineColor = System.Drawing.Color.Navy;
            this.btnlogSt.Location = new System.Drawing.Point(601, 304);
            this.btnlogSt.Margin = new System.Windows.Forms.Padding(5);
            this.btnlogSt.Name = "btnlogSt";
            this.btnlogSt.Size = new System.Drawing.Size(181, 41);
            this.btnlogSt.TabIndex = 61;
            this.btnlogSt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnlogSt.Click += new System.EventHandler(this.btnlogSt_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Firebrick;
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.ErrorImage = null;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.ImageActive = null;
            this.BtnClose.InitialImage = null;
            this.BtnClose.Location = new System.Drawing.Point(948, 13);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(4);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(29, 27);
            this.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnClose.TabIndex = 67;
            this.BtnClose.TabStop = false;
            this.BtnClose.Zoom = 15;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(990, 454);
            this.ControlBox = false;
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.btnlogSt);
            this.Controls.Add(this.txtPwS);
            this.Controls.Add(this.txtUserS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.lblTitle);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtUserS;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPwS;
        private Bunifu.Framework.UI.BunifuThinButton2 btnlogSt;
        private Bunifu.Framework.UI.BunifuImageButton BtnClose;
        
        
    }
}