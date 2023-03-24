using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Hours_And_Minutes
{
    public static class DegreeCalculator
    {
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
    }
  
}
