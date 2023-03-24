using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hours_And_Minutes.Hours_And_Minutes.Tests
{
    public class DegreeCalculatorTest
    {
       
        [Fact]
        public void degreeCalculator_returns_correct_format()
        {
            //arrange
            TimeModel time = new TimeModel(3, 55);

            //act
            float result = DegreeCalculator.CalculateTotalDegrees(time);

            //assert
            Assert.IsAssignableFrom<float>(result);
        }
        [Fact]
        public void degreeCalculator_returns_correct_value()
        {
            //arrange
            TimeModel time = new TimeModel(12,0);

            //act
            var result = DegreeCalculator.CalculateTotalDegrees(time);

            //assert
            Assert.Equal(0, result);
        }
    }   
}
