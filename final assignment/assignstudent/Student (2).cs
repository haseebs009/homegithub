using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace assignstudent
{
    public class Student
    {
        public string name { get; set; }
        public string id { get; set; }
        public string marks { get; set; }
        public string contactno { get; set; }
        public string address { get; set; }

        public Student(string name, string marks, string id, string contactno, string address)
        {
            this.name = name;
            this.marks = marks;
            this.id = id;
            this.contactno=contactno;
            this.address = address;
        }
    }
}