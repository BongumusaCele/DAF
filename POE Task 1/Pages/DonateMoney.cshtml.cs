using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Data.SqlClient;

namespace POE_Task_1.Pages
{
    [Authorize]
    public class DonateMoneyModel : PageModel
    {
        public MonetaryDonations monetaryDonations = new MonetaryDonations();
        public string errorMessage = "";
        public string successMessage = "";
        public void OnGet()
        {
        }

        public void OnPost()
        {
            monetaryDonations.name = Request.Form["names"];
            monetaryDonations.date = Request.Form["date"];
            monetaryDonations.amount = Request.Form["amount"];

            if(monetaryDonations.name.Length == 0 || monetaryDonations.date.Length == 0 || monetaryDonations.amount.Length == 0)
            {
                errorMessage = "All the fields are required";
                return;
            }

            //save the new donation into the database

            try
            {
                string connectionString = "Server=tcp:the-disaster-alleviation-foundation.database.windows.net,1433;Initial Catalog=The Disaster Alleviation Foundation;Persist Security Info=False;User ID=TDAFadmin;Password=Nomasonto>50;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO MonetaryDonations " + "(Name, Date, Amount) VALUES " + "(@name, @date, @amount);";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@name", monetaryDonations.name);
                        command.Parameters.AddWithValue("@date", monetaryDonations.date);
                        command.Parameters.AddWithValue("@amount", monetaryDonations.amount);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }

            monetaryDonations.name = "";
            monetaryDonations.date = "";
            monetaryDonations.amount = "";
            successMessage = "New Donation Made Succesfully";


        }
    }
}
