using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPolicyAssignment.Business
{
    public class CustomerBL: ICustomerBL
    {
        public double GetNetPayment(double totalBill, string customerType, int customerAssociation, bool isGrocery)
        {
            Customer cust;            

            double mandatoryDiscount = Math.Floor(totalBill / 100) * 5;
            double totalBillAfterMandatoryDiscount = totalBill - mandatoryDiscount;
            double netAmount = 0;
            if (customerType == "N")
            {
                cust = new Customer();
                netAmount = totalBillAfterMandatoryDiscount - cust.GetDiscount(totalBill, isGrocery, customerAssociation);
            }
            else if (customerType == "E")
            {
                cust = new EmployeeCustomer();
                netAmount = totalBillAfterMandatoryDiscount - cust.GetDiscount(totalBill, isGrocery, customerAssociation);
            }
            else if (customerType == "A")
            {
                cust = new AffliatedCustomer();
                netAmount = totalBillAfterMandatoryDiscount - cust.GetDiscount(totalBill, isGrocery, customerAssociation);
            }

            return netAmount;
        }
    }
}
