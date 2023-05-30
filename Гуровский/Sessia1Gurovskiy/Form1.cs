using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sessia1Gurovskiy
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAB206_5\SQLEXPRESS; Initial catalog=user; Trusted_Connection=true;");
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            {
                if (textBox1.Text == "" && textBox2.Text == "")
                {
                    Form2 f = new Form2();
                    f.Show();
                    this.Hide();
                    MessageBox.Show("Добро пожаловать в магазин концелярии!");
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль", "Ошибка");
                    {
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
            this.Hide();
        }
    }
}
