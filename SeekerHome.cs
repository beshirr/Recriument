using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using Recruitment;

namespace recruitment
{
    public partial class SeekerHome : Form
    {
        private const string SearchPlaceholder = "Search by job title, loaction or keywords (e.g. Sales in Cairo)";
        private const string connStr = "Data Source=BESHIR\\SQLEXPRESS;Initial Catalog=recruitment;Integrated Security=True;Encrypt=False";
        private readonly int _seekerId;

        public SeekerHome(int seekerId)
        {
            _seekerId = seekerId;
            InitializeComponent();
            searchTextHolder.Text = SearchPlaceholder;
            searchTextHolder.ForeColor = System.Drawing.Color.Gray;
            searchTextHolder.GotFocus += searchTextHolder_GotFocus;
            searchTextHolder.LostFocus += searchTextHolder_LostFocus;
            searchTextHolder.TextChanged += searchTextHolder_TextChanged;

            lstJobs.DrawMode = DrawMode.OwnerDrawVariable;
            lstJobs.MeasureItem += lstJobs_MeasureItem;
            lstJobs.DrawItem += lstJobs_DrawItem;
            lstJobs.MouseDoubleClick += lstJobs_MouseDoubleClick;

            FilterJobs(string.Empty);
        }

        private void SeekerHome_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(connStr);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchText = searchTextHolder.Text.Trim();
            FilterJobs(searchText);
        }

