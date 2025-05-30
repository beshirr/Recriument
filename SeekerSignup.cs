﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Recriument;

namespace recruitment
{
    public partial class SeekerSignup : Form
    {
        private string firstName;
        private string lastName;
        private string email;
        private string phone;
        private string password;
        public SeekerSignup(string firstName, string lastName, string email, string phone, string password)
        {
            InitializeComponent();
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.phone = phone;
            this.password = password;
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            int experienceYears;
            if (int.TryParse(experienceYears_textbox.Text, out experienceYears))
            {

            }
            else
            {
                MessageBox.Show("Please enter an integer in the experience years field.");
                return;
            }
            string educationLevel = educationLevel_comboBox.Text;
            string skills = skills_textbox.Text.Trim();
            string certifications = certifications_textbox.Text.Trim();
            if (experienceYears_textbox.Text == "" || educationLevel == "" || skills == "" || certifications == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=BESHIR\\SQLEXPRESS;Initial Catalog=recruitment;Integrated Security=True;Encrypt=False");
                con.Open();
                string query = "INSERT INTO SEEKER (S_FNAME, S_LNAME, S_EMAIL, S_PASSWORD, S_EDUCATIONLEVEL, EXPERIENCEYEARS, CERTIFICATIONS, SKILLS)" +
                    " VALUES (@FirstName, @LastName, @Email, @Password, @EducationLevel, @ExperienceYears, @Certifications, @Skills);";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@EducationLevel", educationLevel);
                cmd.Parameters.AddWithValue("@ExperienceYears", experienceYears);
                cmd.Parameters.AddWithValue("@Skills", skills);
                cmd.Parameters.AddWithValue("@Certifications", certifications);
                cmd.ExecuteNonQuery();

                string sqlID = "SELECT SEEKERID FROM SEEKER WHERE S_EMAIL = @EMAIL";
                SqlCommand IDcmd = new SqlCommand(sqlID, con);
                IDcmd.Parameters.AddWithValue("@email", email);

                object result = IDcmd.ExecuteScalar();
                int seekerId = 0;

                if (result != null && result != DBNull.Value)
                {
                    seekerId = Convert.ToInt32(result);
                }


                Recriument.Session.CurrentSeekerId = seekerId;

                string query2 = "INSERT INTO SEEKER_PHONE (SEEKERID, S_PHONE)" +
                    "VALUES (@SID, @Sphone);";
                SqlCommand cmd2 = new SqlCommand(query2, con);
                cmd2.Parameters.AddWithValue("@SID", seekerId);
                cmd2.Parameters.AddWithValue("@Sphone", phone);
                cmd2.ExecuteNonQuery();
                con.Close();

                SeekerHome seekerHome = new SeekerHome(Session.CurrentSeekerId);
                seekerHome.Show();
                this.Hide();
            }
        }
    }
}
