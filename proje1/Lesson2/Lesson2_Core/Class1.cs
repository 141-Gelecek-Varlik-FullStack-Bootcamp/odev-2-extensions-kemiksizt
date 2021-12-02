using System;

namespace Lesson2_Core
{
    public static class Extensions
    {

        

        public static string toUSD(this int variable)
        {
            return variable * 12 + " $";
        }

    }
}
