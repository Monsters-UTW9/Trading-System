using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class user
    {
        
        public int Id { get; set; }
        public string name_ar { get; set; }
        public string username { get; set; }
        public bool lock_user { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public bool type { get; set; }
        public string answer { get; set; }
        public int question_id { get; set; }
        public string mobile { get; set; }
        public byte[] photo { get; set; }
        public string name_en { get; set; }
    }
}
