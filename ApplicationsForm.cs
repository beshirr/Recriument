using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Recriument
{
    public partial class ApplicationsForm : Form
    {
        private readonly int _seekerId;
        private const string connStr = "Data Source=BESHIR\\SQLEXPRESS;Initial Catalog=recruitment;Integrated Security=True;Encrypt=False";

        public ApplicationsForm(int seekerId)
        {
            _seekerId = seekerId;
            InitializeComponent();
            LoadApplications();
        }

        private void LoadApplications()
        {
            var dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = @"
                    SELECT 
                        V.V_JOBTITLE AS [Job Title],
                        V.V_JOBDESCRIPTION AS [Description],
                        A._STATUS AS [Status],
                        A.APP_ID_ AS [Application ID],
                        Ap.DATE AS [Applied On]
                    FROM APPLIES Ap
                    INNER JOIN APPLICATION A ON Ap.APP_ID_ = A.APP_ID_
                    INNER JOIN VACANCY V ON A.VACANCYID = V.VACANCYID
                    WHERE Ap.SEEKERID = @SeekerId
                    ORDER BY Ap.DATE DESC";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SeekerId", _seekerId);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            dataGridViewApplications.DataSource = dt;
        }
    }
}
