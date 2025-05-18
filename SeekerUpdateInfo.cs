using recruitment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recriument
{
    public partial class SeekerUpdateInfo : Form
    {
        private int currentID;
        public SeekerUpdateInfo(int currentID)
        {
            InitializeComponent();
            this.currentID = currentID;
        }

        private void done_button_Click(object sender, EventArgs e)
        {
            SeekerHome seekerHome = new SeekerHome(currentID);
            seekerHome.Show();
            this.Hide();
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-HRLK7A2F\\MSSQLSERVER01;Initial Catalog=OnlineRecruitment;Integrated Security=True");
            con.Open();
            string getSkills = "SELECT SKILLS FROM SEEKER WHERE SEEKERID = @SeekerID";
            SqlCommand skillsCmd = new SqlCommand(getSkills, con);
            skillsCmd.Parameters.AddWithValue("@SeekerID", currentID);
            string skills = skillsCmd.ExecuteScalar().ToString();

            string getCertifications = "SELECT CERTIFICATIONS FROM SEEKER WHERE SEEKERID = @SeekerID";
            SqlCommand certificationsCmd = new SqlCommand(getCertifications, con);
            certificationsCmd.Parameters.AddWithValue("@SeekerID", currentID);
            string certifications = certificationsCmd.ExecuteScalar().ToString();
            if (experienceYears_textbox.Text != "")
            {
                int experienceYears;
                if (int.TryParse(experienceYears_textbox.Text, out experienceYears))
                {
                    string query = "UPDATE SEEKER SET EXPERIENCEYEARS = @NewExperience WHERE SEEKERID = @SeekerID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@NewExperience", experienceYears);
                    cmd.Parameters.AddWithValue("@SeekerID", currentID);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Please enter an integer in the experience years field.");
                    return;
                }
            }

            if (educationLevel_comboBox.Text != "")
            {
                string query = "UPDATE SEEKER SET EDUCATIONLEVEL = @NewEducation WHERE SEEKERID = @SeekerID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@NewEducation", educationLevel_comboBox.Text);
                cmd.Parameters.AddWithValue("@SeekerID", currentID);
                cmd.ExecuteNonQuery();
            }

            if (skills_textbox.Text != "")
            {
                string query = "UPDATE SEEKER SET SKILLS = @NewSkills WHERE SEEKERID = @SeekerID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@NewSkills", skills + "," + skills_textbox.Text.Trim());
                cmd.Parameters.AddWithValue("@SeekerID", currentID);
                cmd.ExecuteNonQuery();
            }

            if (certifications_textbox.Text != "")
            {
                string query = "UPDATE SEEKER SET CERTIFICATIONS = @NewCertifications WHERE SEEKERID = @SeekerID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@NewCertifications", certifications + "," + certifications_textbox.Text.Trim());
                cmd.Parameters.AddWithValue("@SeekerID", currentID);
                cmd.ExecuteNonQuery();
            }

            con.Close();
        }
    }
}
