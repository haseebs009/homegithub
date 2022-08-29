using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;

namespace assignstudent
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public static List<Student> studentsList = new List<Student>();
        protected void Page_Load(object sender, EventArgs e)
        {
            studentsList.Add(new Student("Haseeb", "35", "a1","0305569897", "19-A, davis road"));
            studentsList.Add(new Student("Shahzad", "18", "a2", "0305569897", "19-A, davis road"));
            studentsList.Add(new Student("Hamza", "28", "a3", "0305569897", "19-A, davis road"));
            studentsList.Add(new Student("Ali", "35", "a4", "0305569897", "19-A, davis road"));
            studentsList.Add(new Student("Abdulla", "30", "a5", "0305569897", "19-A, davis road"));
            studentsList.Add(new Student("khurum", "35", "a6", "0305569897", "19-A, davis road"));
            studentsList.Add(new Student("Khalid", "18", "a7", "0305569897", "19-A, davis road"));
            studentsList.Add(new Student("Usama", "28", "a8", "0305569897", "19-A, davis road"));
            studentsList.Add(new Student("Ali", "35", "a9", "0305569897", "19-A, davis road"));
            studentsList.Add(new Student("Abdulla", "30", "a10", "0305569897", "19-A, davis road"));
            if (!this.IsPostBack)
            {

                DropDownList1.DataSource = studentsList;
                DropDownList1.DataTextField = "name";
                DropDownList1.DataValueField = "id";
                DropDownList1.DataBind();
            }
        }
        [WebMethod]
        public static string Studentdata(string inputValue)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            foreach (var stu in studentsList)
            {
                if (stu.id==inputValue)
                {
                    
                    return js.Serialize(stu);
                }
            }
            return "";
        }     
    }


  
}