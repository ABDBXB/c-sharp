using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme_design.Model
{
    public class FoodItem
    {
        public long id { get; set; }
        public string itemName { get; set; }
        public float quantity { get; set; }
        public bool deleted { get; set; }
        public List<Portion> portionList { get; set; }
        public ItemImages itemImages { get; set; }

        public FoodItem(long id, string itemName, float quantity, bool deleted, List<Portion> portionList, ItemImages itemImages)
        {
            this.id = id;
            this.itemName = itemName;
            this.quantity = quantity;
            this.deleted = deleted;
            this.portionList = portionList;
            this.itemImages = itemImages;
        }

        public FoodItem() { }

        public FoodItem(long id, string itemName, float quantity, bool deleted)
        {
            this.id = id;
            this.itemName = itemName;
            this.quantity = quantity;
            this.deleted = deleted;
        }

        public FoodItem(string itemName, float quantity, bool deleted, List<Portion> portionList, ItemImages itemImages)
        {
            this.itemName = itemName;
            this.quantity = quantity;
            this.deleted = deleted;
            this.portionList = portionList;
            this.itemImages = itemImages;
        }
    }
}
