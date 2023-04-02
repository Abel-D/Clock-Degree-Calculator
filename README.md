# Clock-Degree-Calculator
## Hours-And-Minutes
   This c# application is a simple degree calculator for minute and hour hand of an analogue clock.I accepts inputs hour and minutes from the user
   and return the lesser degree between the hands.

## calculation Logic implementation
   #### namespace Hours_And_Minutes
         static int halfDay = 360;

        // calculate the degree difference for each minute hand position in an hour
        static int degreeOfOneMinInHr = halfDay / 60;

        // calculate the degree of difference of the hour hand on each hour the day
        static int degreeOfOneHr = halfDay / 12;

        private static float CalculateHourHandDegree(TimeModel time)
        {
            // calculate the degree of fluctuation of hour hand in respect to minute in an hour
            float degreeOfHrPerMin =(float)time.Minutes / 60;
            float degree = ((float)time.Hour + degreeOfHrPerMin) * degreeOfOneHr;
            return degree;
        }
        private static float CalculateMinHandDegree(int min)
        {
            // calculate the minute hand position
            var degree = (float)min * degreeOfOneMinInHr;
            return degree;
        }

        public static float CalculateTotalDegrees(TimeModel time)
        {
            float hr = CalculateHourHandDegree(time);
            float min = CalculateMinHandDegree(time.Minutes);

            var degree = min - hr;

            // If the degree is greater than 180, calculate the lesser degree
            if (degree > 180)
            {
                degree = 360 - degree;
            }

            // if the degree is negative, get the lesser angle by substracting from full circle
            else if (degree < 0)
            {
                degree = 360 + degree;
            }
            return degree;
        }
 #### Hours_And_Minutes.Hours_And_Minutes.Tests
    This library is a xunit test project for the above application logic implementation. 
     
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
     
  
