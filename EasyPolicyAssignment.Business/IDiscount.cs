using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPolicyAssignment.Business
{
    public interface IDiscount
    {
        double GetDiscount(double totalBill, bool isGrocery, int customerAssociation = 0);
    }
}
