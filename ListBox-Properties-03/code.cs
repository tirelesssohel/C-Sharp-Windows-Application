using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkWithListBox_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            listBox.Items.Add(textBox.Text);

            textBox.Clear();
            textBox.Focus();
        }

        private void buttoncount_Click(object sender, EventArgs e)
        {
            int ctr = listBox.Items.Count;
            MessageBox.Show("Total Items = " + ctr);
        }

        private void buttonsort_Click(object sender, EventArgs e)
        {
            listBox.Sorted = true;
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            listBox.Items.Remove(listBox.SelectedItem);
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }
    }
}
