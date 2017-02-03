using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTypeExtension;

namespace msaccess_linker
{
    public class UI
    {
        private List<map> currentEdit = new List<map>();
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
                comboBox.Items.Add(item);
        }

        public void addComboBoxItems(ComboBox comboBox, ComboBoxItem[] comboBoxItems)
        {
            foreach (var item in comboBoxItems)
                comboBox.Items.Add(item);
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

        public string[] getDataGridView(DataGridView dataGridView, string columnName)
        {
            string[] array = new string[dataGridView.Rows.Count];
            for (int i = 0; i < dataGridView.Rows.Count; i++)
                array[i] = dataGridView.Rows[i].Cells[columnName].Value.ToString();

            return array;
        }

        public void clearDataGridView(DataGridView dataGridView)
        {
            dataGridView.DataSource = null;
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
        }

        public TextBox[] findAllTextBox(Control ctr)
        {
            List<TextBox> temp = new List<TextBox>();
            foreach (Control x in ctr.Controls)
                if (x is TextBox) temp.Add((TextBox)x);

            return temp.ToArray();
        }

        public void clearAllTextBoxes(TextBox[] textBoxes)
        {
            foreach (var textBox in textBoxes)
                textBox.Text = "";
        }

        public void dynamicPanel(FlowLayoutPanel panel, map[] array)
        {
            panel.Controls.Clear();
            foreach (var row in array)
            {
                var index = Array.IndexOf(array, row);
                Label label = new Label();
                TextBox textBox = new TextBox();
                label.Name = "label" + index;
                label.Text = row.Text;
                textBox.Text = row.Value.ToString();
                textBox.Name = "textBox" + index;
                panel.Controls.Add(label);
                panel.Controls.Add(textBox);
                panel.SetFlowBreak(textBox, true);
            }
        }

        public string[] getDataGridViewColName(DataGridView view)
        {
            string[] cols = ((DataTable)view.DataSource).Columns
                .Cast<DataColumn>()
                .Select(x => x.ColumnName)
                .ToArray();

            return cols;
        }

        public DataRow getDataGridViewCurrentRow(DataGridView view)
        {
            DataRowView current = (DataRowView)view.CurrentRow.DataBoundItem;
            DataRow row = current.Row;
            return row;
        }

        public void setCurrentEdit(map[] data)
        {
            currentEdit.Clear();
            currentEdit.AddRange(data);
        }

        public map[] getCurrentEdit()
        {
            return currentEdit.ToArray();
        }
    }
}
