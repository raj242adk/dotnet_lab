using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace SecondCrudOperation.Controllers
{
    public class DeleteController : Controller
    {
        private string connectionString = "Server=THOMASRAJ\\SQLEXPRESS;Database=tbl_student;Integrated Security=True;TrustServerCertificate=True";
        public IActionResult Delete(int id)
        {


            try
            {
                //Creating the connection
                SqlConnection conn = new SqlConnection(connectionString);
                //Opening the connection
                conn.Open();

                //Creating the query 
                string deleteQuery = @"DELETE FROM tbl_student WHERE id=@id";

                //Executing the query
                SqlCommand cmd = new SqlCommand(@deleteQuery, conn);
                cmd.Parameters.AddWithValue("id", id);
                cmd.ExecuteNonQuery();


                //Closing the connection
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return RedirectToAction("DisplayAll","Student");
        }

    }
}
