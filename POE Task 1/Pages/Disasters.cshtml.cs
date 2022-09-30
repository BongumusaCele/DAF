using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Data.SqlClient;

namespace POE_Task_1.Pages
{
    [Authorize]
    public class DisastersModel : PageModel
    {
        public Disasters disasters = new Disasters();
        public string errorMessage = "";
        public string successMessage = "";
        public void OnGet()
        {
        }

        public void OnPost()
        {
            disasters.startdate = Request.Form["startdate"];
            disasters.enddate = Request.Form["enddate"];
            disasters.location = Request.Form["location"];
            disasters.description = Request.Form["description"];
            disasters.aidtype = Request.Form["aidtype"];

            if (disasters.startdate.Length == 0 || disasters.enddate.Length == 0 || disasters.location.Length == 0 ||
                disasters.description.Length == 0 || disasters.aidtype.Length == 0)
            {
                errorMessage = "All the fields are required";
                return;
            }

            //save the new disaster into the database

            try
            {
                string connectionString = "Data Source=LAPTOP-EJ02DD7T\\SQLEXPRESS;Initial Catalog=CLIENTS;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO Disasters " + "(StartDate, EndDate, Location, Description, AidType) VALUES " + "(@startdate, @enddate, @location, @description, @aidtype);";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@startdate", disasters.startdate);
                        command.Parameters.AddWithValue("@enddate", disasters.enddate);
                        command.Parameters.AddWithValue("@location", disasters.location);
                        command.Parameters.AddWithValue("@description", disasters.description);
                        command.Parameters.AddWithValue("@aidtype", disasters.aidtype);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }

            disasters.startdate = "";
            disasters.enddate = "";
            disasters.location = "";
            disasters.description = "";
            disasters.aidtype = "";
            successMessage = "New Donation Made Succesfully";
        }
    }
}
