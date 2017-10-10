using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPolicyAssignment.Business
{
    public interface ICustomerBL
    {
        double GetNetPayment(double totalBill, string customerType, int customerAssociation, bool isGrocery);
    }
}
