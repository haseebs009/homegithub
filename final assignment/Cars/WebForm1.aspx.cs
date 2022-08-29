using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.Services;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;

namespace Cars
{
    public partial class WebForm1 : System.Web.UI.Page
    {
     
        public static List<Car> carList = new List<Car>();
        protected void Page_Load(object sender, EventArgs e)
        {
            carList = CreateCarList();
        }
        public List<Car> CreateCarList()
        {
            List<Car> carLi = new List<Car>();
            Car Carprop;

            Carprop = new Car("a1", "land cruiser", "2022");
            carLi.Add(Carprop);
            Carprop = new Car("a2", "corolla", "2022");
            carLi.Add(Carprop);
            Carprop = new Car("a3", "mehran", "2022");
            carLi.Add(Carprop);
            Carprop = new Car("a4", "city", "2022");
            carLi.Add(Carprop);
            Carprop = new Car("a5", "brv", "2022");
            carLi.Add(Carprop);
            Carprop = new Car("a6", "crv", "2022");
            carLi.Add(Carprop);
            Carprop = new Car("a7", "alto", "2022");
            carLi.Add(Carprop);
            Carprop = new Car("a8", "alsvin", "2022");
            carLi.Add(Carprop);
            Carprop = new Car("a9", "oshan", "2022");
            carLi.Add(Carprop);
            Carprop = new Car("a10", "fortuner", "2022");
            carLi.Add(Carprop);
            return carLi;
        }
        [WebMethod]
        public static string SearchCar(string inputname)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            List<string> CarSuggest = new List<string>();
            foreach (var car in carList)
            {
                if (car.carName.Contains(inputname))
                {
                    CarSuggest.Add(car.carName);
                    return js.Serialize(CarSuggest);
                }
            }
            return "";
        }
    }

}
