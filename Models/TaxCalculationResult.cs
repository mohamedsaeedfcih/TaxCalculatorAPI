using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaxCalculatorAPI.Models
{
    public class TaxCalculationResult
    {
        public decimal Income { get; set; }
        public decimal Deductions { get; set; }
        public decimal TaxableIncome { get; set; }
        public decimal TaxAmount { get; set; }
    }
}
