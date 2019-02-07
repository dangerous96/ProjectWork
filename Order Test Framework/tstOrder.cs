using System;
using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Order_Test_Framework
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //test to see that is exists 
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        
        public void OrderNoPropertyOK()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property 
            Int32 OrderNo = 1;
            //assign the data to the property 
            AnOrder.OrderNo = OrderNo;
            //test to see that the two values are the same 
            Assert.AreEqual(AnOrder.OrderNo, OrderNo);
        }

        [TestMethod]
        public void CustomerNoPropertyOK()
        {
            //create an instance of the class we want to create 
            clsOrder ACustomer = new clsOrder();
            //create some test data to assign to the property 
            Int32 CustomerNo = 1;
            //assign the data to the property 
            ACustomer.CustomerNo = CustomerNo;
            //test to see that the two values are the same 
            Assert.AreEqual(ACustomer.CustomerNo, CustomerNo);
        }

        [TestMethod]
        public void OrderLineNoPropertyOK()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property 
            Int32 OrderLineNo = 1;
            //assign the data to the property 
            AnOrder.OrderLineNo = OrderLineNo;
            //test to see that the two values are the same 
            Assert.AreEqual(AnOrder.OrderLineNo, OrderLineNo);
        }

        [TestMethod]
        public void DatePlacedPropertyOK()
        {
            //create an instance of the class we want to create 
            clsOrder ADate = new clsOrder();
            //create some test data to assign to the property 
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property 
            ADate.DatePlaced = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(ADate.DatePlaced, TestData);
        }

        [TestMethod]
        public void QuantityPropertyOK()
        {
            //create an instance of the class we want to create 
            clsOrder AQuantity = new clsOrder();
            //create some test data to assign to the property 
            Int32 Quantity = 1;
            //assign the data to the property 
            AQuantity.Quantity = Quantity;
            //test to see that the two values are the same 
            Assert.AreEqual(AQuantity.Quantity, Quantity);
        }

        [TestMethod]
        public void ShippingAddressPropertyOK()
        {
            //create an instance of the class we want to create 
            clsOrder AnAddress = new clsOrder();
            //create some test data to assign to the property 
            string TestData = "Some Address";
            //assign the data to the property 
            AnAddress.ShippingAddress = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnAddress.ShippingAddress, TestData);
        }

        [TestMethod]
        public void TotalPricePropertyOK()
        {
            //create an instance of the class we want to create 
            clsOrder APrice = new clsOrder();
            //create some test data to assign to the property 
            Int32 TotalPrice = 1; 
            //assign the data to the property 
            APrice.TotalPrice = TotalPrice;
            //test to see that the two values are the same 
            Assert.AreEqual(APrice.TotalPrice, TotalPrice);
        }

        
    }
}
