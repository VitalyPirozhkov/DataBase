using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void acsessButton_Click(object sender, EventArgs e)
        {
            if (idBox.Text == "" || passwordBox.Text == "")
            {
                MessageBox.Show("Введите User ID и пароль");
            }
            DataBase.ConnectionString = $"Server=localhost;Port=5432;User ID = {idBox.Text}; Password={passwordBox.Text};Database=test;";
            DataBase test = new DataBase();
            try
            {
                test.OpenConnection();

            }
            catch
            {
                MessageBox.Show("Ошибка.Неверные логин и/или пароль.");
            }
            finally
            {
                test.CloseConnection();
            }
        }
    }
}
