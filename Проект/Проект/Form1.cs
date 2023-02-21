using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Проект
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /*if (tbUsername.Text == "admin" && tbPassword.Text == "pass")
            {
               
            }*/
            MessageBox.Show("Добре дошли");

            this.Hide();
             EmpList f2 = new EmpList(); //this is the change, code for redirect  
            f2.ShowDialog();
            // Employee f2 = new Employee(); //this is the change, code for redirect  
            // f2.ShowDialog();

        }
    }
}
