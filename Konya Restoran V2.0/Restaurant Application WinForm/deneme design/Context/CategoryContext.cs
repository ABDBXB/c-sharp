using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme_design.Context
{
    class CategoryContext
    {
        public long id { get; set; }
        public string name { get; set; }

        public CategoryContext() { }
        public CategoryContext(long id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
