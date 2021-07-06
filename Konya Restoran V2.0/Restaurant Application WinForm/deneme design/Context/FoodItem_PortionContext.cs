using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme_design.Context
{
    class FoodItem_PortionContext
    {
        public long id { get; set; }
        public string portionName { get; set; }
        public float ratio { get; set; }
        public float quantity { get; set; }
        public long foodItemId { get; set; }
        public long portionId { get; set; }
        public float price { get; set; }
        

        public FoodItem_PortionContext() {}
        public FoodItem_PortionContext(long id, string portionName, float ration, float quantity, long foodItemId, long portionId, float price)
        {
            this.id = id;
            this.portionName = portionName;
            this.ratio = ration;
            this.quantity = quantity;
            this.foodItemId = foodItemId;
            this.portionId = portionId;
            this.price = price;
        }
    }
}
