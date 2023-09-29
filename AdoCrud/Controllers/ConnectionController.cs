using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using AdoCrud.Models; // Import your Student model namespace

namespace AdoCrud.Controllers
{
    public class ConnectionController : Controller
    {
        private readonly string connectionString = "Server=THOMASRAJ\\SQLEXPRESS;Database=tbl-student;Integrated Security=True;TrustServerCertificate=True";

        public IActionResult Index()
        {
            // Setting up the connection
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                // Opening the connection
                conn.Open();

                // Creating a list to store all the retrieved students
                List<Student> students = new List<Student>();

                string readCmd = "SELECT * FROM [tbl-student];";
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
                            std.Id = (int)reader["id"];
                            std.Name = (string)reader["name"];
                            std.Gender = (string)reader["gender"];
                            std.Faculty = (string)reader["faculty"];
                            std.Grade = (int)reader["grade"];
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

