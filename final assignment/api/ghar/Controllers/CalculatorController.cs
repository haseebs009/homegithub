using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using penaltycal.Models;

namespace penaltycal.Controllers
{
    public class CalculatorController : ApiController
    {
            string strcon = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
       

        //For Post request 
        [HttpPost]
        [Route("postdate")]
        public string Postdata([FromBody] date obj)
        {
            List<DateTime> holidayList = new List<DateTime>();
            int tax;
            string currency="";
            //validations try catch
            try
            {
                
                using (SqlConnection connection = new SqlConnection(strcon))
                {
                    string query1 = "getinfo";

                    string country = "Pakistan";
                    //string query = "SELECT * FROM Calculator where country='Pakistan'";
                    string query2 = "SELECT * FROM Calculator where country='Pakistan'";

                    using (SqlCommand cmd = new SqlCommand(query1, connection))
                    {
                        // string country = "Pakistan";
                        connection.Open();
                        cmd.Parameters.AddWithValue("@country", SqlDbType.VarChar).Value = country;
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataReader sdr = cmd.ExecuteReader();

                        while (sdr.Read())
                        {
                            date dateobj = new date();
                            dateobj.day = Convert.ToInt32(sdr["holidayDay"]);
                            dateobj.month = Convert.ToInt32(sdr["holidayMonth"]);
                            holidayList.Add(new DateTime(DateTime.Now.Year, dateobj.month, dateobj.day));
                        }



                        //calobj.tax = Convert.ToInt32(sdr["tax"]);
                        //calobj.currency = Convert.ToString(sdr["currency"]);
                        connection.Close();
                    }
                    using (SqlCommand cmd2 = new SqlCommand(query2, connection))
                    {
                        // string country = "Pakistan";
                        connection.Open();
                        //  cmd.Parameters.AddWithValue("@country", SqlDbType.VarChar).Value = country;
                        //   cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataReader sdr2 = cmd2.ExecuteReader();

                        while (sdr2.Read())
                        {
                            
                            tax = Convert.ToInt32(sdr2["tax"]);
                            currency = Convert.ToString(sdr2["currency"]);
                        }

                    }

                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            DateTime startDate = Convert.ToDateTime("07/1/2022");
            DateTime endDate = Convert.ToDateTime("07/31/2022");
            int days = 0;

            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                if (startDate.DayOfWeek != DayOfWeek.Saturday && startDate.DayOfWeek != DayOfWeek.Sunday && !holidayList.Contains(date))
                {
                    days++;
                }
                startDate = startDate.AddDays(1);
            }
            //Response.Write("Number of days between " + Convert.ToDateTime(txtStartDate.Text).ToShortDateString() + " and "
            //    + Convert.ToDateTime(txtEndDate.Text).ToShortDateString() + " excluding special holiday is " + days.ToString());
            // Calculator getPenalty = new Calculator;
            // getPenalty.penaltyCalculator(days, 0.08);
            return currency.ToString();
        }
            
    }
}
