using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme_design.Context
{
    class ItemContext
    {
        public long id { get; set; }
        public float price { get; set; }
        public float quantity { get; set; }
        public string itemName { get; set; }
        public long foodItemPortionId { get; set; }
        public long categoryId { get; set; }
        public long imageId { get; set; }

        public ItemContext(long foodItem_PortionId,  float price, float quantity)
        {
            this.foodItemPortionId = foodItem_PortionId;
            this.id = id;
            this.price = price;
            this.quantity = quantity;
        }
        public ItemContext() { }
    }
}
