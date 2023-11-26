using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxFirstNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonreset_Click(object sender, EventArgs e)
        {
                   
            textBoxFirstNumber.Clear();
            textBoxSecondNumber.Clear();
            textBoxResult.Clear();

            textBoxFirstNumber.Focus();

        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            if(textBoxFirstNumber.Text != "" && textBoxSecondNumber.Text != "")
            {
                int num1 = int.Parse(textBoxFirstNumber.Text);
                int num2 = int.Parse(textBoxSecondNumber.Text);

                textBoxResult.Text = (num1 + num2).ToString();
            }
            else
            {
                MessageBox.Show("Fill all required fields");
            }
        }

        private void buttonsub_Click(object sender, EventArgs e)
        {
            if (textBoxFirstNumber.Text != "" && textBoxSecondNumber.Text != "")
            {
                int num1 = int.Parse(textBoxFirstNumber.Text);
                int num2 = int.Parse(textBoxSecondNumber.Text);

                textBoxResult.Text = (num1 - num2).ToString();
            }
            else
            {
                MessageBox.Show("Fill all required fields");
            }
        }

        private void buttonrem_Click(object sender, EventArgs e)
        {
            if (textBoxFirstNumber.Text != "" && textBoxSecondNumber.Text != "")
            {
                int num1 = int.Parse(textBoxFirstNumber.Text);
                int num2 = int.Parse(textBoxSecondNumber.Text);

                textBoxResult.Text = (num1 % num2).ToString();
            }
            else
            {
                MessageBox.Show("Fill all required fields");
            }
        }

        private void buttonmul_Click(object sender, EventArgs e)
        {
            if (textBoxFirstNumber.Text != "" && textBoxSecondNumber.Text != "")
            {
                int num1 = int.Parse(textBoxFirstNumber.Text);
                int num2 = int.Parse(textBoxSecondNumber.Text);

                textBoxResult.Text = (num1 * num2).ToString();
            }
            else
            {
                MessageBox.Show("Fill all required fields");
            }
        }

        private void buttondiv_Click_1(object sender, EventArgs e)
        {
            if (textBoxFirstNumber.Text != "" && textBoxSecondNumber.Text != "")
            {
                int num1 = int.Parse(textBoxFirstNumber.Text);
                int num2 = int.Parse(textBoxSecondNumber.Text);

                textBoxResult.Text = (num1 / num2).ToString();
            }
            else
            {
                MessageBox.Show("Fill all required fields");
            }
        }
    }
}
