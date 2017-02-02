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
        UI ui = new UI();
        public SchemaManagePage()
        {
            InitializeComponent();
        }

        private void SchemaManagePage_Load(object sender, EventArgs e)
        {
            this.ImeMode = System.Windows.Forms.ImeMode.OnHalf;
            initDataGridView();
            InitListBox();
        }

        private void InitListBox()
        {
            DataTable table = serverDB.select("*", "schemas");
            foreach (DataRow row in table.Rows)
                schemaListBox.Items.Add(row[1].ToString() + " : " + row[2].ToString());
        }

        private void initDataGridView()
        {
            ui.clearDataGridView(dataGridView1);
            dataGridView1.Columns.Add("column2", "欄位名稱");
            dataGridView1.Columns.Add("column3", "資料型態");
        }

        private DataGridViewComboBoxCell createComboBoxCell()
        {
            DataGridViewComboBoxCell cell = new DataGridViewComboBoxCell();
            cell.DataSource = new string[] { "文字", "數值" };
            return cell;
        }

        private void AddFieldBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(new object[] { fieldNameTextBox.Text, "" });
            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1] = createComboBoxCell();
            fieldNameTextBox.Text = "";
        }

        private void left2RightBtn_Click(object sender, EventArgs e)
        {
            string name = schemaNameTextBox.Text;
            string[] fieldName = ui.getDataGridView(dataGridView1, "column2");
            string[] fieldType = ui.getDataGridView(dataGridView1, "column3");
            string content = "";
            for (int i = 0; i < fieldName.Length - 1; i++)
                content += fieldName[i] + "[" + Info.mapToValue(fieldType[i]) + "], ";

            content += fieldName[fieldName.Length - 1] + "[" + Info.mapToValue(fieldType[fieldName.Length - 1]) + "]";
            serverDB.insert("schemas", "name, content", "'" + name + "', '" + content + "'");
            schemaListBox.Items.Add(name + ": " + content);

            schemaNameTextBox.Text = "";
            initDataGridView();
        }
    }
}
