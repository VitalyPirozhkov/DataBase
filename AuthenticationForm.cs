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
    public partial class AuthenticationForm : Form
    {
        public AuthenticationForm()
        {
            InitializeComponent();
        }

        private void AcsessButton_Click(object sender, EventArgs e)
        {
            DataBase.ConnectionString = $"Server=localhost;Port=5432;User ID = {IdBox.Text}; Password={PasswordBox.Text} ;Database=test;";
            DataBase test = new DataBase();
            try
            {
                test.OpenConnection();
                AppForm appForm = new AppForm();
                appForm.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Неверные логин и/или пароль.", "Ошибка");
            }
            finally
            {
                test.CloseConnection();
            }
        }
    }
}
