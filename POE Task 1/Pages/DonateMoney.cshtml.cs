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
            monetaryDonations.name = Request.Form["name"];
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
                insertMonetaryDonation();
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }

            clearMonetaryFeilds();
        }

        private void insertMonetaryDonation()
        {
            string connectionString = "Data Source=LAPTOP-EJ02DD7T\\SQLEXPRESS;Initial Catalog=CLIENTS;Integrated Security=True";

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

        private void clearMonetaryFeilds()
        {
            monetaryDonations.name = "";
            monetaryDonations.date = "";
            monetaryDonations.amount = "";
            successMessage = "New Donation Made Succesfully";
        }
    }
}
