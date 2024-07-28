using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaxCalculatorAPI.Models;

namespace TaxCalculatorAPI.Services
{
    public interface ITaxCalculatorService
    {
        TaxCalculationResult CalculateTax(decimal income, decimal deductions = 0);
    }
}

