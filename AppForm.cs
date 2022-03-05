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
            NameTableBox.SelectedIndexChanged += NameTableBox_SelectedIndexChanged;
            UpdateTableName();
        }
        public void UpdateTableName()
        {
            List<string> tableNameList = new List<string>();
            DataRowCollection dataRows = GetTableName().Rows;
            for (int i = 0; i < dataRows.Count; i++)
            {
                tableNameList.Add((string)dataRows[i].ItemArray[0]);
            }
            NameTableBox.DataSource = tableNameList;
        }
        void NameTableBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string script = $"select \"column_name\", data_type from information_schema.columns where table_catalog = 'test' and table_schema = 'public' and table_name = '{NameTableBox.SelectedItem}'; ";
            DataBase dataBase = new DataBase();
            try
            {
                dataBase.OpenConnection();
                NpgsqlDataAdapter data = new NpgsqlDataAdapter(script, DataBase.ConnectionString);
                DataTable table = new DataTable();
                data.Fill(table);
                DataGridApp.DataSource = table;
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
            finally
            {
                dataBase.CloseConnection();
            }
        }
        private void AppForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public DataTable GetTableName()
        {
            string query = "SELECT table_name FROM information_schema.tables WHERE table_schema NOT IN('information_schema','pg_catalog');";
            DataBase dataBase = new DataBase();
            DataTable resultTable = new DataTable();
            try
            {
                dataBase.OpenConnection();
                NpgsqlDataAdapter data = new NpgsqlDataAdapter(query, DataBase.ConnectionString);
                data.Fill(resultTable);
                return resultTable;
            }
            catch
            {
                MessageBox.Show("Ошибка");
                return resultTable;
            }
            finally
            {
                dataBase.CloseConnection();
            }
        }

        private void DeleteTableButton_Click(object sender, EventArgs e)
        {
            DeleteTable(NameTableBox.SelectedItem.ToString());
            UpdateTableName();
        }
        public void DeleteTable(string tableName)
        {
            string query = $"DROP TABLE {tableName}";
            DataBase dataBase = new DataBase();
            try
            {
                dataBase.OpenConnection();
                NpgsqlDataAdapter data = new NpgsqlDataAdapter(query, DataBase.ConnectionString);
                DataTable table = new DataTable();
                data.Fill(table);
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
            finally
            {
                dataBase.CloseConnection();
            }
        }

        private void CreateTableButton_Click(object sender, EventArgs e)
        {
            CreateTableForm createTableForm = new CreateTableForm();
            createTableForm.Show();
            UpdateTableName();
        }
    }
}
