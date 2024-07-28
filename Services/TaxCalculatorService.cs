using System;
using TaxCalculatorAPI.Models;

namespace TaxCalculatorAPI.Services
{
    public class TaxCalculatorService : ITaxCalculatorService
    {
        public TaxCalculationResult CalculateTax(decimal income, decimal deductions = 0)
        {
            decimal taxableIncome = Math.Max(0, income - deductions);
            decimal taxAmount = 0;

            // Example tax brackets for Egypt (2024)
            if (taxableIncome <= 15000)
            {
                taxAmount = taxableIncome * 0.0m; // 0% for income <= 15000
            }
            else if (taxableIncome <= 30000)
            {
                taxAmount = 15000 * 0.0m + (taxableIncome - 15000) * 0.10m; // 10% for income > 15000
            }
            else if (taxableIncome <= 45000)
            {
                taxAmount = 15000 * 0.0m + 15000 * 0.10m + (taxableIncome - 30000) * 0.15m; // 15% for income > 30000
            }
            else
            {
                taxAmount = 15000 * 0.0m + 15000 * 0.10m + 15000 * 0.15m + (taxableIncome - 45000) * 0.20m; // 20% for income > 45000
            }

            return new TaxCalculationResult
            {
                Income = income,
                Deductions = deductions,
                TaxableIncome = taxableIncome,
                TaxAmount = taxAmount
            };
        }
    }
}
