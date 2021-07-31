using FirstCoreAPIWithUnitTest.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HikeCalculatorrAPI.Controllers
{
    [Route("api/hike/calculator")]
    [ApiController]
    public class HikeCalculateController : ControllerBase
    {
        private readonly IHikeCalculator calculator;

        public HikeCalculateController(IHikeCalculator calculator)
        {
            this.calculator = calculator;
        }

        #region HikeCalculation
        public double GetHikeByPercentage(double oldSalary, double percentageRecieved)
        {
            return calculator.GetNewSalaryByHikePercentage(oldSalary, percentageRecieved);
        }

        public double GetHikeByReviewedSalary(double oldSalary, double newSalary)
        {
            return calculator.GetSalaryHikePercentage(oldSalary, newSalary);
        }
        #endregion

        [HttpGet]
        [Route("bypercentage")]
        public IActionResult GetNewSalaryByPercentage(double oldSalary, double percentageRecieved)
        {
            return Ok(GetHikeByPercentage(oldSalary, percentageRecieved));
        }

        [HttpGet]
        [Route("bynewsalary")]
        public IActionResult GetNewSalaryByNewSalary(double oldSalary, double newSalary)
        {
            return Ok(GetHikeByReviewedSalary(oldSalary, newSalary));
        }
    }
}
