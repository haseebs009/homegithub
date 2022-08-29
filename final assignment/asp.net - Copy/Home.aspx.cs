using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _TestProject
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            cal();
        }
        private void cal()
        {
            double n = 0;
            double n1 = Convert.ToDouble(TextBox1.Text);
            double n2 = Convert.ToDouble(TextBox2.Text);
            switch (DropDownList1.SelectedValue)
            {
            case "%2B":
                    n = n1 + n2;
                    break;
            case "*":
                    n = n1 * n2;
                    break;
            case "/":
                    n = n1 / n2;
                    break;
            case "-":
                    n = n1 - n2;
                    break;
            }
            {
               Response.Redirect("page2.aspx?&FirstNumber=" + n1 + "&SecondNumber=" + n2 + "&operation="+ DropDownList1.SelectedValue+ "&Result=" + n );
            }

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}