using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreAPIWithUnitTest.Interfaces
{
    public interface IHikeCalculator
    {
        double GetSalaryHikePercentage(double oldSalary, double newSalary);
        double GetNewSalaryByHikePercentage(double oldSalary, double percentageRecieved);
    }
}
