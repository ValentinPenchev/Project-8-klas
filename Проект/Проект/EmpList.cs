using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Проект
{
    public partial class EmpList : Form
    {
        public EmpList()
        {
            InitializeComponent();
        }
        private void EmpList_Load(object sender, EventArgs e)
        {
            //radioButton1.Checked = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "1.50";
            label1.Visible= true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "2.50";
            label1.Visible = true;
        }
    }
}
