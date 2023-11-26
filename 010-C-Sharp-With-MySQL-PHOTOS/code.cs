using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace SecondTaskCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection conn = new MySqlConnection("datasource = localhost; port = 3306; Initial Catalog = 'secondtask'; username = root; password =");
        MySqlCommand cmd;


        public void FillDgv(int x)
        {
            MySqlCommand cmd1 = new MySqlCommand("select * from employee where id = @x", conn);
            cmd1.Parameters.Add("@x", MySqlDbType.Int32, 2);
            cmd1.Parameters["@x"].Value = x;

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd1);
            DataTable table = new DataTable();
            adapter.Fill(table);

            dataGridView1.RowTemplate.Height = 120;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.DataSource = table;

            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)dataGridView1.Columns[2];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void browsebtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image (*.JPG; *.PNG; *.GIF) | *.gif; *.png; *.jpg";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();

            String qry = "insert into secondtask.employee(id, name, image) values (@id, @name, @img)";
            conn.Open();

            cmd = new MySqlCommand(qry, conn);
            cmd.Parameters.Add("@id", MySqlDbType.Int32, 2);
            cmd.Parameters.Add("@name", MySqlDbType.VarChar, 15);
            cmd.Parameters.Add("@img", MySqlDbType.Blob);

            cmd.Parameters["@id"].Value = textBoxId.Text;
            cmd.Parameters["@name"].Value = textBoxName.Text;
            cmd.Parameters["@img"].Value = img;

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Data Inserted Successfully!");
            }

            conn.Close();
        }

        int a = 1;

        private void Form1_Load(object sender, EventArgs e)
        {
            FillDgv(a);
        }

        private void prevbtn_Click(object sender, EventArgs e)
        {
            if(a > 1)
            {
                a--;
                FillDgv(a);
            }
            
        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            a++;
            FillDgv(a);
        }
    }
}
