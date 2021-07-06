using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme_design.Context
{
    public class PortionContext
    {
        public long id { get; set; }
        public string name { get; set; }
        public float ratio { get; set; }
        public float unitPrice {get; set;}

        public PortionContext() {}

        public PortionContext(long id, string name, float ratio, float unitPrice)
        {
            this.id = id;
            this.name = name;
            this.ratio = ratio;
            this.unitPrice = unitPrice;
        }

        public PortionContext(string name, float ratio, float unitPrice)
        {
            this.name = name;
            this.ratio = ratio;
            this.unitPrice = unitPrice;
        }

        public override string ToString()
        {
            return "id: " + this.id + " name: " + this.name + " Ratio: " + this.ratio + " Price: " + this.unitPrice + "\n"; 
        }
    }
}
