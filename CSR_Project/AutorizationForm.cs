using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSR_Project
{
    public struct User
    {
        public string login;
        public string password;
        public string typeProf;
        public string typeDep;
        public string name;
        public string dep;
    }
    public partial class AutorizationForm : Form
    {
        public static User users = new User();

        public AutorizationForm()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "" && textBoxPassword.Text == "")
            {
                MessageBox.Show("Введите данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool key = false;
                foreach (Users user in Program.csr.Users)
                {
                    if (textBoxLogin.Text == user.Login && textBoxPassword.Text == user.Password)
                    {
                        key = true;
                        users.login = user.Login;
                        users.password = user.Password;
                        users.typeProf = user.id_Profession.ToString();
                        users.typeDep = user.id_Department.ToString();
                        users.name = user.Name;
                        users.dep = user.Departments.Department;
                    }
                }
                if (!key)
                {
                    MessageBox.Show("Проверьте данные", "Пользователь не найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxLogin.Text = "";
                    textBoxPassword.Text = "";
                }
                else
                {
                    MainMenu menu = new MainMenu();
                    menu.Show();
                    this.Hide();
                }
            }
        }

        private void buttonCanel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
