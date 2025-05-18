using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Recriument
{
    public partial class SetInterviewForm : Form
    {
        private readonly int _appId;
        private const string connStr = "Data Source=BESHIR\\SQLEXPRESS;Initial Catalog=recruitment;Integrated Security=True;Encrypt=False";

        public SetInterviewForm(int appId)
        {
            _appId = appId;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime interviewDate = dateTimePickerInterview.Value;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();


                string insertInterview = "INSERT INTO INTERVIEW (INTERVIEWMODE, INTERVIEWDATE) OUTPUT INSERTED.INTERVIEW_ID VALUES (@Mode, @Date)";
                int interviewId;
                using (SqlCommand cmd = new SqlCommand(insertInterview, conn))
                {
                    cmd.Parameters.AddWithValue("@Mode", "In-Person");
                    cmd.Parameters.AddWithValue("@Date", interviewDate);
                    interviewId = (int)cmd.ExecuteScalar();
                }


                string updateApp = "UPDATE APPLICATION SET INTERVIEW_ID = @InterviewId, _STATUS = @Status WHERE APP_ID_ = @AppId";
                using (SqlCommand cmd = new SqlCommand(updateApp, conn))
                {
                    cmd.Parameters.AddWithValue("@InterviewId", interviewId);
                    cmd.Parameters.AddWithValue("@Status", "Invited to Interview");
                    cmd.Parameters.AddWithValue("@AppId", _appId);
                    cmd.ExecuteNonQuery();
                }
            }


            MessageBox.Show("Interview scheduled and applicant notified.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
