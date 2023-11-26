using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakingInputAndShowOutput_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            textBoxAge.Clear();

            textBoxName.Focus();
        }

        private void setbtn_Click(object sender, EventArgs e)
        {
            textBoxShowName.Text = textBoxName.Text;
            textBoxShowAge.Text = textBoxAge.Text;
            
            nameLabel.Text = textBoxName.Text;
            ageLabel.Text = textBoxAge.Text;
        }
    }
}
