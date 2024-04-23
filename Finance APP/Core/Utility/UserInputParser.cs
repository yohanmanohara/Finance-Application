using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance_APP.Core.Utility
{
    internal class UserInputParser
    {

        public static int HumanTimeDelta(string sample)
        {
            const int DAYS_IN_YEAR = 365;
            const int DAYS_IN_MONTH = 30;

            int timePeriodDelta = 0;

            if (sample.Contains("years"))
            {
                timePeriodDelta = int.Parse(sample.Replace("years", "")) * DAYS_IN_YEAR;
            }
            else if (sample.Contains("months"))
            {
                timePeriodDelta = int.Parse(sample.Replace("months", "")) * DAYS_IN_MONTH;
            }
            else if (sample.Contains("days"))
            {
                timePeriodDelta = int.Parse(sample.Replace("days", ""));
            }

            return timePeriodDelta;
        }
    }
}
