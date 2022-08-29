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
        [HttpGet]
        [Route("Getcountry")]

        public List<ICountry> Getstudents()
        {
            //List to be used
            List<ICountry> ListCountries = new List<ICountry>();
            //validations try catch
            try
            {
                using (SqlConnection connection = new SqlConnection(strcon))
                {
                    string query = "Select country from countryDetail";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        SqlDataReader sdr = cmd.ExecuteReader();

                        while (sdr.Read())
                        {
                            ICountry countryObj = new ICountry();
                       countryObj.country= sdr["country"].ToString().Trim();
                            ListCountries.Add(countryObj);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            return ListCountries;
        }

        //For Post request 
        [HttpPost]
        [Route("postdate")]

        public string Postdata([FromBody] incomming_data dataobj)
        {
           DateTime inStartDate = dataobj.StartDate;
           DateTime inEndDate = dataobj.EndDate;
           string inCountry = dataobj.Country;
            // List of holidays
            List<DateTime> holidayList = new List<DateTime>();
            int tax = 0;
            string currency = "";
            string weekend01 = "";
            string weekend02 = "";
            //validations try catch
            try
            {

                using (SqlConnection connection = new SqlConnection(strcon))
                {
                    string query1 = "getinfo";
                    string query2 = "getcountry";
                    string country = inCountry;

                    using (SqlCommand cmd = new SqlCommand(query1, connection))
                    {
                         
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

                        connection.Close();
                    }
                    using (SqlCommand cmd2 = new SqlCommand(query2, connection))
                    {
 
                        connection.Open();
                        cmd2.Parameters.AddWithValue("@country", SqlDbType.VarChar).Value = country;
                        cmd2.CommandType = CommandType.StoredProcedure;
                        SqlDataReader sdr2 = cmd2.ExecuteReader();

                        while (sdr2.Read())
                        {
                            tax = Convert.ToInt32(sdr2["tax"]);
                            currency = Convert.ToString(sdr2["currency"]);
                            weekend01= Convert.ToString(sdr2["weekend1"]);
                            weekend02= Convert.ToString(sdr2["weekend2"]);
                        }

                    }

                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            DateTime startDate = Convert.ToDateTime(inStartDate);
            DateTime endDate = Convert.ToDateTime(inEndDate);
            int days = 0;

            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
              
                if (startDate.DayOfWeek.ToString() != weekend01 && startDate.DayOfWeek.ToString() != weekend02 && !holidayList.Contains(date))
                {
                    days++;
                }
                startDate = startDate.AddDays(1);
            }
            Calculator calobj = new Calculator();
            float penalty = calobj.penaltyCalculator(days, tax);
            // 
            return (currency.ToString() + " "+ penalty.ToString());
        }
    }
}