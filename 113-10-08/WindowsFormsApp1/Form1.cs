﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lblShow.Text = "芬蘭";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            lblShow.Text = "法國";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            lblShow.Text = "德國";
        }
    }
}
