using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;

namespace Проект
{

    public partial class Main : Form
    {
        public static double total = 0, change;
        public Main()
        {
            InitializeComponent();


            



        }

        


        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            
            
              

            
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            

            if (rbHotCoffee.Checked == true)
            {
               
                
                


                if (rbHotCoffee.Checked == true)
                {
                    
                    richTextBox1.Text = richTextBox1.Text + "\nSmall Hot Coffee - 1.50" ;
                    total = total + 1.50;
                    tbSum.Text = total.ToString();
                }
                else if (rbMedium.Checked == true)
                {
                    
                    richTextBox1.Text = richTextBox1.Text + "\nMedium Hot Coffee - 2" ;
                    total = total + 2;
                    tbSum.Text = total.ToString();
                }
                else
                {
                    
                    richTextBox1.Text = richTextBox1.Text + "\nMedium Hot Coffee - 3.50";
                    total = total + 3.50;
                    tbSum.Text = total.ToString();

                }
                
                
            }
            else if (rbIceCoffee.Checked == true)
            {
                if (rbSmall.Checked == true)
                {
                    
                    richTextBox1.Text = richTextBox1.Text + "\nMedium Hot Coffee - 2.50";
                    total = total + 2.50;
                    tbSum.Text = total.ToString();

                }
                else if (rbMedium.Checked == true)
                {
                    
                    richTextBox1.Text = richTextBox1.Text + "\nMedium Hot Coffee - 3.50";
                    total = total + 3.50;
                    tbSum.Text = total.ToString();
                }
                else
                {
                    
                    richTextBox1.Text = richTextBox1.Text + "\nMedium Hot Coffee - 4";
                    total = total + 4;
                    tbSum.Text = total.ToString();
                }

               
            }

        }

            private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            tbTotal.Text = tbSum.Text + "лв.";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (rbHotCoffee.Checked == true)
            {





                

                    richTextBox1.Text = richTextBox1.Text + "\nSmall Hot Coffee - 1.50";
                    total = total + 1.50;
                    tbSum.Text = total.ToString();
                
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            tbSum.Clear();
            total = 0;
            tbTotal.Clear();
            rbHotCoffee.Checked = false;
            rbIceCoffee.Checked = false;
            rbSmall.Checked= false;
            rbMedium.Checked = false;
            rbLarge.Checked= false;
        }
    }
}
