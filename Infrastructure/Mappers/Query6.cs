using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Mappers
{
    public class Query6
    {
        public int Customerid { get; set; }
        public string FullName { get; set; } = null!;
        public int Appointmentid { get; set; }
        public DateTime Appointmentdate { get; set; }
        public string Location { get; set; } = null!;
    }
}