using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notesAndLedgersApp.Shared
{
    public class CoinPurse
    {
        public int Id { get; set; } = 0;
        public int Gold { get; set; } = 0;
        public int Silver { get; set; } = 0;
        public int Copper { get; set; } = 0;
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}
