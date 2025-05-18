using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Recriument;

namespace recruitment
{
    public partial class VacancyForm : Form
    {
        private int employerId;
        private int companyId;


        public VacancyForm(int currentID)
        {
            this.employerId = currentID;
            this.companyId = VacancyDAL.GetCompanyIdByEmployerId(employerId);

            InitializeComponent();
            this.Load += VacancyForm_Load;
            dgvVacancies.SelectionChanged += dgvVacancies_SelectionChanged;
            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;

        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtJobTitle.Text))
            {
                MessageBox.Show("Job Title is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtJobTitle.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtJobDescription.Text))
            {
                MessageBox.Show("Job Description is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtJobDescription.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSkills.Text))
            {
                MessageBox.Show("Please enter at least one skill.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSkills.Focus();
                return false;
            }

            if (numExperience.Value < 0)
            {
                MessageBox.Show("Experience cannot be negative.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numExperience.Focus();
                return false;
            }

            if (numSalary.Value <= 0)
            {
                MessageBox.Show("Salary must be greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numSalary.Focus();
                return false;
            }

            return true;
        }


        private void LoadVacancies()
        {
            var vacancies = VacancyDAL.GetVacanciesByCompanyId(companyId);

            var displayList = vacancies.Select(v => new
            {
                VacancyID = v.VACANCYID,
                JobTitle = v.V_JOBTITLE,
                ExperienceRequired = v.V_EXPERIENCEREQUIRED,
                Salary = v.V_SALARY.ToString("C"),
                SkillsRequired = string.Join(", ", v.V_SKILLSREQUIRED),
                IsVisible = v.ISVISIBLE ? "Visible" : "Hidden"
            }).ToList();

            dgvVacancies.DataSource = displayList;

            dgvVacancies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvVacancies.Columns["VacancyID"] != null)
            {
                dgvVacancies.Columns["VacancyID"].Visible = false;
            }
        }

        private void dgvVacancies_SelectionChanged(object sender, EventArgs e)
        {
            bool hasSelection = dgvVacancies.SelectedRows.Count > 0;

            btnUpdate.Enabled = hasSelection;
            btnDelete.Enabled = hasSelection;

            if (hasSelection)
            {
                int vacancyId = (int)dgvVacancies.SelectedRows[0].Cells["VacancyID"].Value;
                Vacancy vacancy = VacancyDAL.GetVacancyById(vacancyId);

                if (vacancy != null)
                {
                    txtJobTitle.Text = vacancy.V_JOBTITLE;
                    txtJobDescription.Text = vacancy.V_JOBDESCRIPTION;
                    txtSkills.Text = string.Join(", ", vacancy.V_SKILLSREQUIRED);
                    numExperience.Value = vacancy.V_EXPERIENCEREQUIRED;
                    numSalary.Value = vacancy.V_SALARY;
                    chkIsVisible.Checked = vacancy.ISVISIBLE;
                }
            }
            else
            {
                ClearForm();
            }
        }
        private void ClearForm()
        {
            txtJobTitle.Clear();
            txtJobDescription.Clear();
            txtSkills.Clear();
            numExperience.Value = 0;
            numSalary.Value = 0;
            chkIsVisible.Checked = true;
            dgvVacancies.ClearSelection();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;  // Now user can click update/save to insert new vacancy
            btnDelete.Enabled = false;
            dgvVacancies.ClearSelection();
            // Optionally disable Add button to prevent confusion
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            Vacancy vacancy = new Vacancy
            {
                COMPANYID_ = companyId,
                V_JOBTITLE = txtJobTitle.Text,
                V_JOBDESCRIPTION = txtJobDescription.Text,
                V_SKILLSREQUIRED = txtSkills.Text.Split(',').Select(s => s.Trim()).ToList(),
                V_EXPERIENCEREQUIRED = (int)numExperience.Value,
                V_SALARY = numSalary.Value,
                ISVISIBLE = chkIsVisible.Checked
            };

            if (dgvVacancies.SelectedRows.Count > 0)
            {
                // Update existing vacancy
                vacancy.VACANCYID = (int)dgvVacancies.SelectedRows[0].Cells["VacancyID"].Value;
                VacancyDAL.UpdateVacancy(vacancy);
                MessageBox.Show("Vacancy updated successfully.");
            }
            else
            {
                // Insert new vacancy
                VacancyDAL.inserVacancy(vacancy);
                MessageBox.Show("Vacancy added successfully.");
            }

            LoadVacancies();
            ClearForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvVacancies.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a vacancy to delete.");
                return;
            }

            int vacancyId = (int)dgvVacancies.SelectedRows[0].Cells["VacancyID"].Value;

            var confirm = MessageBox.Show("Are you sure you want to delete this vacancy?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                VacancyDAL.DeleteVacancy(vacancyId);
                MessageBox.Show("Vacancy deleted successfully.");
                LoadVacancies();
                ClearForm();
            }
        }

        private void btnToggleVisibility_Click(object sender, EventArgs e)
        {
            if (dgvVacancies.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a vacancy to hide/show.");
                return;
            }

            int vacancyId = (int)dgvVacancies.SelectedRows[0].Cells["VacancyID"].Value;
            string currentStatus = dgvVacancies.SelectedRows[0].Cells["Status"].Value.ToString();

            if (currentStatus == "Visible")
            {
                VacancyDAL.HideVacancy(vacancyId);
                MessageBox.Show("Vacancy hidden.");
            }
            else
            {
                VacancyDAL.ShowVacancy(vacancyId);
                MessageBox.Show("Vacancy made visible.");
            }

            LoadVacancies();
        }

        private void dgvVacancies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void VacancyForm_Load(object sender, EventArgs e)
        {
            LoadVacancies();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

        }

        private void txtJobTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtJobDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSkills_TextChanged(object sender, EventArgs e)
        {

        }

        private void numExperience_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numSalary_ValueChanged(object sender, EventArgs e)
        {

        }

        private void done_button_Click(object sender, EventArgs e)
        {
            EmployerHome employerHome = new EmployerHome(employerId);
            employerHome.Show();
            this.Hide();
        }
    }
}
