using FirstCoreAPIWithUnitTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HikeCalculatorrAPI.Repository
{
    public class HikeCalculatorRepository : IHikeCalculator
    {
        public double GetNewSalaryByHikePercentage(double oldSalary, double percentageRecieved)
        {
            return (oldSalary * percentageRecieved);
        }

        public double GetSalaryHikePercentage(double oldSalary, double newSalary)
        {
            return ((newSalary - oldSalary) / (oldSalary) * 100);
        }
    }
}
