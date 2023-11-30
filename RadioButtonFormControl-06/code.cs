using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtonControl_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                MessageBox.Show("Country Name: " + radioButton1.Text);
            }else if(radioButton2.Checked == true)
            {
                MessageBox.Show("Country Name: "+ radioButton2.Text);
            }
            else if (radioButton3.Checked == true)
            {
                MessageBox.Show("Country Name: " + radioButton3.Text);
            }
            else
            {
                MessageBox.Show("Country Name: " + radioButton4.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(radioButton5.Checked == true){
                groupBoxColor.BackColor = Color.Red;

            }else if(radioButton6.Checked == true){
                groupBoxColor.BackColor = Color.Green;

            }else if (radioButton7.Checked == true){
                groupBoxColor.BackColor = Color.Pink;

            }else {
                groupBoxColor.BackColor = Color.Blue;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(radioButton9.Checked == true)
            {
                this.BackColor = System.Drawing.Color.Pink;
            }
            else
            {
                this.BackColor = System.Drawing.Color.Indigo;
            }
        }
    }
}
