using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace msaccess_linker
{
    public partial class SchemaManagePage : Form
    {
        DB serverDB = new DB("controlsDB.mdb");
        public SchemaManagePage()
        {
            InitializeComponent();
        }

        private void SchemaManagePage_Load(object sender, EventArgs e)
        {
            DataTable table = serverDB.select("*", "schemas");
            object[] temp = { "", "" };

            foreach (DataRow row in table.Rows)
            {
                schemaListBox.Items.Add(row[1].ToString() + " : " + row[2].ToString());
            }

            dataGridView1.Columns.Add("column2", "欄位名稱");
            dataGridView1.Columns.Add("column3", "資料型態");
        }

        private DataGridViewComboBoxCell createComboBoxCell()
        {
            DataGridViewComboBoxCell cell = new DataGridViewComboBoxCell();
            string[] array = { "文字", "數值" };
            cell.DataSource = array;
            return cell;
        }

        private void AddFieldBtn_Click(object sender, EventArgs e)
        {
            object[] temp = { fieldNameTextBox.Text, "" };
            dataGridView1.Rows.Add(temp);
            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1] = createComboBoxCell();
        }
    }

}
