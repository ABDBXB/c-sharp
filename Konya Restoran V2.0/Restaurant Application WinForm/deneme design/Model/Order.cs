using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme_design.Model
{
    public class Order
    {
        public long id { get; set; }
        public bool _status { get; set; }
        public DateTime startingDate { get; set; }
        public DateTime closingDate { get; set; }
        public Table table { get; set; }
        public List<FoodItem_Order> FoodOrderList { get; set; }

        public Order(long id, bool status, DateTime statingDate, DateTime closingDate, Table table, List<FoodItem_Order> foodOrderList)
        {
            this.id = id;
            _status = status;
            this.startingDate = statingDate;
            this.closingDate = closingDate;
            this.table = table;
            this.FoodOrderList = foodOrderList;
        }

        public Order() {}
    }
}
