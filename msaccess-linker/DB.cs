using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace msaccess_linker
{
    public class DB
    {
        OleDbConnection conn = new OleDbConnection();
        private string db = "";
        public DB(string database)
        {
            string connStr = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + database);
            db = database;
            conn.ConnectionString = connStr;
            conn.Open();
        }

        public string[] getTables()
        {
            DataTable table = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
            string[] array = new string[table.Rows.Count];
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];
                array[i] = row.ItemArray[2].ToString();
            }
            return array;
        }

        public DataTable select(string field, string tableName)
        {
            DataTable table = new DataTable();
            string sql = "SELECT " + field + " FROM " + tableName;
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, conn);
            DataSet dataSet = new DataSet();
            dataSet.Clear();
            adapter.Fill(dataSet);
            table = dataSet.Tables[0];
            return table;
        }

        public DataTable select(string field, string tableName, string condition)
        {
            string sql = "SELECT " + field + " FROM " + tableName + " WHERE " + condition;
            DataTable table = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, conn);
            DataSet dataSet = new DataSet();
            dataSet.Clear();
            adapter.Fill(dataSet);
            table = dataSet.Tables[0];
            return table;
        }

        public void insert(string tableName, string field, string value)
        {
            string sql = "INSERT INTO " + tableName + "(" + field + ") VALUES (" + value + ")";
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }

        public void create(string tableName, string schema)
        {
            string sql = "CREATE TABLE " + tableName + "(" + schema + ")";
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }

        public string name()
        {
            return db;
        }

        public void close()
        {
            conn.Close();
        }
    }
}
