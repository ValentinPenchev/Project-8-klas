using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Проект
{
    public partial class Employee : Form
    {
        public static double total = 0;



        public Employee()
        {
            InitializeComponent();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main f2 = new Main(); //this is the change, code for redirect  
            f2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "София")
            {
                if (comboBox2.Text == "Пловдив")
                {
                    total = total + 35;
                    //richTextBox1.Text = total.ToString();
                }
                else if (comboBox2.Text == "Варна")
                {
                    total = total + 50;
                    //richTextBox1.Text = total.ToString();
                }
                else if (comboBox2.Text == "Бургас")
                {
                    total = total + 50;
                    //richTextBox1.Text = total.ToString();
                }

            }

            else if (comboBox1.Text == "Пловдив")
            {
                if (comboBox2.Text == "София")
                {
                    total = total + 35;
                    //richTextBox1.Text = total.ToString();
                }
                else if (comboBox2.Text == "Варна")
                {
                    total = total + 45;
                    //richTextBox1.Text = total.ToString();
                }
                else if (comboBox2.Text == "Бургас")
                {
                    total = total + 40;
                    //richTextBox1.Text = total.ToString();
                }
            }
            else if (comboBox1.Text == "Варна")
            {
                if (comboBox2.Text == "София")
                {
                    total = total + 35;
                    //richTextBox1.Text = total.ToString();
                }
                else if (comboBox2.Text == "Пловдив")
                {
                    total = total + 100;
                    //richTextBox1.Text = total.ToString();
                }
                else if (comboBox2.Text == "Бургас")
                {
                    total = total + 150;
                    //richTextBox1.Text = total.ToString();
                }

            }
            else if (comboBox1.Text == "Бургас")
            {
                if (comboBox2.Text == "София")
                {
                    total = total + 35;
                    //richTextBox1.Text = total.ToString();
                }
                else if (comboBox2.Text == "Варна")
                {
                    total = total + 80;
                    //richTextBox1.Text = total.ToString();
                }
                else if (comboBox2.Text == "Пловдив")
                {
                    total = total + 75;
                    //richTextBox1.Text = total.ToString();
                }

               
            }

            richTextBox1.Text = "Име: " + textBox1.Text + "\nАдрес: " + textBox2.Text + "\nТелефон: " + textBox3.Text + "\nДестинация: " +
               "\nОт: " + comboBox1.Text + " До: " + comboBox2.Text + "\nЦена: " + total + " лв.";

            if (comboBox1.Text == comboBox2.Text)
            {
                richTextBox1.Text = "Грешни данни";
            }

            
            
        }

    


        private void lblData_Click(object sender, EventArgs e)
        {
            

        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.ResetText();
            comboBox2.ResetText();
            richTextBox1.Clear();
            total= 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

