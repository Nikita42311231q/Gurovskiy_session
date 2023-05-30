using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sessia1Gurovskiy
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void tovar_importBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tovar_importBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sessionDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sessionDataSet2._Tovars_import_". При необходимости она может быть перемещена или удалена.
            this.tovars_import_TableAdapter.Fill(this.sessionDataSet2._Tovars_import_);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }
    }
}
