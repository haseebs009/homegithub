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

        public float penaltyCalculator(int days, int tax)
        {
            // Method to calculate penalty
            if(days>10)
            { 
            this.penalty = (days - 10) * 50 + (days - 10) * 50 * tax/100;
            return penalty;
            }
            else
            {
                return 0;
            }
        }
    }
}