using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class user_stock
    {
        public int Id { get; set; }
        public int user_id { get; set; }
        public int quantity { get; set; }
        public int stock_id { get; set; }
    }
}
