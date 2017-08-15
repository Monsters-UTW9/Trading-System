using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Stock
    {
        public int Id { get; set; }
        public string name_en { get; set; }
        public int ISIN { get; set; }
        public double last_price { get; set; }
        public double close_price { get; set; }
        public int volume { get; set; }
        public string name_ar { get; set; }
    }
}
