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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable table = serverDB.select("*", "schemas");
            DataRow[] result = table.Select();

            foreach (DataRow row in result)
            {
                ComboBoxItem temp = new ComboBoxItem();
                temp.Text = row[1].ToString();
                temp.Value = row[2].ToString();
                schemaComboBox.Items.Add(temp);
            }
        }

        private void addTableBtn_Click(object sender, EventArgs e)
        {
            clientDB.create(newTableText.Text, ((ComboBoxItem)schemaComboBox.SelectedItem).Value.ToString());
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
            ComboBoxItem temp = new ComboBoxItem();
            temp.Text = schemaNameText.Text;
            temp.Value = schemaContentText.Text;
            schemaComboBox.Items.Add(temp);

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
    }
}
