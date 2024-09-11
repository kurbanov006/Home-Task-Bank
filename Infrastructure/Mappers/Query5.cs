using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Mappers
{
    public class Query5
    {
        public int Accountid { get; set; }
        public int Customerid { get; set; }
        public string AccountNumber { get; set; } = null!;
        public string AccountType { get; set; } = null!;
        public decimal Balance { get; set; }
        public decimal Summ { get; set; }
    }
}