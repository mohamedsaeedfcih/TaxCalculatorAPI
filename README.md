Overview
TaxCalculatorAPI is an ASP.NET Core Web API that calculates the tax based on the provided income and deductions. This API follows the tax brackets for Egypt (2024) and includes detailed tax calculation logic, enhanced models, and middleware for error handling.

Features
Detailed Tax Calculation: Calculates tax based on specified tax brackets.
Deductions: Considers deductions to compute the taxable income.
Global Error Handling: Middleware for handling exceptions and logging errors.
Swagger UI: Integrated Swagger UI for easy API testing and documentation.

Project Structure:
TaxCalculatorAPI
│   Program.cs
│   Startup.cs
├───Controllers
│       TaxController.cs
├───Models
│       TaxRequest.cs
│       TaxResponse.cs
│       TaxCalculationResult.cs
├───Services
│       ITaxCalculatorService.cs
│       TaxCalculatorService.cs
└───Middleware
        ExceptionHandlingMiddleware.cs
