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
using System.IO;

namespace msaccess_linker
{
    public partial class Form1 : Form
    {
        DB clientDB = null;
        DB serverDB = new DB("controlsDB.mdb");
        UI ui = new UI();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "庫存管理系統 " + Info.version + " 版本";
            clientDB = new DB(getDBs()[0]);
            initTabPage2();
            initTabPage1();
        }

        private string[] getDBs()
        {
            DataTable table = serverDB.select("*", "dbs");
            DataRow[] result = table.Select();
            string[] temp = new string[table.Rows.Count];
            for (int i = 0; i < table.Rows.Count; i++)
                temp[i] = result[i].ItemArray[1].ToString();

            return temp;
        }

        private void initTabPage2()
        {
            tableSelectComboBox.SelectedValueChanged -= tableSelectComboBox_SelectedValueChanged; //暫時解除event handler
            tableSelectComboBox.Items.Clear();
            ui.addComboBoxItems(tableSelectComboBox, clientDB.getTables());
            tableSelectComboBox.SelectedValueChanged += tableSelectComboBox_SelectedValueChanged;
        }

        private void initTabPage1()
        {
            connComboBox.SelectedValueChanged -= connComboBox_SelectedValueChanged; //暫時解除event handler
            newTableText.ImeMode = ImeMode.OnHalf;
            newTableText.Focus();
            initNewSchema();
            connComboBox.Items.Clear();
            ui.addComboBoxItems(connComboBox, getDBs());

            connComboBox.Text = clientDB.name();
            DataTable table = new DataTable();
            table.Columns.Add(clientDB.name() + "資料表列表");
            foreach (var row in clientDB.getTables())
                table.Rows.Add(row);

            previewTableGridView.DataSource = table;
            connComboBox.SelectedValueChanged += connComboBox_SelectedValueChanged;
        }

        private void initNewSchema()
        {
            DataTable table = serverDB.select("*", "schemas");
            DataRow[] result = table.Select();
            ComboBoxItem[] schemaComboBoxItems = ui.comboBoxItems(result, 1, 2);
            schemaComboBox.Items.Clear();
            ui.addComboBoxItems(schemaComboBox, schemaComboBoxItems);
        }

        private void addTableBtn_Click(object sender, EventArgs e)
        {
            clientDB.create(newTableText.Text, ((ComboBoxItem)schemaComboBox.SelectedItem).Value.ToString());
            ui.addComboBoxItem(tableSelectComboBox, newTableText.Text);
            MessageBox.Show("資料表已加入");
            clearNewTablePanel();
        }

