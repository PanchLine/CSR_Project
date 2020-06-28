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
    public partial class DepartmentsForm : Form
    {
        public DepartmentsForm()
        {
            InitializeComponent();
            ShowDepartments();
            labelName.Text = AutorizationForm.users.name;
            labelDep.Text = AutorizationForm.users.dep;
        }

        void ShowDepartments()
        {
            listViewDepartments.Items.Clear();
            foreach (Departments departmentsSet in Program.csr.Departments)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    departmentsSet.ID.ToString(), departmentsSet.Department
                });
                item.Tag = departmentsSet;
                listViewDepartments.Items.Add(item);
            }
            listViewDepartments.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize); 
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxDepartments.Text != "")
            {
                Departments departmentsSet = new Departments();
                departmentsSet.Department = textBoxDepartments.Text;
                Program.csr.Departments.Add(departmentsSet);
                Program.csr.SaveChanges();
                ShowDepartments();
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Невозможно внести данные!", MessageBoxButtons.OK);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxDepartments.Text != "")
            {
                if (listViewDepartments.SelectedItems.Count == 1)
                {
                    Departments departmentsSet = listViewDepartments.SelectedItems[0].Tag as Departments;
                    departmentsSet.Department = textBoxDepartments.Text;
                    Program.csr.SaveChanges();
                    ShowDepartments();
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
                if (listViewDepartments.SelectedItems.Count == 1)
                {
                    Departments departmentsSet = listViewDepartments.SelectedItems[0].Tag as Departments;
                    Program.csr.Departments.Remove(departmentsSet);
                    Program.csr.SaveChanges();
                    ShowDepartments();
                }
                textBoxDepartments.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDepartments.SelectedItems.Count == 1)
            {
                Departments departmentsSet = listViewDepartments.SelectedItems[0].Tag as Departments;
                textBoxDepartments.Text = departmentsSet.Department;
            }
            else
            {
                textBoxDepartments.Text = "";
            }
        }
    }
}
