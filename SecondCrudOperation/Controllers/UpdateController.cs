using Microsoft.AspNetCore.Mvc;
using SecondCrudOperation.Models;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace SecondCrudOperation.Controllers
{
   
    public class UpdateController : Controller
    {
        private string connectionString = "Server=THOMASRAJ\\SQLEXPRESS;Database=tbl_student;Integrated Security=True;TrustServerCertificate=True";
        [HttpGet]
        public IActionResult Edit(int id)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string sqlcmd = "SELECT * FROM tbl_student WHERE id=@id";
            SqlCommand command = new SqlCommand(sqlcmd, connection);


           // Add the student ID to the command parameters.
             command.Parameters.AddWithValue("@id", id);

            // Execute the command and get the results.
            SqlDataReader reader = command.ExecuteReader();

            // Create a new student object to store the results.
            Student student = new Student();

            // Read the results and populate the student object.
            if (reader.Read())
            {
                student.Id = reader.GetInt32(0);
                student.Name = reader.GetString(1);
                student.Gender = reader.GetString(2);
                student.Faculty = reader.GetString(3);
                student.Grade = reader.GetString(4);
            }

            // Close the reader and the connection.
            reader.Close();
            connection.Close();

            // Return the student object to the view.
            return View(student);
        }

        public IActionResult Edit(Student student)
        {
            //Creating the connection
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            //Opening the connection
            sqlConnection.Open();

            //Creating the update query
            string updateQuery = @"Update tbl_student SET
                           name = @name,
                            faculty = @faculty,
                            gender = @gender,
                            grade = @grade
                            WHERE id = @id";

            using (SqlCommand cmd = new SqlCommand(@updateQuery, sqlConnection))
            {
                cmd.Parameters.AddWithValue("name", student.Name);
                cmd.Parameters.AddWithValue("faculty", student.Faculty);
                cmd.Parameters.AddWithValue("gender", student.Gender);
                cmd.Parameters.AddWithValue("grade", student.Grade);
                cmd.Parameters.AddWithValue("id", student.Id);

                cmd.ExecuteNonQuery();
            }

            //Closing the connection
            sqlConnection.Close();
            return RedirectToAction("DisplayAll","Student");
        }
    }
}
   

