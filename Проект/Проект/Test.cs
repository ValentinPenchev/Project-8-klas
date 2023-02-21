using Microsoft.Office.Interop.Outlook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Проект
{
    public partial class Test : Form
    {
        public static double total = 0;
        public Test()
        {
            InitializeComponent();
        }

        DataTable table = new DataTable();
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Test_Load(object sender, EventArgs e)
        {

            table.Columns.Add("Заглавие",typeof(string));
            table.Rows.Add("Hari Potter");
            table.Columns.Add("Жанр", typeof(string));
            table.Rows.Add("Test");
            table.Columns.Add("Цена", typeof(string));
            table.Rows.Add("Hari Potter");


            dataGridView1.DataSource = table;




        }

        private void button1_Click(object sender, EventArgs e)
        {
               
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

           


        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnAddData_Click(object sender, EventArgs e)
        {
            // Get the search query from the TextBox
            string searchQuery = TBTitle.Text.ToLower();

            // Clear the DataGridView selection
            dataGridView1.ClearSelection();

            // Loop through the rows in the DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool matchFound = false;

                // Loop through the cells in the current row
                foreach (DataGridViewCell cell in row.Cells)
                {
                    // Get the cell value as a string
                    string cellValue = cell.Value.ToString().ToLower();

                    // Check if the cell value matches the search query
                    if (cellValue.Contains(searchQuery))
                    {
                        // If a match is found, make the row visible and set matchFound to true
                        row.Visible = true;
                        matchFound = true;
                        break;
                    }
                }

                // If no match is found, make the row hidden
                if (!matchFound)
                {
                    row.Visible = false;
                }
            }
        }
    }
}
