namespace sampleframe.cs
{
    partial class GameAlphabet
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
            this.Next = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextChar = new System.Windows.Forms.Label();
            this.Prev = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.audio = new System.Windows.Forms.CheckBox();
            this.blackboard = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.Digit = new System.Windows.Forms.Button();
            this.Alphabet = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.Color.Thistle;
            this.Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next.Location = new System.Drawing.Point(339, 250);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 38);
            this.Next.TabIndex = 2;
            this.Next.Text = "Sonraki";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.TextChar);
            this.panel1.Controls.Add(this.Next);
            this.panel1.Controls.Add(this.Prev);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 345);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // TextChar
            // 
            this.TextChar.AutoSize = true;
            this.TextChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextChar.Location = new System.Drawing.Point(66, 60);
            this.TextChar.Name = "TextChar";
            this.TextChar.Size = new System.Drawing.Size(109, 108);
            this.TextChar.TabIndex = 3;
            this.TextChar.Text = "A";
            this.TextChar.Click += new System.EventHandler(this.TextChar_Click);
            // 
            // Prev
            // 
            this.Prev.BackColor = System.Drawing.Color.PaleVioletRed;
            this.Prev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prev.Location = new System.Drawing.Point(66, 250);
            this.Prev.Name = "Prev";
            this.Prev.Size = new System.Drawing.Size(75, 38);
            this.Prev.TabIndex = 1;
            this.Prev.Text = "Önceki";
            this.Prev.UseVisualStyleBackColor = false;
            this.Prev.Click += new System.EventHandler(this.Prev_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(226, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 222);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // audio
            // 
            this.audio.AutoSize = true;
            this.audio.Location = new System.Drawing.Point(664, 316);
            this.audio.Name = "audio";
            this.audio.Size = new System.Drawing.Size(44, 17);
            this.audio.TabIndex = 14;
            this.audio.Text = "Ses";
            this.audio.UseVisualStyleBackColor = true;
            this.audio.CheckedChanged += new System.EventHandler(this.audio_CheckedChanged);
            // 
            // blackboard
            // 
            this.blackboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.blackboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blackboard.Location = new System.Drawing.Point(507, 382);
            this.blackboard.Name = "blackboard";
            this.blackboard.Size = new System.Drawing.Size(96, 43);
            this.blackboard.TabIndex = 13;
            this.blackboard.Text = "Çizim Alanı";
            this.blackboard.UseVisualStyleBackColor = false;
            this.blackboard.Click += new System.EventHandler(this.blackboard_Click);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.RosyBrown;
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Location = new System.Drawing.Point(175, 382);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(75, 43);
            this.logout.TabIndex = 12;
            this.logout.Text = "Çıkış";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // Digit
            // 
            this.Digit.BackColor = System.Drawing.Color.Yellow;
            this.Digit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Digit.Location = new System.Drawing.Point(646, 86);
            this.Digit.Name = "Digit";
            this.Digit.Size = new System.Drawing.Size(75, 43);
            this.Digit.TabIndex = 11;
            this.Digit.Text = "Rakamlar";
            this.Digit.UseVisualStyleBackColor = false;
            this.Digit.Click += new System.EventHandler(this.Digit_Click);
            // 
            // Alphabet
            // 
            this.Alphabet.BackColor = System.Drawing.SystemColors.Highlight;
            this.Alphabet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alphabet.Location = new System.Drawing.Point(646, 26);
            this.Alphabet.Name = "Alphabet";
            this.Alphabet.Size = new System.Drawing.Size(75, 39);
            this.Alphabet.TabIndex = 10;
            this.Alphabet.Text = "Alfabe";
            this.Alphabet.UseVisualStyleBackColor = false;
            this.Alphabet.Click += new System.EventHandler(this.Alphabet_Click);
            // 
            // GameAlphabet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::sampleframe.cs.Resource1.lightbackgorund;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.audio);
            this.Controls.Add(this.blackboard);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.Digit);
            this.Controls.Add(this.Alphabet);
            this.Name = "GameAlphabet";
            this.Text = "GameAlphabet";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TextChar;
        private System.Windows.Forms.Button Prev;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox audio;
        private System.Windows.Forms.Button blackboard;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button Digit;
        private System.Windows.Forms.Button Alphabet;
    }
}