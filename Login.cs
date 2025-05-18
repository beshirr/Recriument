using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            if (email == "" || password == "")
            {
                MessageBox.Show("Please enter email and password");
                return;
            }
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-HRLK7A2F\\MSSQLSERVER01;Initial Catalog=OnlineRequirements;Integrated Security=True;Encrypt=True");
            conn.Open();
            string seekerQuery = "SELECT S_EMAIL, S_PASSWORD FROM EMPLOYER WHERE S_EMAIL = @Email AND S_PASSWORD = @Password";
            string employerQuery = "SELECT EMP_EMAIL, EMP_PASSWORD FROM EMPLOYER WHERE EMP_EMAIL = @Email AND EMP_PASSWORD = @Password";

            SqlCommand cmd = new SqlCommand(seekerQuery, conn);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Password", password);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows) 
            {
                reader.Close();
                SeekerHome seekerHome = new SeekerHome();
                seekerHome.Show();
                this.Hide();
                return;
            }
            reader.Close();

            SqlCommand cmd2 = new SqlCommand(employerQuery, conn);
            cmd2.Parameters.AddWithValue("@Email", email);
            cmd2.Parameters.AddWithValue("@Password", password);

            SqlDataReader reader2 = cmd2.ExecuteReader();
            if (reader2.HasRows) 
            {
                reader2.Close();
                // Go To Employer home;
                return;
            }
            reader2.Close();


            MessageBox.Show("Wrong email or password!");
            return;

        }
    }
}
