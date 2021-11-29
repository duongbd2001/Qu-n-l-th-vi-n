using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Book
    {
        public string id { get; set; }
        public string name { get; set; }
        public string author { get; set; }
        public string category { get; set; }
        public string publisher { get; set; }
        public int quantity { get; set; }
    }
}
