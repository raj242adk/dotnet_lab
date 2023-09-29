using Microsoft.AspNetCore.Mvc;
using SecondCrudOperation.Models;
using System.Data;
using System.Data.SqlClient;

namespace SecondCrudOperation.Controllers
{
    public class StudentController : Controller
    {
        private readonly string connectionString = "Server=THOMASRAJ\\SQLEXPRESS;Database=tbl_student;Integrated Security=True;TrustServerCertificate=True";
        public IActionResult DisplayAll()
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                // Opening the connection
                conn.Open();

                // Creating a list to store all the retrieved students
                List<Student> students = new List<Student>();

                string readCmd = "SELECT * FROM [tbl_student];";
                using (SqlCommand cmd = new SqlCommand(readCmd, conn))
                {
                    // Retrieving the data
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Reading all the data
                        while (reader.Read())
                        {
                            // Adding the data read to the student object
                            Student std = new Student();
                            std.Id = (int)reader["Id"];
                            std.Name = (string)reader["Name"];
                            std.Gender = (string)reader["Gender"];
                            std.Faculty = (string)reader["Faculty"];
                            std.Grade = (String)reader["Grade"];
                            // Adding the student to the list of students.
                            students.Add(std);
                        }
                    }
                }

                // Closing the connection
                conn.Close();

                return View(students);
            }

            finally
            {
                // Ensure that the connection is closed in case of exceptions
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}

