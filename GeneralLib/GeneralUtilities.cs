using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralLib
{
    public class GeneralUtilities
    {
        public static string ToOrdinalString(int val)
        {
            string extension = "th";

            // last 2 digits
            int lastTwoDigits = val % 100;

            if (lastTwoDigits < 11 || lastTwoDigits > 13)
            {
                // last digit
                int lastDigit = lastTwoDigits % 10;

                extension = (lastDigit) switch
                {
                    1 => "st",
                    2 => "nd",
                    3 => "rd",
                    _ => "th"
                };
            }

            return $"{val}{extension}";
        }
    }
}
