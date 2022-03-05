using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace DataBase
{
    public partial class AppForm : Form
    {
        public AppForm()
        {
            InitializeComponent();
            List<string> tableNameList = new List<string>();
            DataRowCollection dataRows = GetTableName().Rows;
            for (int i = 0; i < dataRows.Count; i++)
            {
                tableNameList.Add((string)dataRows[i].ItemArray[0]);
            }
            nameTableBox.DataSource = tableNameList;
        }

        private void AppForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public DataTable GetTableName()
        {
            string query = "SELECT table_name FROM information_schema.tables WHERE table_schema NOT IN('information_schema','pg_catalog');";
            DataBase dataBase = new DataBase();
            dataBase.OpenConnection();
            NpgsqlDataAdapter data = new NpgsqlDataAdapter(query, DataBase.ConnectionString);
            DataTable resultTable = new DataTable();
            data.Fill(resultTable);
            return resultTable;
        }
    }
}
