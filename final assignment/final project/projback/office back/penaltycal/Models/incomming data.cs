﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace penaltycal.Models
{
    public class incomming_data
    {
        // Interface to declare variables of incomming data
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Country { get; set; }
    }
}