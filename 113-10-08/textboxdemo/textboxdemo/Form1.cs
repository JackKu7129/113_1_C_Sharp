using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textboxdemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string fullName;
            string firstName;
            string lastName;

            firstName=txtFirstName.Text;
            lastName=txtLastName.Text;
            fullName = lastName + "" + firstName;

            lblShow.Text= fullName;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            string fullName;//變數一定要先宣告型態後，才可以使用
            string firstName;
            string lastName;

            firstName = txtFirstName.Text;
            lastName = txtLastName.Text;
            fullName = lastName + "" + firstName;

            lblShow.Text = fullName;
        }
    }
}
