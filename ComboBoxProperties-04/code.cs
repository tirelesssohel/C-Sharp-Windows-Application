using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBoxProperties_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                comboBox1.Items.Add(textBox1.Text);

                textBox1.Clear();
                textBox1.Focus();

                MessageBox.Show("Departement Added Successfully!");
            }
            else
            {
                MessageBox.Show("Invalid Department");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Remove(comboBox1.SelectedItem);

            MessageBox.Show("Item Removed");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int count = comboBox1.Items.Count;

            MessageBox.Show("Number of Items: " + count);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Sorted = true;

            MessageBox.Show("Combobox Sorted");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();

            MessageBox.Show("Combobox Cleared");
        }
    }
}
