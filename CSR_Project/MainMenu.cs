using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSR_Project
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            labelName.Text = AutorizationForm.users.name;
            labelDep.Text = AutorizationForm.users.dep;
            if (AutorizationForm.users.typeDep != "1" && AutorizationForm.users.typeDep!="4")
            {
                buttonProfessions.Visible = false;
                buttonUsers.Visible = false;
                buttonDepartments.Visible = false;
                buttonDocuments.Visible = false;
                buttonNeedsReview.Visible = false;
            }
            else if (AutorizationForm.users.typeProf == "6")
            {
                buttonProfessions.Visible = true;
                buttonUsers.Visible = true;
                buttonDepartments.Visible = true;
                buttonDocuments.Visible = true;
                buttonNeedsReview.Visible = true;
                buttonNeeds.Visible = true;
            }
            else if (AutorizationForm.users.typeDep == "1" || AutorizationForm.users.typeDep == "4")
            {
                buttonProfessions.Visible = false;
                buttonUsers.Visible = false;
                buttonDepartments.Visible = false;
            }
        }

        private void buttonProfessions_Click(object sender, EventArgs e)
        {
            Form formProfession = new ProfessionsForm();
            formProfession.Show();
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            Form formUsers = new UsersForm();
            formUsers.Show();
        }

        private void buttonDepartments_Click(object sender, EventArgs e)
        {
            Form formDepartments = new DepartmentsForm();
            formDepartments.Show();
        }

        private void buttonDocuments_Click(object sender, EventArgs e)
        {
            Form formDocuments = new DocumentsForm();
            formDocuments.Show();
        }

        private void buttonNeeds_Click(object sender, EventArgs e)
        {
            Form formNeeds = new NeedsForm();
            formNeeds.Show();
        }

        private void buttonNeedsReview_Click(object sender, EventArgs e)
        {
            Form formNeedsReview = new Needs_ReviewForm();
            formNeedsReview.Show();
        }
    }
}
