using AdoCrud.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace AdoCrud.Controllers
{
    public class AddController : Controller
        
    {
        private readonly string connectionString = "Server=THOMASRAJ\\SQLEXPRESS;Database=tbl-student;Integrated Security=True;TrustServerCertificate=True";

        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddStudent(Student student)

        {
           
            if (ModelState.IsValid)
            {
                try
                {
                     
                    //Creating the sql connection
                    SqlConnection connection = new SqlConnection(connectionString);


                    //Opening the connection
                    connection.Open();

                    //SQL Command
                    string addSql = "INSERT INTO tbl-student(Id, Name, Gender, Faculty, Grade) VALUES (@id, @name, @gender, @faculty, @grade)";


                    //Creating the sqlCommand
                    using (SqlCommand cmd = new SqlCommand(addSql, connection))
                    {
                        cmd.Parameters.AddWithValue("id", student.Id);
                        cmd.Parameters.AddWithValue("name", student.Name);
                        cmd.Parameters.AddWithValue("gender", student.Gender);
                        cmd.Parameters.AddWithValue("faculty", student.Faculty);
                        cmd.Parameters.AddWithValue("grade", student.Grade);

                        //Executing the query
                        cmd.ExecuteNonQuery();
                    }


                    //Closing the COnnection
                    connection.Close();
                }
                catch (SqlException ex)
                {
                    ViewBag.ErrorMsg = "Connection Failed: " + ex.Message;
                    return RedirectToAction("Index","Connection");
                }
            }
            return RedirectToAction("Index","Connection");
        }

    }
}
