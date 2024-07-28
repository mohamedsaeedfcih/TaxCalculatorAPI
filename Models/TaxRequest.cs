using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaxCalculatorAPI.Models
{
    public class TaxRequest
    {
        public decimal Income { get; set; }
        public decimal Deductions { get; set; }
    }
}
