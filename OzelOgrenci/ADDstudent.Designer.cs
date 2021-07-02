namespace sampleframe.cs
{
    partial class ADDstudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADDstudent));
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelStudentLog = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();
            this.txtFullName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtAddress = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.dateTimePicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtParentName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtTel = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtusername = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtpassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtrepassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnT1 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAdd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BtnClose = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(308, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 25);
            this.label7.TabIndex = 40;
            this.label7.Text = "Yeni Kullanıcı -";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(296, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 17);
            this.label8.TabIndex = 53;
            this.label8.Text = "Telefon Numarası";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(299, 419);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 17);
            this.label6.TabIndex = 52;
            this.label6.Text = "Parola Doğrulama";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(299, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 51;
            this.label5.Text = "Veli Adı";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(302, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 50;
            this.label4.Text = "Doğum Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(299, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 49;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(302, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 48;
            this.label2.Text = "Parola";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(300, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 47;
            this.label1.Text = "Adres";
            // 
            // labelStudentLog
            // 
            this.labelStudentLog.AutoSize = true;
            this.labelStudentLog.BackColor = System.Drawing.SystemColors.Control;
            this.labelStudentLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentLog.ForeColor = System.Drawing.Color.Navy;
            this.labelStudentLog.Location = new System.Drawing.Point(302, 105);
            this.labelStudentLog.Name = "labelStudentLog";
            this.labelStudentLog.Size = new System.Drawing.Size(107, 17);
            this.labelStudentLog.TabIndex = 46;
            this.labelStudentLog.Text = "İsim - Soyisim";
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.BackColor = System.Drawing.Color.Transparent;
            this.lblUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserType.ForeColor = System.Drawing.Color.Navy;
            this.lblUserType.Location = new System.Drawing.Point(461, 25);
            this.lblUserType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(54, 25);
            this.lblUserType.TabIndex = 56;
            this.lblUserType.Text = "user";
            this.lblUserType.Click += new System.EventHandler(this.lblUserType_Click);
            // 
            // txtFullName
            // 
            this.txtFullName.BorderColorFocused = System.Drawing.Color.Navy;
            this.txtFullName.BorderColorIdle = System.Drawing.Color.Navy;
            this.txtFullName.BorderColorMouseHover = System.Drawing.Color.Navy;
            this.txtFullName.BorderThickness = 3;
            this.txtFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullName.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFullName.isPassword = false;
            this.txtFullName.Location = new System.Drawing.Point(488, 95);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(427, 36);
            this.txtFullName.TabIndex = 60;
            this.txtFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtAddress
            // 
            this.txtAddress.BorderColorFocused = System.Drawing.Color.Navy;
            this.txtAddress.BorderColorIdle = System.Drawing.Color.Navy;
            this.txtAddress.BorderColorMouseHover = System.Drawing.Color.Navy;
            this.txtAddress.BorderThickness = 3;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddress.isPassword = false;
            this.txtAddress.Location = new System.Drawing.Point(488, 136);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(427, 36);
            this.txtAddress.TabIndex = 61;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.BackColor = System.Drawing.Color.Navy;
            this.dateTimePicker1.BorderRadius = 0;
            this.dateTimePicker1.ForeColor = System.Drawing.Color.White;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePicker1.FormatCustom = null;
            this.dateTimePicker1.Location = new System.Drawing.Point(490, 181);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(427, 49);
            this.dateTimePicker1.TabIndex = 62;
            this.dateTimePicker1.Value = new System.DateTime(2020, 4, 5, 13, 8, 52, 274);
            // 
            // txtParentName
            // 
            this.txtParentName.BorderColorFocused = System.Drawing.Color.Navy;
            this.txtParentName.BorderColorIdle = System.Drawing.Color.Navy;
            this.txtParentName.BorderColorMouseHover = System.Drawing.Color.Navy;
            this.txtParentName.BorderThickness = 3;
            this.txtParentName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtParentName.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtParentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtParentName.isPassword = false;
            this.txtParentName.Location = new System.Drawing.Point(488, 238);
            this.txtParentName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtParentName.Name = "txtParentName";
            this.txtParentName.Size = new System.Drawing.Size(427, 36);
            this.txtParentName.TabIndex = 63;
            this.txtParentName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtTel
            // 
            this.txtTel.BorderColorFocused = System.Drawing.Color.Navy;
            this.txtTel.BorderColorIdle = System.Drawing.Color.Navy;
            this.txtTel.BorderColorMouseHover = System.Drawing.Color.Navy;
            this.txtTel.BorderThickness = 3;
            this.txtTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTel.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTel.isPassword = false;
            this.txtTel.Location = new System.Drawing.Point(488, 280);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(427, 36);
            this.txtTel.TabIndex = 64;
            this.txtTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtusername
            // 
            this.txtusername.BorderColorFocused = System.Drawing.Color.Navy;
            this.txtusername.BorderColorIdle = System.Drawing.Color.Navy;
            this.txtusername.BorderColorMouseHover = System.Drawing.Color.Navy;
            this.txtusername.BorderThickness = 3;
            this.txtusername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtusername.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtusername.isPassword = false;
            this.txtusername.Location = new System.Drawing.Point(488, 323);
            this.txtusername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(427, 36);
            this.txtusername.TabIndex = 65;
            this.txtusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtpassword
            // 
            this.txtpassword.BorderColorFocused = System.Drawing.Color.Navy;
            this.txtpassword.BorderColorIdle = System.Drawing.Color.Navy;
            this.txtpassword.BorderColorMouseHover = System.Drawing.Color.Navy;
            this.txtpassword.BorderThickness = 3;
            this.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpassword.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtpassword.isPassword = true;
            this.txtpassword.Location = new System.Drawing.Point(488, 365);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(427, 36);
            this.txtpassword.TabIndex = 66;
            this.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtrepassword
            // 
            this.txtrepassword.BorderColorFocused = System.Drawing.Color.Navy;
            this.txtrepassword.BorderColorIdle = System.Drawing.Color.Navy;
            this.txtrepassword.BorderColorMouseHover = System.Drawing.Color.Navy;
            this.txtrepassword.BorderThickness = 3;
            this.txtrepassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtrepassword.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtrepassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtrepassword.isPassword = true;
            this.txtrepassword.Location = new System.Drawing.Point(488, 407);
            this.txtrepassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtrepassword.Name = "txtrepassword";
            this.txtrepassword.Size = new System.Drawing.Size(427, 36);
            this.txtrepassword.TabIndex = 67;
            this.txtrepassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnT1
            // 
            this.btnT1.ActiveBorderThickness = 1;
            this.btnT1.ActiveCornerRadius = 20;
            this.btnT1.ActiveFillColor = System.Drawing.Color.Navy;
            this.btnT1.ActiveForecolor = System.Drawing.Color.White;
            this.btnT1.ActiveLineColor = System.Drawing.Color.Navy;
            this.btnT1.BackColor = System.Drawing.SystemColors.Control;
            this.btnT1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnT1.BackgroundImage")));
            this.btnT1.ButtonText = "Zaten Hesabınız Var mı ? ";
            this.btnT1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnT1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnT1.ForeColor = System.Drawing.Color.Navy;
            this.btnT1.IdleBorderThickness = 1;
            this.btnT1.IdleCornerRadius = 20;
            this.btnT1.IdleFillColor = System.Drawing.Color.White;
            this.btnT1.IdleForecolor = System.Drawing.Color.Navy;
            this.btnT1.IdleLineColor = System.Drawing.Color.Navy;
            this.btnT1.Location = new System.Drawing.Point(488, 470);
            this.btnT1.Margin = new System.Windows.Forms.Padding(4);
            this.btnT1.Name = "btnT1";
            this.btnT1.Size = new System.Drawing.Size(250, 33);
            this.btnT1.TabIndex = 72;
            this.btnT1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnT1.Click += new System.EventHandler(this.btnT1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ActiveBorderThickness = 1;
            this.btnAdd.ActiveCornerRadius = 20;
            this.btnAdd.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.ActiveForecolor = System.Drawing.Color.White;
            this.btnAdd.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.ButtonText = "Kayıt Oluştur";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Navy;
            this.btnAdd.IdleBorderThickness = 1;
            this.btnAdd.IdleCornerRadius = 20;
            this.btnAdd.IdleFillColor = System.Drawing.Color.White;
            this.btnAdd.IdleForecolor = System.Drawing.Color.Navy;
            this.btnAdd.IdleLineColor = System.Drawing.Color.Navy;
            this.btnAdd.Location = new System.Drawing.Point(763, 470);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(152, 33);
            this.btnAdd.TabIndex = 73;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Firebrick;
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.ErrorImage = null;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.ImageActive = null;
            this.BtnClose.InitialImage = null;
            this.BtnClose.Location = new System.Drawing.Point(1114, 6);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(22, 22);
            this.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnClose.TabIndex = 75;
            this.BtnClose.TabStop = false;
            this.BtnClose.Zoom = 15;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // ADDstudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.ControlBox = false;
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnT1);
            this.Controls.Add(this.txtrepassword);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtParentName);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelStudentLog);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ADDstudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Sign In";
            this.Load += new System.EventHandler(this.signin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelStudentLog;
        private System.Windows.Forms.Label lblUserType;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtFullName;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtAddress;
        private Bunifu.Framework.UI.BunifuDatepicker dateTimePicker1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtParentName;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTel;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtusername;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtpassword;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtrepassword;
        private Bunifu.Framework.UI.BunifuThinButton2 btnT1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAdd;
        private Bunifu.Framework.UI.BunifuImageButton BtnClose;
        //private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox1;
    }
}