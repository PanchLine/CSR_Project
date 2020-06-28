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
    public partial class ProfessionsForm : Form
    {
        public ProfessionsForm()
        {
            InitializeComponent();
            ShowProfessions();
            labelName.Text = AutorizationForm.users.name;
            labelDep.Text = AutorizationForm.users.dep;
        }

        void ShowProfessions()
        {
            listViewProfessions.Items.Clear();
            foreach (Professions professionsSet in Program.csr.Professions)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    professionsSet.ID.ToString(), professionsSet.Profession
                });
                item.Tag = professionsSet;
                listViewProfessions.Items.Add(item);
            }
            listViewProfessions.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxProfession.Text != "")
            {
                Professions professionsSet = new Professions();
                professionsSet.Profession = textBoxProfession.Text;
                Program.csr.Professions.Add(professionsSet);
                Program.csr.SaveChanges();
                ShowProfessions();
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Невозможно внести данные!", MessageBoxButtons.OK);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxProfession.Text != "")
            {
                if (listViewProfessions.SelectedItems.Count == 1)
                {
                    Professions professionsSet = listViewProfessions.SelectedItems[0].Tag as Professions;
                    professionsSet.Profession = textBoxProfession.Text;
                    Program.csr.SaveChanges();
                    ShowProfessions();
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
                if (listViewProfessions.SelectedItems.Count == 1)
                {
                    Professions professionsSet = listViewProfessions.SelectedItems[0].Tag as Professions;
                    Program.csr.Professions.Remove(professionsSet);
                    Program.csr.SaveChanges();
                    ShowProfessions();
                }
                textBoxProfession.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewProfessions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewProfessions.SelectedItems.Count == 1)
            {
                Professions professionsSet = listViewProfessions.SelectedItems[0].Tag as Professions;
                textBoxProfession.Text = professionsSet.Profession;
            }
            else
            {
                textBoxProfession.Text = "";
            }
        }
    }
}
