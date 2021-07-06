using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme_design.Model
{
    public class FoodItem_Portion
    {
        public long id { get; set; }
        public float unitPrice { get; set; }
        public FoodItem foodItem { get; set; }
        public Portion portion { get; set; }
        public FoodItem_Portion(long id, float unitPrice, FoodItem foodItem, Portion portion)
        {
            this.id = id;
            this.unitPrice = unitPrice;
            this.foodItem = foodItem;
            this.portion = portion;
        }

        public FoodItem_Portion(float unitPrice, FoodItem foodItem, Portion portion)
        {
            this.unitPrice = unitPrice;
            this.foodItem = foodItem;
            this.portion = portion;
        }
        public FoodItem_Portion() {}
    }
}
