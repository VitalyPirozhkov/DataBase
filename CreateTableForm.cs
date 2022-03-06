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
    public partial class CreateTableForm : Form
    {
        public CreateTableForm()
        {
            InitializeComponent();
        }

        public void CreateTable(StringBuilder script)
        {
            string query = $"Create Table {script});";
            DataBase dataBase = new DataBase();
            try
            {
                dataBase.OpenConnection();
                NpgsqlDataAdapter data = new NpgsqlDataAdapter(query, DataBase.ConnectionString);
                DataTable table = new DataTable();
                data.Fill(table);
            }
            finally
            {
                dataBase.CloseConnection();
            }
        }

        private void CreateTableButton_Click(object sender, EventArgs e)
        {

             StringBuilder script = new StringBuilder($"{TableNameBox.Text.ToLower()} (");
             DataGridViewRowCollection dataRows = ColumnDataGird.Rows;
            try
            {
                foreach (DataGridViewRow el in dataRows)
                {
                    try
                    {
                        string columnName = el.Cells[0].Value.ToString();
                        string typeColumn = el.Cells[1].Value.ToString();
                        string PKCheck = el.Cells[2].Value.ToString();
                        if (columnName == "" || typeColumn == "" || PKCheck == "")
                        {
                            break;
                        }
                        script.Append(columnName + " " + typeColumn);
                        if (PKCheck == "True")
                        {
                            script.Append(" PRIMARY KEY");
                        }
                        script.Append(", ");
                    }
                    catch
                    {
                        continue;
                    }
                }
                script.Remove(script.Length - 2, 1);
                CreateTable(script);
                MessageBox.Show("Таблица успешно создана");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка. Неверный запрос или утеряна связь с БД. Попробуйте снова.");
            } 
        }
    }
}
