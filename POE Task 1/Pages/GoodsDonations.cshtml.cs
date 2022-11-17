using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Data.SqlClient;

namespace POE_Task_1.Pages
{
    [Authorize]
    public class GoodsDonationsModel : PageModel
    {
        public GoodsDonations goodsDonations = new GoodsDonations();
        public string errorMessage = "";
        public string successMessage = "";
        public void OnGet()
        {
        }

        public void OnPost()
        {
            goodsDonations.donor = Request.Form["donor"];
            goodsDonations.date = Request.Form["date"];
            goodsDonations.numberofitems = Request.Form["numberofitems"];
            goodsDonations.category = Request.Form["category"];
            goodsDonations.description = Request.Form["description"];

            if (goodsDonations.donor.Length == 0 || goodsDonations.date.Length == 0 || 
                goodsDonations.numberofitems.Length == 0 ||goodsDonations.category.Length == 0 || 
                goodsDonations.description.Length == 0)
            {
                errorMessage = "All the fields are required";
                return;
            }

            //save the new disaster into the database

            try
            {
                insertGoodsDonation();
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }

            clearGoodsFeilds();
        }

        public void clearGoodsFeilds()
        {
            goodsDonations.date = "";
            goodsDonations.numberofitems = "";
            goodsDonations.category = "";
            goodsDonations.description = "";
            goodsDonations.donor = "";
            successMessage = "New Donation Made Succesfully";
        }

        public void insertGoodsDonation()
        {
            string connectionString = "Data Source=LAPTOP-EJ02DD7T\\SQLEXPRESS;Initial Catalog=CLIENTS;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "INSERT INTO GoodsDonations " + "(Donor, Date, NumberOfItems, Category, Description) VALUES " + "(@donor, @date, @numberofitems, @category, @description);";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@donor", goodsDonations.donor);
                    command.Parameters.AddWithValue("@date", goodsDonations.date);
                    command.Parameters.AddWithValue("@numberofitems", goodsDonations.numberofitems);
                    command.Parameters.AddWithValue("@category", goodsDonations.category);
                    command.Parameters.AddWithValue("@description", goodsDonations.description);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
