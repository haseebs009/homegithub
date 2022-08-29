using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _TestProject
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string FirstNumber = Request["FirstNumber"];
            string SecondNumber = Request["SecondNumber"];
            string Result = Request["Result"];
            string operation = Request["operation"];
            response.InnerHtml = FirstNumber+" "+ operation + " " + SecondNumber + " =  " + Result;

        }
    }
}