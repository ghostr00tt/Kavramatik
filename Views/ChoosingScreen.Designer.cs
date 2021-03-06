namespace Kavramatik.cs
{
    partial class ChoosingScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoosingScreen));
            this.buttonEducation = new System.Windows.Forms.Button();
            this.buttonGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonEducation
            // 
            this.buttonEducation.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonEducation.BackgroundImage = global::Kavramatik.cs.Resource1.aa31;
            this.buttonEducation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEducation.Location = new System.Drawing.Point(394, 118);
            this.buttonEducation.Name = "buttonEducation";
            this.buttonEducation.Size = new System.Drawing.Size(405, 331);
            this.buttonEducation.TabIndex = 1;
            this.buttonEducation.UseVisualStyleBackColor = false;
            this.buttonEducation.Click += new System.EventHandler(this.buttonEducation_Click);
            // 
            // buttonGame
            // 
            this.buttonGame.BackgroundImage = global::Kavramatik.cs.Resource1.aaa123;
            this.buttonGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGame.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonGame.Location = new System.Drawing.Point(-6, 118);
            this.buttonGame.Name = "buttonGame";
            this.buttonGame.Size = new System.Drawing.Size(394, 331);
            this.buttonGame.TabIndex = 0;
            this.buttonGame.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonGame.UseVisualStyleBackColor = true;
            this.buttonGame.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.label1.Location = new System.Drawing.Point(143, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "OYUN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.label2.Location = new System.Drawing.Point(554, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "EĞİTİM";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(624, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ChoosingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kavramatik.cs.Resource1.web1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEducation);
            this.Controls.Add(this.buttonGame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChoosingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seçim Ekranı";
            this.Load += new System.EventHandler(this.ChoosingScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGame;
        private System.Windows.Forms.Button buttonEducation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBox1;
    }
}