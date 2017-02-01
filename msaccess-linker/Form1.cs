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
        DB db = new DB("myTestingDB.mdb");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addTableBtn_Click(object sender, EventArgs e)
        {
            db.create(tableNameText.Text, schemaText.Text);
        }
    }
}
