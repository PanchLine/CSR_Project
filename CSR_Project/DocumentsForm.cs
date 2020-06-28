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
    public partial class DocumentsForm : Form
    {
        public DocumentsForm()
        {
            InitializeComponent();
            ShowDocuments();
            labelName.Text = AutorizationForm.users.name;
            labelDep.Text = AutorizationForm.users.dep;
        }

        void ShowDocuments()
        {
            listViewDocuments.Items.Clear();
            foreach (Documents documentsSet in Program.csr.Documents)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    documentsSet.ID.ToString(),
                    documentsSet.Contract,
                    documentsSet.Act, 
                    documentsSet.Finance_report, 
                    documentsSet.Date.ToString().Substring(0, documentsSet.Date.ToString().Length-8)
                });
                item.Tag = documentsSet;
                listViewDocuments.Items.Add(item);
            }
            listViewDocuments.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxContract.Text !="" && textBoxAct.Text !="" && textBoxFinance_Report.Text !="" &&
                textBoxDate.Text !="")
            {
                DateTime temp;
                bool date = DateTime.TryParse(textBoxDate.Text, out temp);
                if (!date) MessageBox.Show("Введите дату в формате: ДД.ММ.ГГГГ", "Неверный формат даты", MessageBoxButtons.OK);
                else
                {
                    Documents documentsSet = new Documents();
                    documentsSet.Contract = textBoxContract.Text;
                    documentsSet.Act = textBoxAct.Text;
                    documentsSet.Finance_report = textBoxFinance_Report.Text;
                    documentsSet.Date = Convert.ToDateTime(textBoxDate.Text);
                    Program.csr.Documents.Add(documentsSet);
                    Program.csr.SaveChanges();
                    ShowDocuments();
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Невозможно внести данные!", MessageBoxButtons.OK);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxContract.Text != "" && textBoxAct.Text != "" && textBoxFinance_Report.Text != "" &&
                textBoxDate.Text != "")           
            {
                if (listViewDocuments.SelectedItems.Count == 1)
                {
                    DateTime temp;
                    bool date = DateTime.TryParse(textBoxDate.Text, out temp);
                    if (!date) MessageBox.Show("Введите дату в формате: ДД.ММ.ГГГГ", "Неверный формат даты", MessageBoxButtons.OK);
                    else
                    {
                        Documents documentsSet = listViewDocuments.SelectedItems[0].Tag as Documents;
                        documentsSet.Contract = textBoxContract.Text;
                        documentsSet.Act = textBoxAct.Text;
                        documentsSet.Finance_report = textBoxFinance_Report.Text;
                        documentsSet.Date = Convert.ToDateTime(textBoxDate.Text);
                        Program.csr.SaveChanges();
                        ShowDocuments();
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
                if (listViewDocuments.SelectedItems.Count == 1)
                {
                    Documents documentsSet = listViewDocuments.SelectedItems[0].Tag as Documents;
                    Program.csr.Documents.Remove(documentsSet);
                    Program.csr.SaveChanges();
                    ShowDocuments();
                }
                textBoxContract.Text = "";
                textBoxAct.Text = "";
                textBoxFinance_Report.Text = "";
                textBoxDate.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewDocuments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDocuments.SelectedItems.Count ==1)
            {
                Documents documentsSet = listViewDocuments.SelectedItems[0].Tag as Documents;
                textBoxContract.Text = documentsSet.Contract;
                textBoxAct.Text = documentsSet.Act;
                textBoxFinance_Report.Text = documentsSet.Finance_report;
                textBoxDate.Text = documentsSet.Date.ToString().Substring(0, documentsSet.Date.ToString().Length - 8);
            }
            else
            {
                textBoxContract.Text = "";
                textBoxAct.Text = "";
                textBoxFinance_Report.Text = "";
                textBoxDate.Text = "";
            }
        }
    }
}
