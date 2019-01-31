using System;

namespace ClassLibrary1
{
    public class clsOrder
    {
        public clsOrder()
        {
        }

        public int OrderNo { get; set; }
        public int CustomerNo { get; set; }
        public int OrderLineNo { get; set; }
        public DateTime DatePlaced { get; set; }
        public int Quantity { get; set; }
        public string ShippingAddress { get; set; }
        public int TotalPrice { get; set; }
    }
}