using System.Collections.Generic;

namespace deneme_design.Model
{
    public class Category
    {
        
        public long id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public List<FoodItem> foodItemList { get; set; }

        public Category() {}
        public Category(long id, string name, bool deleted, List<FoodItem> foodItemList)
        {
            this.id = id;
            this.name = name;
            this.deleted = deleted;
            this.foodItemList = foodItemList;
        }
        public Category(string name, bool deleted)
        {
            this.name = name;
            this.deleted = deleted;
        }
    }
}
