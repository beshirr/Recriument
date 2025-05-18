using System;
using System.Windows.Forms;
using recruitment;

namespace Recruitment
{
    public partial class JobDetailsForm : Form
    {
        private readonly Vacancy _vacancy;

        public JobDetailsForm(Vacancy vacancy)
        {
            InitializeComponent();
            _vacancy = vacancy;
            DisplayVacancyDetails();
        }

        private void DisplayVacancyDetails()
        {
            lblTitle.Text = _vacancy.V_JOBTITLE;
            lblDescription.Text = _vacancy.V_JOBDESCRIPTION;
            lblSalary.Text = $"Salary: {_vacancy.V_SALARY:C}";
            lblExperience.Text = $"Experience Required: {_vacancy.V_EXPERIENCEREQUIRED} years";
            lblSkills.Text = $"Skills: {string.Join(", ", _vacancy.V_SKILLSREQUIRED)}";
        }

        private void applybtn_Click(object sender, EventArgs e)
        {
            if (Owner is SeekerHome seekerHome)
            {
                seekerHome.ApplyToSelectedJob(_vacancy);
            }
        }
    }
}
