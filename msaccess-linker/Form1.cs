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
            DataTable table = serverDB.select("*", "schemas");
            DataRow[] result = table.Select();
            ComboBoxItem[] schemaComboBoxItems = ui.comboBoxItems(result, 1, 2);
            ui.addComboBoxItems(schemaComboBox, schemaComboBoxItems);
            ui.addComboBoxItems(tableSelectComboBox, clientDB.getTables());
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

        private void tableSelectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    class UI
    {
        public ComboBoxItem[] comboBoxItems(DataRow[] array, int textIndex, int valueIndex)
        {
            ComboBoxItem[] temp = new ComboBoxItem[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                DataRow row = array[i];
                temp[i] = new ComboBoxItem();
                temp[i].Text = row[textIndex].ToString();
                temp[i].Value = row[valueIndex];
            }

            return temp;
        }

        public void addComboBoxItems(ComboBox comboBox, string[] array)
        {
            foreach (var item in array)
            {
                comboBox.Items.Add(item);
            }
        }

        public void addComboBoxItems(ComboBox comboBox, ComboBoxItem[] comboBoxItems)
        {
            foreach (var item in comboBoxItems)
            {
                comboBox.Items.Add(item);
            }
        }

        public void addComboBoxItem(ComboBox comboBox, string text)
        {
            comboBox.Items.Add(text);
        }

        public void addComboBoxItem(ComboBox comboBox, string text, object value)
        {
            ComboBoxItem temp = new ComboBoxItem();
            temp.Text = text;
            temp.Value = value;
            comboBox.Items.Add(temp);
        }
    }
}
