using FirstCoreAPIWithUnitTest.Interfaces;
using HikeCalculatorrAPI.Controllers;
using Moq;
using System;
using Xunit;

namespace FirstCoreAPIWithUnitTest.Test
{
    public class HikeCalculatorTest
    {
        [Fact]
        public void GetNewSalaryByPercentageTest()
        {
            var mock = new Mock<IHikeCalculator>();
            mock.Setup(p => p.GetNewSalaryByHikePercentage(100,20)).Returns(2000);
            HikeCalculateController hikeCalc = new HikeCalculateController(mock.Object);
            double result = hikeCalc.GetHikeByPercentage(100,20);
            Assert.Equal(2000, result);
        }

        [Fact]
        public void GetNewSalaryByReviewedSalaryTest()
        {
            var mock = new Mock<IHikeCalculator>();
            mock.Setup(p => p.GetSalaryHikePercentage(1000, 1500)).Returns(50);
            HikeCalculateController hikeCalc = new HikeCalculateController(mock.Object);
            double result = hikeCalc.GetHikeByReviewedSalary(1000, 1500);
            Assert.Equal(50, result);
        }
    }
}
