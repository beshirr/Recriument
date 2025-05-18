using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace recruitment
{
    internal class VacancyDAL

    {
        

        private static string connectionString = @"Data Source=DESKTOP-64V2LNS\SQLEXPRESS;Initial Catalog=recruitment;Integrated Security=True;Encrypt=True;";
        public static void inserVacancy(Vacancy vacancy)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"INSERT INTO Vacancy 
                                 (COMPANYID_, V_JOBTITLE, V_EXPERIENCEREQUIRED, V_JOBDESCRIPTION, V_SKILLSREQUIRED, V_SALARY, ISVISIBLE) 
                                 VALUES (@EmployerID, @JobTitle, ,@YearsofExperience, @JobDescription, @SkillsRequired, @Salary, @IsVisible)";


                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@EmployerID", vacancy.COMPANYID_);
                        cmd.Parameters.AddWithValue("@JobTitle", vacancy.V_JOBTITLE);
                        cmd.Parameters.AddWithValue("@YearsofExperience", vacancy.V_EXPERIENCEREQUIRED);
                        cmd.Parameters.AddWithValue("@JobDescription", vacancy.V_JOBDESCRIPTION);
                        cmd.Parameters.AddWithValue("@SkillsRequired", string.Join(",", vacancy.V_SKILLSREQUIRED));
                        cmd.Parameters.AddWithValue("@Salary", vacancy.V_SALARY);
                        cmd.Parameters.AddWithValue("@IsVisible", vacancy.ISVISIBLE);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                            Console.WriteLine("Vacancy inserted successfully.");
                        else
                            Console.WriteLine("No vacancy was inserted.");

                        

                    }




                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error inserting vacancy: " + ex.Message);

            }

        }
        public static void UpdateVacancy(Vacancy vacancy)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"UPDATE Vacancy SET 
                                COMPANYID_ = @CompanyID,
                                V_JOBTITLE = @JobTitle,
                                V_EXPERIENCEREQUIRED =@Years_of_Experience,
                                V_JOBDESCRIPTION = @JobDescription,
                                V_SKILLSREQUIRED = @SkillsRequired,
                                V_SALARY = @Salary,
                                ISVISIBLE = @IsVisible
                             WHERE VACANCYID = @VacancyID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@CompanyID", vacancy.COMPANYID_);
                        cmd.Parameters.AddWithValue("@JobTitle", vacancy.V_JOBTITLE);
                        cmd.Parameters.AddWithValue("@YearsofExperience", vacancy.V_EXPERIENCEREQUIRED);
                        cmd.Parameters.AddWithValue("@JobDescription", vacancy.V_JOBDESCRIPTION);
                        cmd.Parameters.AddWithValue("@SkillsRequired", vacancy.V_SKILLSREQUIRED);
                        cmd.Parameters.AddWithValue("@Salary", vacancy.V_SALARY);
                        cmd.Parameters.AddWithValue("@IsVisible", vacancy.ISVISIBLE);
                        cmd.Parameters.AddWithValue("@VacancyID", vacancy.VACANCYID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            Console.WriteLine("Vacancy updated successfully.");
                        else
                            Console.WriteLine("No vacancy was updated (check VacancyID).");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating vacancy: " + ex.Message);
            }
        }
        public static void DeleteVacancy(int vacancyID)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = "DELETE FROM Vacancy WHERE VACANCYID = @VacancyID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@VacancyID", vacancyID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            Console.WriteLine("Vacancy deleted successfully.");
                        else
                            Console.WriteLine("No vacancy found with the provided ID.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting vacancy: " + ex.Message);
            }
        }

        public static void HideVacancy(int vacancyID)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = "UPDATE Vacancy SET ISVISIBLE = 0 WHERE VACANCYID = @VacancyID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@VacancyID", vacancyID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            Console.WriteLine("Vacancy hidden successfully.");
                        else
                            Console.WriteLine("No vacancy found with the provided ID.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error hiding vacancy: " + ex.Message);
            }
        }
        public static void ShowVacancy(int vacancyID)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = "UPDATE Vacancy SET ISVISIBLE = 1 WHERE VACANCYID = @VacancyID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@VacancyID", vacancyID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            Console.WriteLine("Vacancy hidden successfully.");
                        else
                            Console.WriteLine("No vacancy found with the provided ID.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error hiding vacancy: " + ex.Message);
            }
        }
        public static List<Vacancy> GetVacanciesByCompanyId(int companyId)
        {
            List<Vacancy> vacancies = new List<Vacancy>();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"SELECT VACANCYID, COMPANYID_, V_JOBTITLE, V_JOBDESCRIPTION, V_SKILLSREQUIRED, V_EXPERIENCEREQUIRED, V_SALARY, ISVISIBLE 
                             FROM Vacancy WHERE COMPANYID_ = @CompanyID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@CompanyID", companyId);

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var vacancy = new Vacancy
                                {
                                    VACANCYID = (int)reader["VACANCYID"],
                                    COMPANYID_ = (int)reader["COMPANYID_"],
                                    V_JOBTITLE = reader["V_JOBTITLE"].ToString(),
                                    V_SALARY = Convert.ToDecimal(reader["V_SALARY"]),
                                    V_EXPERIENCEREQUIRED = Convert.ToInt32(reader["V_EXPERIENCEREQUIRED"]),
                                    V_SKILLSREQUIRED = reader["V_SKILLSREQUIRED"].ToString()
                    .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(s => s.Trim())
                    .ToList(),
                                    V_JOBDESCRIPTION = reader["V_JOBDESCRIPTION"].ToString(),
                                    ISVISIBLE = Convert.ToBoolean(reader["ISVISIBLE"])
                                };
                                vacancies.Add(vacancy);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching vacancies: " + ex.Message);
            }

            return vacancies;
        }

        public static Vacancy GetVacancyById(int vacancyID)
        {
            Vacancy vacancy = null;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"SELECT VACANCYID, COMPANYID_, V_JOBTITLE, V_JOBDESCRIPTION, V_SKILLSREQUIRED, V_EXPERIENCEREQUIRED, V_SALARY, ISVISIBILE 
                             FROM Vacancy WHERE VACANCYID = @VacancyID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@VacancyID", vacancyID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                vacancy = new Vacancy
                                {
                                    VACANCYID = reader.GetInt32(0),
                                    COMPANYID_ = reader.GetInt32(1),
                                    V_JOBTITLE = reader.GetString(2),
                                    V_JOBDESCRIPTION = reader.GetString(3),
                                    V_SKILLSREQUIRED = reader.GetString(4).Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(s => s.Trim())
                    .ToList(),
                                    V_EXPERIENCEREQUIRED = reader.GetInt32(5),
                                    V_SALARY = reader.GetDecimal(6),
                                    ISVISIBLE = reader.GetBoolean(7)
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching vacancy by ID: " + ex.Message);
            }

            return vacancy;
        }


        public static int GetCompanyIdByEmployerId(int employerId) 
        {
            int companyId = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT COMPANYID_ FROM EMPLOYER WHERE EMPLOYERID = @EmployerID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@EmployerID", employerId);
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                        companyId = Convert.ToInt32(result);
                }
            }
            return companyId;
        }





    }
}
