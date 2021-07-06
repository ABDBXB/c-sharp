using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme_design.Context
{
    class FoodOrderContext
    {
        public long orderId { get; set; }
        public float quantity { get; set; }
        public float price { get; set; }
        public long foodItem_PortionId { get; set; }
        public long employeeId { get; set; }
        public List<ItemContext> itemList { get; set; }

        public FoodOrderContext() { }
        public FoodOrderContext(long orderId, List<ItemContext> itemList, long employeeId)
        {
            this.orderId = orderId;
            this.itemList = itemList;
            this.employeeId = employeeId;
        }

        public FoodOrderContext(long foodItem_PortionId, float price, float quantity)
        {
            this.foodItem_PortionId = foodItem_PortionId;
            this.price = price;
            this.quantity = quantity;
        }
     
        public FoodOrderContext(long orderId, float quantity, float price, long employeeId)
        {
            this.orderId = orderId;
            this.quantity = quantity;
            this.price = price;
            this.employeeId = employeeId;
        }
    }
}
