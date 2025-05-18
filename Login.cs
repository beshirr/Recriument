using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Recriument;

namespace recruitment
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string email = email_textbox.Text;
            string password = password_textbox.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter email and password");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=BESHIR\\SQLEXPRESS;Initial Catalog=recruitment;Integrated Security=True;Encrypt=False"))
                {
                    conn.Open();

                    // Check seeker first
                    string seekerQuery = "SELECT SEEKERID FROM SEEKER WHERE S_EMAIL = @Email AND S_PASSWORD = @Password";
                    using (SqlCommand seekerCmd = new SqlCommand(seekerQuery, conn))
                    {
                        seekerCmd.Parameters.AddWithValue("@Email", email);
                        seekerCmd.Parameters.AddWithValue("@Password", password);

                        object seekerResult = seekerCmd.ExecuteScalar();
                        if (seekerResult != null)
                        {
                            int seekerId = Convert.ToInt32(seekerResult);


                            SeekerHome seekerHome = new SeekerHome(seekerId);
                            seekerHome.Show();
                            this.Hide();
                            return;
                        }
                    }

                    // Check employer if not a seeker
                    string employerQuery = "SELECT EMPLOYERID FROM EMPLOYER WHERE EMP_EMAIL = @Email AND EMP_PASSWORD = @Password";
                    using (SqlCommand employerCmd = new SqlCommand(employerQuery, conn))
                    {
                        employerCmd.Parameters.AddWithValue("@Email", email);
                        employerCmd.Parameters.AddWithValue("@Password", password);

                        object employerResult = employerCmd.ExecuteScalar();
                        if (employerResult != null)
                        {
                            int employerId = Convert.ToInt32(employerResult);

                            EmployerHome employerHome = new EmployerHome(employerId);
                            employerHome.Show();
                            this.Hide();
                            return;
                        }
                    }

                    MessageBox.Show("Wrong email or password!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Login error: {ex.Message}");
            }
        }
    }
}