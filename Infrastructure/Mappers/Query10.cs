using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Mappers
{
    public class Query10
    {
        public int Customerid { get; set; }
        public string FullName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string phonenumber { get; set; } = null!;
        public string Address { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public string Status { get; set; } = null!;
    }
}