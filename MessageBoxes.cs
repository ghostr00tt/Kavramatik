﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sampleframe.cs
{
    public partial class MessageBox : Form
    {
        public MessageBox(string msg, MsgType type)
        {
            InitializeComponent();
            massageCon.Text = msg;
            switch (type)
            {
                case MsgType.success:
                    this.BackColor = Color.Navy;
                    icon.Image = imageList1.Images[0];
                    break;
                case MsgType.retry:
                    this.BackColor = Color.Teal;
                    icon.Image = imageList1.Images[3];
                    break;
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public enum MsgType
        {
            success, retry
        }

        private void massageCon_Click(object sender, EventArgs e)
        {

        }
    }
}
