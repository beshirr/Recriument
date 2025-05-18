using System;
using System.Windows.Forms;
using recruitment;

namespace Recriument
{
    public partial class EmployerHome : Form
    {
        private int employerID;
        public EmployerHome(int employerID)
        {
            InitializeComponent();
            this.employerID = employerID;
        }

        private void addVacancy_button_Click(object sender, EventArgs e)
        {
            VacancyForm vacancyForm = new VacancyForm();
            vacancyForm.Show();
            this.Hide();
        }

        private void BtnViewApplicants_Click(object sender, EventArgs e)
        {
            var applicantsForm = new ApplicantsForm(employerID);
            applicantsForm.ShowDialog(this);
        }
    }
}
