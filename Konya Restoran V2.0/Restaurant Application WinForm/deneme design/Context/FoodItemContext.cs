using deneme_design.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme_design.Context
{
    class FoodItemContext
    {
        public string itemName { get; set; }
        public float quantity { get; set; }
        public long imageId { get; set; }
        public List<PortionContext> portionContextList { get; set; }
        public long categoryId { get; set; }

        public FoodItemContext(string itemName, float quantity, List<PortionContext> portionContextList, long imageId, long categoryId)
        {
            this.itemName = itemName;
            this.quantity = quantity;
            this.portionContextList = portionContextList;
            this.imageId = imageId;
            this.categoryId = categoryId;
        }

        public FoodItemContext() {}
    }
}
