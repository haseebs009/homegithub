using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Student
{
    public partial class Student : System.Web.UI.Page
    {
        public string name;
        public double age;
        public string id;
        public Student(string name, double age, string id)
        {
            this.name = name;
            this.age = age;
            this.id = id;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Student> StudentList = new List<Student>();
            StudentList.Add(new Student("Mahesh Chand", 35, "A Prorammer's Guide to ADO.NET"));
            StudentList.Add(new Student("Neel Beniwal", 18, "Graphics Development with C#"));
            StudentList.Add(new Student("Praveen Kumar", 28, "Mastering WCF"));
            StudentList.Add(new Student("Mahesh Chand", 35, "Graphics Programming with GDI+"));
            StudentList.Add(new Student("Raj Kumar", 30, "Building Creative Systems"));
            DropDownList1.DataSource = StudentList;
            DropDownList1.DataTextField = name;
            DropDownList1.DataValueField = id;
            DropDownList1.DataBind();
        }




    }
}