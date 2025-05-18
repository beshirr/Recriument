using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Recriument
{
    public partial class ApplicantsForm : Form
    {
        private readonly int _employerId;
        private const string connStr = "Data Source=BESHIR\\SQLEXPRESS;Initial Catalog=recruitment;Integrated Security=True;Encrypt=False";

        public ApplicantsForm(int employerId)
        {
            _employerId = employerId;
            InitializeComponent();
            dataGridViewApplicants.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LoadApplicants();
        }

        private void LoadApplicants()
        {
            var dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = @"
                    SELECT 
                        Ap.APP_ID_ AS [Application ID],
                        S.SEEKERID,
                        S.S_FNAME + ' ' + S.S_LNAME AS [Seeker Name],
                        S.S_EMAIL AS [Email],
                        V.V_JOBTITLE AS [Job Title],
                        A._STATUS AS [Status],
                        Ap.DATE AS [Applied On]
                    FROM APPLIES Ap
                    INNER JOIN APPLICATION A ON Ap.APP_ID_ = A.APP_ID_
                    INNER JOIN VACANCY V ON A.VACANCYID = V.VACANCYID
                    INNER JOIN SEEKER S ON Ap.SEEKERID = S.SEEKERID
                    INNER JOIN EMPLOYER E ON V.COMPANYID_ = E.COMPANYID_
                    WHERE E.EMPLOYERID = @EmployerId
                    ORDER BY Ap.DATE DESC";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EmployerId", _employerId);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            dataGridViewApplicants.DataSource = dt;
        }

        private void btnSetInterview_Click(object sender, EventArgs e)
        {
            if (dataGridViewApplicants.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an applicant.");
                return;
            }

            int appId = Convert.ToInt32(dataGridViewApplicants.SelectedRows[0].Cells["Application ID"].Value);

            using (var interviewForm = new SetInterviewForm(appId))
            {
                interviewForm.ShowDialog(this);
            }
        }
    }
}
