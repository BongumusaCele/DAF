using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace POE_Task_1.Pages
{
    public class StatsModel : PageModel
    {
        public decimal availableMoney;
        public int numberofgoods;
        public int numberofdisaster;
        public List<Disasters> listDisasters = new List<Disasters>();
        public void OnGet()
        {
            try
            {
                string connectionString = "Data Source=LAPTOP-EJ02DD7T\\SQLEXPRESS;Initial Catalog=CLIENTS;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlMonetary = "SELECT SUM(Amount) FROM MonetaryDonations";
                    string sqlNumberOfGood = "SELECT SUM(NumberOfItems) FROM GoodsDonations";
                    string sqlNumberOfDisasters = "SELECT COUNT(ID) FROM Disasters";
                    string sqlDisasters = "SELECT * FROM Disasters";

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

                    using (SqlCommand command = new SqlCommand(sqlNumberOfGood, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                numberofgoods = reader.GetInt32(0);
                            }
                        }
                    }

                    using (SqlCommand command = new SqlCommand(sqlNumberOfDisasters, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                numberofdisaster = reader.GetInt32(0);
                            }
                        }
                    }

                    using (SqlCommand command = new SqlCommand(sqlDisasters, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Disasters disasters = new Disasters();
                                disasters.id = "" + reader.GetInt32(0);
                                disasters.startdate = reader.GetString(1);
                                disasters.enddate = reader.GetString(2);
                                disasters.location = reader.GetString(3);
                                disasters.description = reader.GetString(4);
                                disasters.aidtype = reader.GetString(5);
                                disasters.allocatedmoney = "" + reader.GetDecimal(6);
                                disasters.allocatedgoods = reader.GetString(7);

                                listDisasters.Add(disasters);
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
    }
}
