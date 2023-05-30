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
    public partial class Form2 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAB206_5\SQLEXPRESS; Initial catalog=User; Trusted_Connection=true;");
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sessionDataSet2._Tovars_import_". При необходимости она может быть перемещена или удалена.
            this.tovars_import_TableAdapter.Fill(this.sessionDataSet2._Tovars_import_);



        }

        private void tovar_importBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tovar_importBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sessionDataSet);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {



            SqlConnection sql_conn = new SqlConnection();
            string sqlquery = "select * from [dbo].[Tovars_import$] where [Стоимость] '" + textBox1.Text + "%'";
            sql_conn.Open(); // открыть соединение
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sql_conn);
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            
            sql_conn.Close();
        }
    }
}


