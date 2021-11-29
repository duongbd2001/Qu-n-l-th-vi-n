using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Vote
    {
        public string idVote { get; set; }
        public string idReader { get; set; }
        public string idLibrarian { get; set; }
        public string diposit { get; set; }
        public string borrowDate { get; set; }

        public string returnDate { get; set; }
    }
}
