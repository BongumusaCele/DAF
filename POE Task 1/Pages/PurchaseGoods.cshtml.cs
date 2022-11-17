using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Data.SqlClient;

namespace POE_Task_1.Pages
{
    public class PurchaseGoodsModel : PageModel
    {
        public static Inventory inventory = new Inventory();
        public string errorMessage = "";
        public string successMessage = "";
        public static decimal availableMoney;

        public static decimal goodsprice;
        public static decimal totalMoney = decrementTotal();

        

        public void OnGet()
        {
            try
            {
                string connectionString = "Data Source=LAPTOP-EJ02DD7T\\SQLEXPRESS;Initial Catalog=CLIENTS;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlMonetary = "SELECT SUM(Amount) FROM MonetaryDonations";

                    using (SqlCommand command = new SqlCommand(sqlMonetary, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                availableMoney = reader.GetDecimal(0);
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }

        public void OnPost()
        {
            inventory.goodsname = Request.Form["goodsname"];
            inventory.goodsprice.Equals(Request.Form["goodsprice"]);

            if (inventory.goodsname.Length == 0)
            {
                errorMessage = "All the fields are required";
                return;
            }

            //save the new donation into the database

            try
            {
                string connectionString = "Data Source=LAPTOP-EJ02DD7T\\SQLEXPRESS;Initial Catalog=CLIENTS;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO Inventory " + "(GoodsName, GoodsPrice) VALUES " + "(@goodsname, @goodsprice);";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@goodsname", inventory.goodsname);
                        command.Parameters.AddWithValue("@goodsprice", inventory.goodsprice);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }

            inventory.goodsname.Equals("");
            successMessage = "Purchase Made Succesfully";

        }

        public static decimal decrementTotal()
        {
            decimal total = availableMoney;
            total = availableMoney - inventory.goodsprice;
            return total;
        }
    }
}
