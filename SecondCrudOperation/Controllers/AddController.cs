using Microsoft.AspNetCore.Mvc;
using SecondCrudOperation.Models;
using System.Data.SqlClient;

namespace SecondCrudOperation.Controllers
{
    public class AddController : Controller
    {
        private readonly string connectionString = "Server=THOMASRAJ\\SQLEXPRESS;Database=tbl_student;Integrated Security=True;TrustServerCertificate=True";
        [HttpGet]
        public IActionResult AddStudents()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddStudents(Student student)

        {

            if (ModelState.IsValid)
            {
                try
                {
                    string connectionString = "Server=THOMASRAJ\\SQLEXPRESS;Database=tbl_student;Integrated Security=True;TrustServerCertificate=True"; // Replace with your actual connection string

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string addSql = "INSERT INTO tbl_student ( Name, Gender, Faculty, Grade) VALUES ( @name, @gender, @faculty, @grade)";

                        using (SqlCommand cmd = new SqlCommand(addSql, connection))
                        {
                           
                            cmd.Parameters.AddWithValue("@name", student.Name);
                            cmd.Parameters.AddWithValue("@gender", student.Gender);
                            cmd.Parameters.AddWithValue("@faculty", student.Faculty);
                            cmd.Parameters.AddWithValue("@grade", student.Grade);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Data inserted successfully
                                // You can handle success or redirect to another page here
                            }
                            else
                            {
                                ViewBag.ErrorMsg = "No rows were inserted. Please check your data and SQL statement.";
                                // You may want to handle the error or redirect to another page
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    ViewBag.ErrorMsg = "Connection Failed: " + ex.Message;
                    // Handle the error, show a message, or redirect to an error page
                }

            }
            return RedirectToAction("DisplayAll", "Student");
        }

    }
}


 