using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hours_And_Minutes
{
    public class TimeModel
    {
        public TimeModel(int hour,int minutes)
        {
            this.Hour = hour;
            this.Minutes = minutes; 
        }
        public int Hour { get; set; }
        public int Minutes { get; set; }
    }
}
