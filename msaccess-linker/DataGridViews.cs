using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace msaccess_linker
{
    class DataGridViews
    {
        public DataGridView[] newManyDataGridViews(int numbers)
        {
            DataGridView[] dataGridView = new DataGridView[numbers];
            for(int i=0; i<numbers; i++)
            {
                dataGridView[i] = new DataGridView();
            }

            return dataGridView;
        }
    }
}
