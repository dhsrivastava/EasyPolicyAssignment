using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyPolicyAssignment.Models
{
    public class Customer
    {
        public double TotalBill { get; set; }
        public string CustomerType { get; set; }
        public int CustomerAssociation { get; set; }
        public bool Groceries { get; set; }
    }
}