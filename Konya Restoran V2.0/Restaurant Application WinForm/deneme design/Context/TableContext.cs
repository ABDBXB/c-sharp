using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme_design.Context
{
    class TableContext
    {
        public long tableId { get; set; }
        public int seatCount { get; set; }
        public TableContext(long tableId, int seatCount)
        {
            this.tableId = tableId;
            this.seatCount = seatCount;
        }
    }
}
