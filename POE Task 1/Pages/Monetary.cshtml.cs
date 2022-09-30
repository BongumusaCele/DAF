using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace POE_Task_1.Pages
{
    [Authorize]
    public class MonetaryModel : PageModel
    {
        public List<MonetaryDonations> listDonations = new List<MonetaryDonations>();
        public List<GoodsDonations> listGoodsDonations = new List<GoodsDonations>();
        public List<Disasters> listDisasters = new List<Disasters>();
        public void OnGet()
        {
            try
            {
                string connectionString = "Data Source=LAPTOP-EJ02DD7T\\SQLEXPRESS;Initial Catalog=CLIENTS;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlMonetary = "SELECT * FROM MonetaryDonations";
                    string sqlGoods = "SELECT * FROM GoodsDonations";
                    string sqlDisasters = "SELECT * FROM Disasters";

                    using (SqlCommand command = new SqlCommand(sqlMonetary, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                MonetaryDonations monetaryDonation = new MonetaryDonations();
                                monetaryDonation.id = "" + reader.GetInt32(0);
                                monetaryDonation.name = reader.GetString(1);
                                monetaryDonation.date = reader.GetString(2);
                                monetaryDonation.amount = "" + reader.GetDecimal(3);

                                listDonations.Add(monetaryDonation);
                            }
                        }
                    }

                    using (SqlCommand command = new SqlCommand(sqlGoods, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                GoodsDonations goodsDonation = new GoodsDonations();
                                goodsDonation.id = "" + reader.GetInt32(0);
                                goodsDonation.donor = reader.GetString(1);
                                goodsDonation.date = reader.GetString(2);
                                goodsDonation.numberofitems = "" + reader.GetInt32(3);
                                goodsDonation.category = reader.GetString(4);
                                goodsDonation.description = reader.GetString(5);

                                listGoodsDonations.Add(goodsDonation);
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
    public class MonetaryDonations
    {
        public string id;
        public string name;
        public string date;
        public string amount;
    }

    public class GoodsDonations 
    {
        public string id;
        public string donor;
        public string date;
        public string numberofitems;
        public string category;
        public string description;
    }

    public class Disasters 
    {
        public string id;
        public string startdate;
        public string enddate;
        public string location;
        public string description;
        public string aidtype;
    }
}
