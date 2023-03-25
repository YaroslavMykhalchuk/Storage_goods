using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public class Goods
    {
        public string Name_goods { get; set; }
        public int? Type_goods_ID { get; set; }
        public int? Provider_ID { get; set; }
        public int Quantity_goods { get; set; }
        public int Prime_cost { get; set; }
        public DateTime Date_delivery { get; set; }
    }
}
