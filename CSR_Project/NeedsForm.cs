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
    public partial class NeedsForm : Form
    {
        public NeedsForm()
        {
            InitializeComponent();
            ShowNeeds();
            ShowDepartments();
            textBoxTotalPrice.Enabled = false;
            labelName.Text = AutorizationForm.users.name;
            labelDep.Text = AutorizationForm.users.dep;
            if (AutorizationForm.users.typeDep != "1" && AutorizationForm.users.typeDep != "4")
            {
                comboBoxDepartment.Enabled = false;
                comboBoxDepartment.SelectedIndex = Convert.ToInt32(AutorizationForm.users.typeDep) - 1;
            }
            
        }

        void ShowNeeds()
        {
            listViewNeeds.Items.Clear();
            if (AutorizationForm.users.typeDep != "1" && AutorizationForm.users.typeDep != "4")
            {
                foreach (Needs needs in Program.csr.Needs)
                {
                    if (Convert.ToInt32(AutorizationForm.users.typeDep) == needs.id_Department)
                    {
                        ListViewItem item = new ListViewItem(new string[]
                        {
                            needs.ID.ToString(),
                            needs.Item,
                            needs.Total_items.ToString(),
                            needs.Price.ToString(),
                            needs.Total_Price.ToString(),
                            needs.Justification,
                            needs.Comment,
                            needs.Departments.Department
                        });
                        item.Tag = needs;
                        listViewNeeds.Items.Add(item);
                    }
                }
            }
            else
            {
                foreach (Needs needs in Program.csr.Needs)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        needs.ID.ToString(),
                        needs.Item,
                        needs.Total_items.ToString(),
                        needs.Price.ToString(),
                        needs.Total_Price.ToString(),
                        needs.Justification,
                        needs.Comment,
                        needs.Departments.Department
                    });
                    item.Tag = needs;
                    listViewNeeds.Items.Add(item);
                }
            }
            listViewNeeds.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        void ShowDepartments()
        {
            comboBoxDepartment.Items.Clear();
            foreach (Departments departmentsSet in Program.csr.Departments)
            {
                string[] item = { departmentsSet.ID.ToString() + ".", departmentsSet.Department };
                comboBoxDepartment.Items.Add(string.Join(" ", item));
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxItem.Text != "" && textBoxTotalItems.Text !="" && textBoxPrice.Text !="" &&
                textBoxTotalPrice.Text !="" && textBoxJustification.Text !="" && comboBoxDepartment.SelectedItem != null)
            {               
                    Needs needs = new Needs();
                    needs.Item = textBoxItem.Text;
                    needs.Total_items = Convert.ToInt32(textBoxTotalItems.Text);
                    needs.Price = Convert.ToInt32(textBoxPrice.Text);
                    needs.Total_Price = Convert.ToInt32(textBoxTotalPrice.Text);
                    needs.Justification = textBoxJustification.Text;
                    needs.Comment = textBoxComment.Text;
                    needs.id_Department = Convert.ToInt32(comboBoxDepartment.SelectedItem.ToString().Split('.')[0]);
                    Program.csr.Needs.Add(needs);
                    Program.csr.SaveChanges();
                    ShowNeeds();              
            }
            else
            {
                MessageBox.Show("Заполните все необходимые поля", "Невозможно внести данные!", MessageBoxButtons.OK);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxItem.Text != "" && textBoxTotalItems.Text != "" && textBoxPrice.Text != "" &&
                textBoxTotalPrice.Text != "" && textBoxJustification.Text != "" && comboBoxDepartment.SelectedItem != null)
            {
                if (listViewNeeds.SelectedItems.Count == 1)
                {
                    Needs needs = listViewNeeds.SelectedItems[0].Tag as Needs;
                    needs.Item = textBoxItem.Text;
                    needs.Total_items = Convert.ToInt32(textBoxTotalItems.Text);
                    needs.Price = Convert.ToInt32(textBoxPrice.Text);
                    needs.Total_Price = Convert.ToInt32(textBoxTotalPrice.Text);
                    needs.Justification = textBoxJustification.Text;
                    needs.Comment = textBoxComment.Text;
                    needs.id_Department = Convert.ToInt32(comboBoxDepartment.SelectedItem.ToString().Split('.')[0]);                  
                    Program.csr.SaveChanges();
                    ShowNeeds();
                }
            }
            else
            {
                MessageBox.Show("Заполните все необходимые поля", "Невозможно внести данные!", MessageBoxButtons.OK);
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewNeeds.SelectedItems.Count == 1)
                {
                    Needs needs = listViewNeeds.SelectedItems[0].Tag as Needs;
                    Program.csr.Needs.Remove(needs);
                    Program.csr.SaveChanges();
                    ShowNeeds();
                }
                if (AutorizationForm.users.typeDep != "1" && AutorizationForm.users.typeDep != "4")
                {
                    textBoxItem.Text = "";
                    textBoxTotalItems.Text = "";
                    textBoxPrice.Text = "";
                    textBoxTotalPrice.Text = "";
                    textBoxJustification.Text = "";
                    textBoxComment.Text = "";
                }
                else
                {
                    textBoxItem.Text = "";
                    textBoxTotalItems.Text = "";
                    textBoxPrice.Text = "";
                    textBoxTotalPrice.Text = "";
                    textBoxJustification.Text = "";
                    textBoxComment.Text = "";
                    comboBoxDepartment.SelectedItem = null;
                }

            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewNeeds_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewNeeds.SelectedItems.Count == 1)
            {
                Needs needs = listViewNeeds.SelectedItems[0].Tag as Needs;
                textBoxItem.Text = needs.Item;
                textBoxTotalItems.Text = needs.Total_items.ToString();
                textBoxPrice.Text = needs.Price.ToString();
                textBoxTotalPrice.Text = needs.Total_Price.ToString();
                textBoxJustification.Text = needs.Justification;
                textBoxComment.Text = needs.Comment;
                comboBoxDepartment.SelectedIndex = comboBoxDepartment.FindString(needs.id_Department.ToString());
            }
            else
            {
                if (AutorizationForm.users.typeDep != "1" && AutorizationForm.users.typeDep != "4")
                {
                    textBoxItem.Text = "";
                    textBoxTotalItems.Text = "";
                    textBoxPrice.Text = "";
                    textBoxTotalPrice.Text = "";
                    textBoxJustification.Text = "";
                    textBoxComment.Text = "";
                }
                else
                {
                    textBoxItem.Text = "";
                    textBoxTotalItems.Text = "";
                    textBoxPrice.Text = "";
                    textBoxTotalPrice.Text = "";
                    textBoxJustification.Text = "";
                    textBoxComment.Text = "";
                    comboBoxDepartment.SelectedItem = null;
                }
            }
        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPrice.Text != "" && textBoxTotalItems.Text !="")
            {
                textBoxTotalPrice.Text = Convert.ToString(Convert.ToInt32(textBoxPrice.Text) * Convert.ToInt32(textBoxTotalItems.Text));
            }
        }

        private void textBoxTotalItems_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPrice.Text != "" && textBoxTotalItems.Text != "")
            {
                textBoxTotalPrice.Text = Convert.ToString(Convert.ToInt32(textBoxPrice.Text) * Convert.ToInt32(textBoxTotalItems.Text));
            }
        }

        private void totalKeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == true) return;
            if (e.KeyChar == Convert.ToChar(Keys.Back)) return;
            e.Handled = true;
            textBoxTotalItems.Clear();
        }

        private void priceKeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == true) return;
            if (e.KeyChar == Convert.ToChar(Keys.Back)) return;
            e.Handled = true;
            textBoxPrice.Clear();
        }
    }
}
