using System;
using System.Collections.Generic;

namespace EPPlusCore.Models.DBF
{
    public partial class Customers
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerCountry { get; set; }
    }
}
