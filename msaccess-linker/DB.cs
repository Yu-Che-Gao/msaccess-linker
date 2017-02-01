using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace msaccess_linker
{
    class DB
    {
        OleDbConnection conn = new OleDbConnection();
        string db = "";
        public DB(string database)
        {
            string connStr = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + database);
            db = database;
            conn.ConnectionString = connStr;
            conn.Open();
        }

        public DataTable select(string field, string tableName, string condition)
        {
            DataTable table = new DataTable();
            string sql = "SELECT " + field + " FROM " + tableName + " WHERE " + condition;
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, conn);
            DataSet dataSet = new DataSet();
            dataSet.Clear();
            adapter.Fill(dataSet);
            table = dataSet.Tables[0];
            return table;
        }

        public void create(string tableName, string schema)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "CREATE TABLE " + tableName + "(" + schema + ")";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
    }
}
