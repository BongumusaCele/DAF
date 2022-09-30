using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Data.SqlClient;

namespace POE_Task_1.Pages
{
    public class AllocateGoodsModel : PageModel
    {
        public Disasters disasters = new Disasters();
        public string errorMessage = "";
        public string successMessage = "";

        public void OnGet()
        {
            string id = Request.Query["id"];

            try
            {
                string connectionString = "Data Source=LAPTOP-EJ02DD7T\\SQLEXPRESS;Initial Catalog=CLIENTS;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlDisasters = "SELECT * FROM Disasters WHERE ID=@id";

                    using (SqlCommand command = new SqlCommand(sqlDisasters, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                disasters.id = "" + reader.GetInt32(0);
                                disasters.startdate = reader.GetString(1);
                                disasters.enddate = reader.GetString(2);
                                disasters.location = reader.GetString(3);
                                disasters.description = reader.GetString(4);
                                disasters.aidtype = reader.GetString(5);
                                disasters.allocatedmoney = "" + reader.GetDecimal(6);
                                disasters.allocatedgoods = reader.GetString(7);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return;
            }
        }

        public void OnPost()
        {
            disasters.id = Request.Form["id"];
            disasters.allocatedgoods = Request.Form["allocatedgoods"];

            if (disasters.id.Length == 0 || disasters.allocatedgoods.Length == 0)
            {
                errorMessage = "All the fields are required";
                return;
            }

            try
            {
                string connectionString = "Data Source=LAPTOP-EJ02DD7T\\SQLEXPRESS;Initial Catalog=CLIENTS;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "Update Disasters " +
                                 "SET AllocatedGoods=@allocatedgoods" +
                                 "WHERE id=@id";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", disasters.id);
                        command.Parameters.AddWithValue("@allocatedgoods", disasters.allocatedgoods);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return;
            }

            Response.Redirect("/Monetary");
        }
    }
}
