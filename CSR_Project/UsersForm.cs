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
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
            ShowProfessions();
            ShowDepartments();
            ShowUsers();
            labelName.Text = AutorizationForm.users.name;
            labelDep.Text = AutorizationForm.users.dep;
        }

        void ShowProfessions()
        {
            comboBoxProfession.Items.Clear();
            foreach (Professions professionsSet in Program.csr.Professions)
            {
                string[] item = { professionsSet.ID.ToString() + ".", professionsSet.Profession };
                comboBoxProfession.Items.Add(string.Join(" ", item));
            }
        }
        void ShowDepartments()
        {
            comboBoxDepartments.Items.Clear();
            foreach (Departments departmentsSet in Program.csr.Departments)
            {
                string[] item = { departmentsSet.ID.ToString() + ".", departmentsSet.Department };
                comboBoxDepartments.Items.Add(string.Join(" ", item));
            }
        }
        void ShowUsers()
        {
            listViewUsers.Items.Clear();
            foreach (Users usersSet in Program.csr.Users)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    usersSet.ID.ToString(),
                    usersSet.Name,
                    usersSet.Professions.Profession,
                    usersSet.Departments.Department,
                    usersSet.Phone,
                    usersSet.Email,
                    usersSet.Login,
                    usersSet.Password
                });
                item.Tag = usersSet;
                listViewUsers.Items.Add(item);
            }
            listViewUsers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void comboBoxDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text !="" && comboBoxProfession !=null && comboBoxDepartments !=null && textBoxPhone.Text != ""&&
                textBoxEmail.Text !=""&& textBoxLogin.Text !="" && textBoxPassword.Text !="")
            {
                if (textBoxPassword.Text.Length < 4)
                {
                    MessageBox.Show("Пароль должен содержать не менее 4 символов", "Слишком короткий пароль", MessageBoxButtons.OK);
                }
                else
                {
                    long temp;
                    bool phone = Int64.TryParse(textBoxPhone.Text, out temp);
                    if (!phone) MessageBox.Show("Номер телефона состоит из цифр", "Неверный тип данных", MessageBoxButtons.OK);
                    else
                    {
                        Users usersSet = new Users();
                        usersSet.Name = textBoxName.Text;
                        usersSet.id_Profession = Convert.ToInt32(comboBoxProfession.SelectedItem.ToString().Split('.')[0]);
                        usersSet.id_Department = Convert.ToInt32(comboBoxDepartments.SelectedItem.ToString().Split('.')[0]);
                        usersSet.Phone = textBoxPhone.Text;
                        usersSet.Email = textBoxEmail.Text;
                        usersSet.Login = textBoxLogin.Text;
                        usersSet.Password = textBoxPassword.Text;
                        Program.csr.Users.Add(usersSet);
                        Program.csr.SaveChanges();
                        ShowUsers();
                    }
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Невозможно внести данные!", MessageBoxButtons.OK);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "" && comboBoxProfession.SelectedItem != null && comboBoxDepartments.SelectedItem != null && textBoxPhone.Text != "" &&
                textBoxEmail.Text != "" && textBoxLogin.Text != "" && textBoxPassword.Text != "")
            {
                if (textBoxPassword.Text.Length < 4)
                {
                    MessageBox.Show("Пароль должен содержать не менее 4 символов", "Слишком короткий пароль", MessageBoxButtons.OK);
                }
                else
                {
                    if (listViewUsers.SelectedItems.Count == 1)
                    {
                        long temp;
                        bool phone = Int64.TryParse(textBoxPhone.Text, out temp);
                        if (!phone) MessageBox.Show("Номер телефона состоит из цифр", "Неверный тип данных", MessageBoxButtons.OK);
                        else
                        {
                            Users usersSet = listViewUsers.SelectedItems[0].Tag as Users;
                            usersSet.Name = textBoxName.Text;
                            usersSet.id_Profession = Convert.ToInt32(comboBoxProfession.SelectedItem.ToString().Split('.')[0]);
                            usersSet.id_Department = Convert.ToInt32(comboBoxDepartments.SelectedItem.ToString().Split('.')[0]);
                            usersSet.Phone = textBoxPhone.Text;
                            usersSet.Email = textBoxEmail.Text;
                            usersSet.Login = textBoxLogin.Text;
                            usersSet.Password = textBoxPassword.Text;
                            Program.csr.SaveChanges();
                            ShowUsers();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Невозможно внести данные!", MessageBoxButtons.OK);
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewUsers.SelectedItems.Count == 1)
                {
                    Users usersSet = listViewUsers.SelectedItems[0].Tag as Users;
                    Program.csr.Users.Remove(usersSet);
                    Program.csr.SaveChanges();
                    ShowUsers();
                }
                textBoxName.Text = "";
                comboBoxProfession.SelectedItem = null;
                comboBoxDepartments.SelectedItem = null;
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
                textBoxLogin.Text = "";
                textBoxPassword.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewUsers.SelectedItems.Count ==1)
            {
                Users usersSet = listViewUsers.SelectedItems[0].Tag as Users;
                textBoxName.Text = usersSet.Name;
                comboBoxProfession.SelectedIndex = comboBoxProfession.FindString(usersSet.id_Profession.ToString());
                comboBoxDepartments.SelectedIndex = comboBoxDepartments.FindString(usersSet.id_Department.ToString());
                textBoxPhone.Text = usersSet.Phone;
                textBoxEmail.Text = usersSet.Email;
                textBoxLogin.Text = usersSet.Login;
                textBoxPassword.Text = usersSet.Password;
            }
            else
            {
                textBoxName.Text = "";
                comboBoxProfession.SelectedItem = null;
                comboBoxDepartments.SelectedItem = null;
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
                textBoxLogin.Text = "";
                textBoxPassword.Text = "";
            }
        }

        private void nameKeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false) return;
            if (e.KeyChar == Convert.ToChar(Keys.Back)) return;
            e.Handled = true;
            textBoxName.Clear();
        }
    }
}
