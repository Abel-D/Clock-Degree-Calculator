using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hours_And_Minutes
{
    internal class DegreeCalculator
    {
        static int halfDay = 360;
        static int degreeOfOneMinInHr = halfDay / 60;
        static int degreeOfOneHr = halfDay / 12;

        private static float CalculateHourHandDegree(TimeModel time)
        {
            float degreeOfHrPerMin =(float)time.Minutes / 60;
            float degree = ((float)time.Hour + degreeOfHrPerMin) * degreeOfOneHr;
            return degree;
        }
        private static float CalculateMinHandDegree(int min)
        {
            var degree = (float)min * degreeOfOneMinInHr;
            return degree;
        }

        public static float CalculateTotalDegrees(TimeModel time)
        {
            float hr = CalculateHourHandDegree(time);
            float min = CalculateMinHandDegree(time.Minutes);

            var degree = min - hr;

            if (degree > 180)
            {
                degree = 360 - degree;
            }
            else if (degree < 0)
            {
                degree = 360 + degree;
            }
            return degree;
        }
    }
}
