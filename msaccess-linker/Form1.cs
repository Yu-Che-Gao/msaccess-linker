using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTypeExtension;

namespace msaccess_linker
{
    public partial class Form1 : Form
    {
        DB clientDB = new DB("myTestingDB.mdb");
        DB serverDB = new DB("controlsDB.mdb");
        UI ui = new UI();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "庫存管理系統 " + Info.version + " 版本";
            this.ImeMode = System.Windows.Forms.ImeMode.OnHalf;
            DataTable table = serverDB.select("*", "schemas");
            DataRow[] result = table.Select();
            ComboBoxItem[] schemaComboBoxItems = ui.comboBoxItems(result, 1, 2);
            ui.addComboBoxItems(schemaComboBox, schemaComboBoxItems);
            ui.addComboBoxItems(tableSelectComboBox, clientDB.getTables());
            initTabPage1();
        }

        private void initTabPage1()
        {
            ui.addComboBoxItem(connComboBox, clientDB.name());
            connComboBox.Text = clientDB.name();
            DataTable table = new DataTable();
            table.Columns.Add(clientDB.name() + "資料表列表");
            foreach (var row in clientDB.getTables())
                table.Rows.Add(row);

            previewTableGridView.DataSource = table;
        }

        private void addTableBtn_Click(object sender, EventArgs e)
        {
            clientDB.create(newTableText.Text, ((ComboBoxItem)schemaComboBox.SelectedItem).Value.ToString());
            ui.addComboBoxItem(tableSelectComboBox, newTableText.Text);
            MessageBox.Show("資料表已加入");
            newTableText.Text = "";
            schemaComboBox.Text = "";
            schemaLabel.Text = "";
        }

        private void schemaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            schemaLabel.Text = ((ComboBoxItem)schemaComboBox.SelectedItem).Value.ToString();
        }

        private void tableSelectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable table = clientDB.select("*", tableSelectComboBox.Text);
            tableGridView.DataSource = table;
        }

        private void addSchemaBtn_Click(object sender, EventArgs e)
        {
            serverDB.insert("schemas", "name, content", "'" + schemaNameText.Text + "', '" + schemaContentText.Text + "'");
            ui.addComboBoxItem(schemaComboBox, schemaNameText.Text, schemaContentText.Text);

            MessageBox.Show("模組已加入");
            schemaNameText.Text = "";
            schemaContentText.Text = "";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Text = "關閉中...";
            clientDB.close();
            serverDB.close();
        }

        private void schemaPageOpenBtn_Click(object sender, EventArgs e)
        {
            SchemaManagePage form = new SchemaManagePage();
            form.Show();
        }
    }
}
