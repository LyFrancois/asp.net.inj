﻿using System;


namespace aspNet
{
    public class MonthlySalaryCalculator : ISalaryCalculator
    {
       
            public Double CalculateSalary(Double yearlyAmount)
            {
                return yearlyAmount / 12;
            }
        
    }
}
