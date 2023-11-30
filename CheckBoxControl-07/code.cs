using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBoxControl_07
{
    public partial class Form1 : Form
    {
        string text1 = "";
        string text2 = "";
        string text3 = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)          // CheckedChanged by double clicking each checkbox is must
        {
            if(checkBox1.Checked == true)
            {
                text1 = checkBox1.Text;
            }
            else
            {
                text1 = "";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)         // CheckedChanged by double clicking each checkbox is must
        {
            if(checkBox2.Checked == true)
            {
                text2 = checkBox2.Text;
            }
            else
            {
                text2 = "";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)          // CheckedChanged by double clicking each checkbox is must
        {
            if(checkBox3.Checked == true)
            {
                text3 = checkBox3.Text;
            }
            else
            {
                text3 = "";
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Dept: " + text1 + " " + text2 + " " + text3);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            buttonAgree.Enabled = checkBox4.Checked;
        }
    }
}