        private void schemaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            schemaLabel.Text = ((ComboBoxItem)schemaComboBox.SelectedItem).Value.ToString();
        }

        private void addSchemaBtn_Click(object sender, EventArgs e)
        {
            serverDB.insert("schemas", "name, content", "'" + schemaNameText.Text + "', '" + schemaContentText.Text + "'");
            addSchemaComboBox(schemaNameText.Text, schemaContentText.Text);
            MessageBox.Show("模組已加入");
            clearNewSchema();
        }

        public void addSchemaComboBox(string name, string content)
        {
            ui.addComboBoxItem(schemaComboBox, name, content);
        }

        private void clearConn()
        {
            connComboBox.Items.Clear();
            ui.clearDataGridView(previewTableGridView);
        }

        private void clearNewTablePanel()
        {
            newTableText.Text = "";
            schemaComboBox.Text = "";
            schemaLabel.Text = "";
        }

        private void clearNewSchema()
        {
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

        private void importDBBtn_Click(object sender, EventArgs e)
        {
            openAccessDialog.FileName = "";
            if (openAccessDialog.ShowDialog() == DialogResult.OK && openAccessDialog.FileName != null)
            {
                if (File.Exists("./" + openAccessDialog.SafeFileName))
                    File.Delete("./" + openAccessDialog.SafeFileName);

                File.Copy(openAccessDialog.FileName, "./" + openAccessDialog.SafeFileName);
                serverDB.insert("dbs", "name", "'" + openAccessDialog.SafeFileName + "'");
                ui.addComboBoxItem(connComboBox, openAccessDialog.SafeFileName);
            }
        }

        private void exportDBBtn_Click(object sender, EventArgs e)
        {
            saveAccessDialog.FileName = "";
            if (saveAccessDialog.ShowDialog() == DialogResult.OK && saveAccessDialog.FileName != null)
                File.Copy("./" + clientDB.name(), saveAccessDialog.FileName + ".mdb");
        }

        private void connComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            clientDB = new DB(connComboBox.Text);
            initTabPage1();
            initTabPage2();
        }

        private void tableSelectComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            tableGridView.DataSource = clientDB.select("*", tableSelectComboBox.Text);
        }

        private void tableGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataRow row = ui.getDataGridViewCurrentRow(tableGridView);
            string[] columnNames = ui.getDataGridViewColName(tableGridView);
            map[] temp = new map[tableGridView.Columns.Count];
            for (int i = 0; i < tableGridView.Columns.Count; i++)
            {
                temp[i] = new map();
                temp[i].Text = columnNames[i];
                temp[i].Value = row[columnNames[i]].ToString();
            }

            ui.setCurrentEdit(temp);
            ui.dynamicPanel(editPanel, temp);
        }

        private void insertEditBtn_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = ui.findAllTextBox(editPanel);
            map[] current = ui.getCurrentEdit();
            string field = "", value = "";
            int i = 0;
            for (i = 0; i < current.Length - 1; i++)
            {
                field += current[i].Text + ",";
                value += "'" + textBoxes[i].Text + "',";
            }

            field += current[i].Text;
            value += "'" + textBoxes[i].Text + "'";
            clientDB.insert(tableSelectComboBox.Text, field, value);
            tableGridView.DataSource = clientDB.select("*", tableSelectComboBox.Text);
        }

        private void clearEditBtn_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = ui.findAllTextBox(editPanel);
            ui.clearAllTextBoxes(textBoxes);
        }

        private void updateEditBtn_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = ui.findAllTextBox(editPanel);
            map[] current = ui.getCurrentEdit();
            string[] cols = ui.getDataGridViewColName(tableGridView);
            string setting = "";
            int i = 0;
            for (i = 0; i < current.Length - 1; i++)
                setting += "[" + current[i].Text + "]='" + textBoxes[i].Text + "',";

            setting += "[" + current[i].Text + "]='" + textBoxes[i].Text + "'";
            clientDB.update(tableSelectComboBox.Text, setting, "[" + current[0].Text + "]=" + cols[0]);
        }

        private void companyNameTextBox_TextChanged(object sender, EventArgs e)
        {
            bindingFunction();
        }

        private void bindingFunction()
        {
            TextBox[] all = ui.findAllTextBox(selectProductPanel);
            TextBox[] textBoxes = ui.findAllTextBox(selectProductPanel)
                .Where((obj) => obj.Text != "")
                .ToArray(); // 找出所有沒有字的
            map[] queryRule = new map[]
            {
                new map() { Text="廠商", Value="廠商" },
                new map() { Text="天線",Value= "識別碼" },
                new map() { Text="零件", Value="零件編號" }
            };

            if (textBoxes.Length == 0)
                return;
            else if (textBoxes.Length == 1)
            {
                int index = Array.IndexOf(all, textBoxes[0]);
                queryShowGridView.DataSource = clientDB.select("*", queryRule[index].Text, "[" + queryRule[index].Value + "]='" + textBoxes[0].Text + "'");
            }
            else
            {
                
            }
        }

        private void antennaTextBox_TextChanged(object sender, EventArgs e)
        {
            bindingFunction();
        }

        private void componentNumTextBox_TextChanged(object sender, EventArgs e)
        {
            bindingFunction();
        }
    }
}
