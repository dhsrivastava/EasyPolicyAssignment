using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EasyPolicyAssignment.Business;

namespace EasyPolicyAssignment.Tests
{
    [TestClass]
    public class CustomerDiscountTest
    {
        double totalBill = 1000;
        [TestMethod]
        public void DiscountForNormalCustomer_WithGrocery()
        {
            var customerType = "N";
            var isGrocery = true;
            var customerAssociation = 2;
            CustomerBL bl = new CustomerBL();
            double actual = 950;
            double expected = bl.GetNetPayment(totalBill, customerType, customerAssociation, isGrocery);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DiscountForEmployeeCustomer_WithGrocery()
        {
            var customerType = "E";
            var isGrocery = true;
            var customerAssociation = 2;
            CustomerBL bl = new CustomerBL();
            double actual = 950;
            double expected = bl.GetNetPayment(totalBill, customerType, customerAssociation, isGrocery);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DiscountForAffiliatedCustomer_WithGrocery()
        {
            var customerType = "A";
            var isGrocery = true;
            var customerAssociation = 2;
            CustomerBL bl = new CustomerBL();
            double actual = 950;
            double expected = bl.GetNetPayment(totalBill, customerType, customerAssociation, isGrocery);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DiscountForNormalCustomer_WithoutGroceryAndCustomerAssociationOverTwoYears()
        {
            var customerType = "N";
            var isGrocery = false;
            var customerAssociation = 3;
            CustomerBL bl = new CustomerBL();
            double actual = 900;
            double expected = bl.GetNetPayment(totalBill, customerType, customerAssociation, isGrocery);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DiscountForNormalCustomer_WithoutGroceryAndCustomerAssociationLessThanOrEqualToTwoYears()
        {
            var customerType = "N";
            var isGrocery = false;
            var customerAssociation = 2;
            CustomerBL bl = new CustomerBL();
            double actual = 950;
            double expected = bl.GetNetPayment(totalBill, customerType, customerAssociation, isGrocery);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DiscountForEmployeeCustomer_WithoutGrocery()
        {
            var customerType = "E";
            var isGrocery = false;
            var customerAssociation = 2;
            CustomerBL bl = new CustomerBL();
            double actual = 650;
            double expected = bl.GetNetPayment(totalBill, customerType, customerAssociation, isGrocery);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DiscountForAffiliatedCustomer_WithoutGrocery()
        {
            var customerType = "A";
            var isGrocery = false;
            var customerAssociation = 2;
            CustomerBL bl = new CustomerBL();
            double actual = 850;
            double expected = bl.GetNetPayment(totalBill, customerType, customerAssociation, isGrocery);
            Assert.AreEqual(expected, actual);
        }
    }
}
