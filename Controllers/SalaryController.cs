using Microsoft.AspNetCore.Mvc;
using System;



namespace aspNet.Controllers
{
  
    
        [Route("Salary")]
        public class SalaryController
        {
            private ISalaryCalculator _calculator;

            public SalaryController(ISalaryCalculator injectedCalculator)
            {
                _calculator = injectedCalculator;
            }

                [HttpGet()] // selectionne les paramètres l'api
            public Double Get(Double yearlyAmount)
            {
                Double calculatedSalary = _calculator.CalculateSalary(yearlyAmount);
                return calculatedSalary;
            }
        }
}
