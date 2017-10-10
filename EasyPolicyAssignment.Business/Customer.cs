using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPolicyAssignment.Business
{
    public class Customer : IDiscount
    {
        public virtual double GetDiscount(double totalBill, bool isGrocery, int customerAssociation = 0)
        {
            return isGrocery == true ? 0 : customerAssociation <= 2 ? 0 : totalBill * 5 / 100;
        }
    }

    public class EmployeeCustomer : Customer
    {
        public override double GetDiscount(double totalBill, bool isGrocery, int customerAssociation)
        {
            return isGrocery == true ? 0 : totalBill * 30 / 100;
        }
    }

    public class AffliatedCustomer : Customer
    {
        public override double GetDiscount(double totalBill, bool isGrocery, int customerAssociation)
        {
            return isGrocery == true ? 0 : totalBill * 10 / 100;
        }
    }
}
