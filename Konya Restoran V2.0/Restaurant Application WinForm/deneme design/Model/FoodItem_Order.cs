using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme_design.Model
{
    public class FoodItem_Order
    {
        public long id { get; set; }
        public FoodItem_Portion foodItem_portion {get; set;}
        public float price { get; set; }
        public float quantity { get; set; }
        public Employee employee { get; set; }

        public FoodItem_Order() {}

        public FoodItem_Order(long id, FoodItem_Portion foodItem_portion, float price, float quantity,  Employee employee)
        {
            this.id = id;
            this.foodItem_portion = foodItem_portion;
            this.price = price;
            this.quantity = quantity;         
            this.employee = employee;
        }
    }
}
