using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme_design.Model
{
    public class Table
    {
        public long id { get; set; }
        public int seatCount { get; set; }
        public bool _status { get; set; }

        public Table() { }
        public Table(long id, int seatCount, bool status)
        {
            this.id = id;
            this.seatCount = seatCount;      
            _status = status;
        }
    }
}