        private void searchTextHolder_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchTextHolder.Text.Trim();
            FilterJobs(searchText);
        }

        private void searchTextHolder_GotFocus(object sender, EventArgs e)
        {
            if (searchTextHolder.Text == SearchPlaceholder)
            {
                searchTextHolder.Text = "";
                searchTextHolder.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void searchTextHolder_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchTextHolder.Text))
            {
                searchTextHolder.Text = SearchPlaceholder;
                searchTextHolder.ForeColor = System.Drawing.Color.Gray;
                // Reload all jobs when placeholder is set
                FilterJobs(string.Empty);
            }
        }

        private void FilterJobs(string searchText)
        {
            List<Vacancy> allJobs = GetAllJobs();

            List<Vacancy> filteredJobs;
            if (string.IsNullOrEmpty(searchText))
            {
                filteredJobs = allJobs;
            }
            else
            {
                filteredJobs = allJobs.Where(job =>
                    (!string.IsNullOrEmpty(job.V_JOBTITLE) && job.V_JOBTITLE.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0) ||
                    (!string.IsNullOrEmpty(job.V_JOBDESCRIPTION) && job.V_JOBDESCRIPTION.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                ).ToList();

                if (filteredJobs.Count == 0)
                {
                    double threshold = 0.2;
                    filteredJobs = allJobs.Where(job =>
                        Similarity(searchText, job.V_JOBTITLE) >= threshold ||
                        Similarity(searchText, job.V_JOBDESCRIPTION) >= threshold
                    ).ToList();
                }
            }

            lstJobs.Items.Clear();
            foreach (var job in filteredJobs)
            {
                lstJobs.Items.Add(job);
            }
        }

        private double Similarity(string s1, string s2)
        {
            if (string.IsNullOrEmpty(s1) || string.IsNullOrEmpty(s2))
                return 0.0;

            var pairs1 = WordLetterPairs(s1.ToUpper());
            var pairs2 = WordLetterPairs(s2.ToUpper());
            int intersection = 0;
            int totalPairs = pairs1.Count + pairs2.Count;

            foreach (var pair1 in pairs1)
            {
                for (int j = 0; j < pairs2.Count; j++)
                {
                    if (pair1 == pairs2[j])
                    {
                        intersection++;
                        pairs2.RemoveAt(j);
                        break;
                    }
                }
            }
            return (2.0 * intersection) / totalPairs;
        }

        private List<string> WordLetterPairs(string str)
        {
            var allPairs = new List<string>();
            string[] words = str.Split(' ');

            foreach (string word in words)
            {
                if (!string.IsNullOrEmpty(word))
                {
                    var pairsInWord = LetterPairs(word);
                    allPairs.AddRange(pairsInWord);
                }
            }
            return allPairs;
        }

        private List<string> LetterPairs(string str)
        {
            var pairs = new List<string>();
            for (int i = 0; i < str.Length - 1; i++)
            {
                pairs.Add(str.Substring(i, 2));
            }
            return pairs;
        }

        private List<Vacancy> GetAllJobs()
        {
            var jobs = new List<Vacancy>();
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            string query = "SELECT VACANCYID, V_JOBTITLE, V_JOBDESCRIPTION, V_SALARY, V_EXPERIENCEREQUIRED, V_SKILLSREQUIRED FROM VACANCY";
            SqlCommand cmd = new SqlCommand(query, conn);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    jobs.Add(new Vacancy
                    {
                        VACANCYID = reader.GetInt32(0),
                        V_JOBTITLE = reader.GetString(1),
                        V_JOBDESCRIPTION = reader.GetString(2),
                        V_SALARY = reader.GetDecimal(3),
                        V_EXPERIENCEREQUIRED = reader.GetInt32(4),
                        V_SKILLSREQUIRED = reader.GetString(5).Split(',').ToList(),
                    });
                }
            }

            return jobs;
        }

        private void lstJobs_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            if (e.Index < 0 || e.Index >= lstJobs.Items.Count) return;
            var job = lstJobs.Items[e.Index] as Vacancy;
            if (job == null) return;

            using (var titleFont = new System.Drawing.Font(lstJobs.Font, System.Drawing.FontStyle.Bold))
            using (var descFont = new System.Drawing.Font(lstJobs.Font, System.Drawing.FontStyle.Regular))
            {
                // Measure title
                var titleSize = e.Graphics.MeasureString(job.V_JOBTITLE, titleFont, lstJobs.Width);
                // Measure description
                var descSize = e.Graphics.MeasureString(job.V_JOBDESCRIPTION, descFont, lstJobs.Width);

                // Set item height (add some padding)
                e.ItemHeight = (int)(titleSize.Height + descSize.Height + 8);
            }
        }

        private void lstJobs_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (e.Index < 0 || e.Index >= lstJobs.Items.Count) return;

            var job = lstJobs.Items[e.Index] as Vacancy;
            if (job == null) return;

            // Colors
            var titleColor = System.Drawing.Color.Black;
            var descColor = System.Drawing.Color.DimGray;

            // Fonts
            using (var titleFont = new System.Drawing.Font(lstJobs.Font.FontFamily, lstJobs.Font.Size + 2, System.Drawing.FontStyle.Bold))
            using (var descFont = new System.Drawing.Font(lstJobs.Font, System.Drawing.FontStyle.Regular))
            using (var titleBrush = new System.Drawing.SolidBrush(titleColor))
            using (var descBrush = new System.Drawing.SolidBrush(descColor))
            {
                float y = e.Bounds.Top + 2;
                // Draw title
                e.Graphics.DrawString(job.V_JOBTITLE, titleFont, titleBrush, e.Bounds.Left + 4, y);
                y += e.Graphics.MeasureString(job.V_JOBTITLE, titleFont, lstJobs.Width).Height;
                // Draw description
                e.Graphics.DrawString(job.V_JOBDESCRIPTION, descFont, descBrush, e.Bounds.Left + 4, y);
            }

            e.DrawFocusRectangle();
        }

        private void lstJobs_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lstJobs.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches && lstJobs.Items[index] is Vacancy selectedVacancy)
            {
                // Open the job details form and pass the selected vacancy
                using (var jobDetailsForm = new JobDetailsForm(selectedVacancy))
                {
                    jobDetailsForm.ShowDialog(this);
                }
            }
        }

        public void ApplyToSelectedJob(Vacancy selectedVacancy)
        {
            int seekerId = _seekerId; // Use the instance field

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                // 1. Insert into APPLICATION
                string insertApp = "INSERT INTO APPLICATION (VACANCYID, _STATUS, IS_ACTIVE) OUTPUT INSERTED.APP_ID_ VALUES (@VacancyId, @Status, @IsActive)";
                int appId;
                using (SqlCommand cmd = new SqlCommand(insertApp, conn))
                {
                    cmd.Parameters.AddWithValue("@VacancyId", selectedVacancy.VACANCYID);
                    cmd.Parameters.AddWithValue("@Status", "Pending");
                    cmd.Parameters.AddWithValue("@IsActive", 1);
                    appId = (int)cmd.ExecuteScalar();
                }

                // 2. Insert into APPLIES
                string insertApplies = "INSERT INTO APPLIES (SEEKERID, APP_ID_, DATE) VALUES (@SeekerId, @AppId, @Date)";
                using (SqlCommand cmd = new SqlCommand(insertApplies, conn))
                {
                    cmd.Parameters.AddWithValue("@SeekerId", seekerId);
                    cmd.Parameters.AddWithValue("@AppId", appId);
                    cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Application submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}














