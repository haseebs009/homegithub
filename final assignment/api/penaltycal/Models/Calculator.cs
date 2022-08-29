using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace penaltycal.Models
{
    public class Calculator
    {
        public int tax { get; set; }
        public int penalty { get; set; }
        public string currency { get; set; }

        public int penaltyCalculator(int days, int tax)
        {
            this.penalty=(days - 10) * 50 * tax;
            return penalty;
        }
     
    }

}