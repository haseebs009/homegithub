using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cars
{
      public class Car
    {
        public string carId { get; set; }
        public string carName { get; set; }
        public string modelYear { get; set; }

        public Car(string carId, string carName, string modelYear)
        {
            this.carId = carId;
            this.carName = carName;
            this.modelYear = modelYear;
        }
    }
}