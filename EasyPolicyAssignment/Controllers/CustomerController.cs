using EasyPolicyAssignment.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyPolicyAssignment.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetNetPayment(double totalBill, string customerType, int customerAssociation, bool isGrocery)
        {
            CustomerBL customerBL = new CustomerBL();
            var netPayment = customerBL.GetNetPayment(totalBill, customerType, customerAssociation, isGrocery);
            return Json(netPayment, JsonRequestBehavior.AllowGet);
        }
    }
}