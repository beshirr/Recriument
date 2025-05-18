using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace recruitment
{
    public partial class EmployerSignup : Form
    {
        private string firstname;
        private string lastname;
        private string email;
        private string phone;
        private string password;

        public EmployerSignup(string firstname, string lastname, string email, string phone, string password)
        {
            InitializeComponent();
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.phone = phone;
            this.password = password;
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            string department = department_textbox.Text;
            string positionTitle = positionTitle_textbox.Text;
            string linkedinURL = linkedinURL_textbox.Text;

            if (string.IsNullOrWhiteSpace(department) ||
                string.IsNullOrWhiteSpace(positionTitle) ||
                string.IsNullOrWhiteSpace(linkedinURL))
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=LAPTOP-HRLK7A2F\\MSSQLSERVER01;Initial Catalog=OnlineRecruitment;Integrated Security=True"))
                {
                    con.Open();

                    // First create a default company (since schema requires COMPANYID_)
                    string companyQuery = "INSERT INTO COMPANY (C_NAME) VALUES ('New Company'); SELECT SCOPE_IDENTITY();";
                    SqlCommand companyCmd = new SqlCommand(companyQuery, con);
                    int companyId = Convert.ToInt32(companyCmd.ExecuteScalar());

                    // Then insert employer with the company ID
                    string employerQuery = @"INSERT INTO EMPLOYER (COMPANYID_, EMP_FNAME, EMP_LNAME, EMP_EMAIL, EMP_PASSWORD, EMP_DEPARTMENT, EMP_POSITION_TITLE)
                                           VALUES (@CompanyId, @FirstName, @LastName, @Email, @Password, @Department, @PositionTitle)";

                    SqlCommand cmd = new SqlCommand(employerQuery, con);
                    cmd.Parameters.AddWithValue("@CompanyId", companyId);
                    cmd.Parameters.AddWithValue("@FirstName", firstname);
                    cmd.Parameters.AddWithValue("@LastName", lastname);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Department", department);
                    cmd.Parameters.AddWithValue("@PositionTitle", positionTitle);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registration successful!");

                    // Open employer home page (you'll need to implement this)
                    // EmployerHome employerHome = new EmployerHome();
                    // employerHome.Show();
                    // this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during registration: {ex.Message}");
            }
        }
    }
}