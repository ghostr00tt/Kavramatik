namespace sampleframe.cs
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
            this.txtPwS = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtUserS = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnlogSt = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPwS
            // 
            this.txtPwS.BorderColorFocused = System.Drawing.Color.Navy;
            this.txtPwS.BorderColorIdle = System.Drawing.Color.Navy;
            this.txtPwS.BorderColorMouseHover = System.Drawing.Color.Navy;
            this.txtPwS.BorderThickness = 1;
            this.txtPwS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPwS.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPwS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPwS.isPassword = true;
            this.txtPwS.Location = new System.Drawing.Point(209, 286);
            this.txtPwS.Margin = new System.Windows.Forms.Padding(4);
            this.txtPwS.Name = "txtPwS";
            this.txtPwS.Size = new System.Drawing.Size(143, 25);
            this.txtPwS.TabIndex = 65;
            this.txtPwS.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtUserS
            // 
            this.txtUserS.BorderColorFocused = System.Drawing.Color.Navy;
            this.txtUserS.BorderColorIdle = System.Drawing.Color.Navy;
            this.txtUserS.BorderColorMouseHover = System.Drawing.Color.Navy;
            this.txtUserS.BorderThickness = 1;
            this.txtUserS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserS.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUserS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUserS.isPassword = false;
            this.txtUserS.Location = new System.Drawing.Point(209, 209);
            this.txtUserS.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserS.Name = "txtUserS";
            this.txtUserS.Size = new System.Drawing.Size(143, 25);
            this.txtUserS.TabIndex = 64;
            this.txtUserS.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUserS.OnValueChanged += new System.EventHandler(this.txtUserS_OnValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(259, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 63;
            this.label3.Text = "Parola";
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
            this.btnlogSt.Location = new System.Drawing.Point(229, 320);
            this.btnlogSt.Margin = new System.Windows.Forms.Padding(5);
            this.btnlogSt.Name = "btnlogSt";
            this.btnlogSt.Size = new System.Drawing.Size(104, 29);
            this.btnlogSt.TabIndex = 66;
            this.btnlogSt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnlogSt.Click += new System.EventHandler(this.btnlogSt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::sampleframe.cs.Resource1.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(209, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
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
            // LoginAlternative
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::sampleframe.cs.Resource1.lightbackgorund;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(562, 394);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnlogSt);
            this.Controls.Add(this.txtPwS);
            this.Controls.Add(this.txtUserS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginAlternative";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginAlternative";
            this.Load += new System.EventHandler(this.LoginAlternative_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btnlogSt;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPwS;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtUserS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}