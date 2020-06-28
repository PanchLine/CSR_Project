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
    public partial class Needs_ReviewForm : Form
    {
        public Needs_ReviewForm()
        {
            InitializeComponent();
            ShowNeedReviews();
            ShowNeeds();
            ShowDocuments();
            textBoxPrice.Enabled = false;
            labelName.Text = AutorizationForm.users.name;
            labelDep.Text = AutorizationForm.users.dep;
        }
        void ShowNeedReviews()
        {
            listViewNeedsReview.Items.Clear();
            foreach (NeedsReview needsReviewSet in Program.csr.NeedsReview)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    needsReviewSet.ID.ToString(),
                    needsReviewSet.Needs.Item,
                    needsReviewSet.Date.ToString().Substring(0, needsReviewSet.Date.ToString().Length-8),
                    needsReviewSet.Comment,
                    needsReviewSet.Total_Price.ToString(),
                    needsReviewSet.Documents.Contract + " " + needsReviewSet.Documents.Act + " " + 
                    needsReviewSet.Documents.Date.ToString().Substring(0, needsReviewSet.Date.ToString().Length - 8)
            }) ;
                item.Tag = needsReviewSet;
                listViewNeedsReview.Items.Add(item);
            }
            listViewNeedsReview.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        
        }
        void ShowNeeds()
        {
            comboBoxNeed.Items.Clear();
            foreach (Needs needsSet in Program.csr.Needs)
            {
                string[] item = { needsSet.ID.ToString() + ".", needsSet.Item, needsSet.Departments.Department };
                comboBoxNeed.Items.Add(string.Join(" ", item));
            }           
        }
        void ShowDocuments()
        {
            comboBoxDocument.Items.Clear();
            foreach (Documents documentsSet in Program.csr.Documents)
            {
                string[] item = { documentsSet.ID.ToString() + ".", documentsSet.Contract, documentsSet.Act,
                documentsSet.Date.ToString().Substring(0, documentsSet.Date.ToString().Length-8), };
                comboBoxDocument.Items.Add(string.Join(" ", item));
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxDocument.SelectedItem != null && comboBoxNeed.SelectedItem != null && textBoxDate.Text !="" &&
                textBoxPrice.Text !="")
            {
                DateTime temp;
                bool date = DateTime.TryParse(textBoxDate.Text, out temp);
                if (!date) MessageBox.Show("Введите дату в формате: ДД.ММ.ГГГГ", "Неверный формат даты", MessageBoxButtons.OK);
                else
                {
                    NeedsReview needsReview = new NeedsReview();
                    needsReview.id_Need = Convert.ToInt32(comboBoxNeed.SelectedItem.ToString().Split('.')[0]);
                    needsReview.Date = Convert.ToDateTime(textBoxDate.Text);
                    needsReview.Comment = textBoxComment.Text;
                    needsReview.Total_Price = Convert.ToInt32(textBoxPrice.Text);
                    needsReview.id_Document = Convert.ToInt32(comboBoxDocument.SelectedItem.ToString().Split('.')[0]);
                    Program.csr.NeedsReview.Add(needsReview);
                    Program.csr.SaveChanges();
                    ShowNeedReviews();
                }
            }
            else
            {
                MessageBox.Show("Заполните все необходимые поля", "Невозможно внести данные!", MessageBoxButtons.OK);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxDocument.SelectedItem != null && comboBoxNeed.SelectedItem != null && textBoxDate.Text != "" &&
                textBoxPrice.Text != "")
            {
                if (listViewNeedsReview.SelectedItems.Count == 1)
                {
                    DateTime temp;
                    bool date = DateTime.TryParse(textBoxDate.Text, out temp);
                    if (!date) MessageBox.Show("Введите дату в формате: ДД.ММ.ГГГГ", "Неверный формат даты", MessageBoxButtons.OK);
                    else
                    {
                        NeedsReview needsReview = listViewNeedsReview.SelectedItems[0].Tag as NeedsReview;
                        needsReview.id_Need = Convert.ToInt32(comboBoxNeed.SelectedItem.ToString().Split('.')[0]);
                        needsReview.Date = Convert.ToDateTime(textBoxDate.Text);
                        needsReview.Comment = textBoxComment.Text;
                        needsReview.id_Document = Convert.ToInt32(comboBoxDocument.SelectedItem.ToString().Split('.')[0]);
                        Program.csr.SaveChanges();
                        ShowNeedReviews();
                    }
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
                if (listViewNeedsReview.SelectedItems.Count == 1)
                {
                    NeedsReview needsReview = listViewNeedsReview.SelectedItems[0].Tag as NeedsReview;
                    Program.csr.NeedsReview.Remove(needsReview);
                    Program.csr.SaveChanges();
                    ShowNeedReviews();
                }
                comboBoxNeed.SelectedItem = null;
                comboBoxDocument.SelectedItem = null;
                textBoxComment.Text = "";
                textBoxDate.Text = "";
                textBoxPrice.Text = "";
                
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewNeedsReview_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewNeedsReview.SelectedItems.Count == 1)
            {
                NeedsReview needsReview = listViewNeedsReview.SelectedItems[0].Tag as NeedsReview;
                comboBoxNeed.SelectedIndex = comboBoxNeed.FindString(needsReview.id_Need.ToString());
                comboBoxDocument.SelectedIndex = comboBoxDocument.FindString(needsReview.id_Document.ToString());
                textBoxComment.Text = needsReview.Comment;
                textBoxDate.Text = needsReview.Date.ToString().Substring(0, needsReview.Date.ToString().Length - 8);
                textBoxPrice.Text = needsReview.Total_Price.ToString();
            }
            else
            {
                comboBoxNeed.SelectedItem = null;
                comboBoxDocument.SelectedItem = null;
                textBoxComment.Text = "";
                textBoxDate.Text = "";
                textBoxPrice.Text = "";
            }
        }

        private void comboBoxNeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxNeed.SelectedItem !=null)
            {
                Needs needs = Program.csr.Needs.Find(Convert.ToInt32(comboBoxNeed.SelectedItem.ToString().Split('.')[0]));
                textBoxPrice.Text = needs.Total_Price.ToString();
            }
        }
    }
}
