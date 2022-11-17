using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Data.SqlClient;

namespace POE_Task_1.Pages
{
    public class PurchaseGoodsModel : PageModel
    {
        public Inventory inventory = new Inventory();
        public string errorMessage = "";
        public string successMessage = "";
        public decimal availableMoney;

        public void OnGet()
        {
            try
            {
                getTotalMoneyDonations();
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
                PurchaseGoods();
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }

            clearPurchaseGoodsFields();
        }

        public void getTotalMoneyDonations()
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

        public void clearPurchaseGoodsFields()
        {
            inventory.goodsname.Equals("");
            successMessage = "Purchase Made Succesfully";
        }

        public void PurchaseGoods()
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

        public decimal decrementTotal(decimal a, decimal b)
        {
            a = availableMoney;
            b = inventory.goodsprice;
            decimal total = a - (b);
            return total;
        }
    }
}
