using System;

namespace TrainersClasses
{
    public class clsOrder
    {
        public DateTime DateAdded { get; set; }
        public int OrderNo { get; set; }
        public int CustomerID { get; set; }
        public string DeliveryTown { get; set; }
        public string OrderStatus { get; set; }
        public int OrderValue { get; set; }
    }
}