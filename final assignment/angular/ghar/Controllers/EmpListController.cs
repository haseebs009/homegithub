using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Caching;
using System.Web.Http;
using employee_api_backend.Models;

namespace employee_api_backend.Controllers
{
    public class EmpListController : ApiController
    {
        string strcon = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
       //For Post request 
        [HttpPost]
        [Route("postemp")]
        public bool Postdata([FromBody] employeedetail emp )
        {
            //validations try catch
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(strcon))
                {

                    sqlCon.Open();
                    string query = "INSERT INTO EmployeeList (Name,Designation) VALUES (@Name,@Designation)";
                    SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                    sqlCmd.Parameters.AddWithValue("@Name", emp.Name);
                    sqlCmd.Parameters.AddWithValue("@Designation", emp.Designation);
                    sqlCmd.ExecuteNonQuery();

                }
            }

            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            return true;
        }

        //For Put request 
        [HttpPut]
        [Route("update")]
        public bool Putdata([FromBody]  employeedetail emp)
        {
            //validations try catch

            try
            {
                using (SqlConnection sqlCon = new SqlConnection(strcon))
                {

                    sqlCon.Open();
                    string query = " UPDATE EmployeeList SET Name=@Name,Designation=@Designation WHERE id = @id";
                    SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                    sqlCmd.Parameters.AddWithValue("@id", emp.ID);
                    sqlCmd.Parameters.AddWithValue("@Name", emp.Name);
                    sqlCmd.Parameters.AddWithValue("@Designation", emp.Designation);
                    sqlCmd.ExecuteNonQuery();

                }
            }  
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            return true;
        }
        //For Delete request 
        [HttpDelete]
        [Route("delete")]
        public bool Delete([FromUri]int id)
        {
            //validations try catch
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(strcon))
                {

                    sqlCon.Open();
                    string query = "Delete from EmployeeList where id=@id";
                    SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                    sqlCmd.Parameters.AddWithValue("@id", id);
                    sqlCmd.ExecuteNonQuery();
                    
                }
            }

            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            return true;

        }

        //For Get request 

        [Route("Emplist")]
        public List<Employee> Getstudents()
        {
            //List to be used
            List<Employee> EmpList = new List<Employee>();
            //validations try catch
            try
            {
 
                using (SqlConnection connection = new SqlConnection(strcon))
                {
                    string query = "Select ID,Name from EmployeeList";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        SqlDataReader sdr = cmd.ExecuteReader();


                        while (sdr.Read())
                        {
                            Employee em = new Employee();
                            em.ID = Convert.ToInt32(sdr["ID"]);
                            em.Name = sdr["Name"].ToString().Trim();
                            EmpList.Add(em);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            return EmpList;
        }

        //For Get request using id
    [Route("EmpDetail")]
        public List<employeedetail> Getstudents([FromUri] int id)
        {
            List<employeedetail> EmpList = new List<employeedetail>();

            //validations try catch
            try
            {

                //List to be used

                using (SqlConnection connection = new SqlConnection(strcon))
                {
                    string query = "Select * from EmployeeList where ID=" + id.ToString();

                    //  "sp_record"
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        SqlDataReader sdr = cmd.ExecuteReader();


                        while (sdr.Read())
                        {
                            employeedetail em = new employeedetail();
                            em.ID = Convert.ToInt32(sdr["ID"]);
                            em.Name = sdr["Name"].ToString().Trim();
                            em.Designation = sdr["Designation"].ToString().Trim();
                            EmpList.Add(em);
                        }


                    }
                }
            }                                
               catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            return EmpList;
        }                  

    }
}
