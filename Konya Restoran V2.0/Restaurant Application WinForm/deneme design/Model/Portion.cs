using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme_design.Model
{
    public class Portion
    {
        public long id { get; set; }
        public string name { get; set; }
        public float calculate { get; set; }
        public Portion(long id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public Portion()  {}

        public Portion(string name , float calculate)
        {
            this.name = name;
            this.calculate = calculate;
        }

        public Portion(long id, string name, float calculate) : this(id, name)
        {
            this.calculate = calculate;
        }

        public override bool Equals(object obj)
        {
            return obj is Portion portion &&
                   
                   name.Equals(portion.name, StringComparison.OrdinalIgnoreCase) &&
                   calculate == portion.calculate;
        }

        public override int GetHashCode()
        {
            var hashCode = -86447899;
            hashCode = hashCode * -1521134295 + id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + calculate.GetHashCode();
            return hashCode;
        }
    }
}
