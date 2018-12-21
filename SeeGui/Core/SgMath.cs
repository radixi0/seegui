using System;
using System.Collections.Generic;
using System.Text;

namespace SeeGui.Core
{
    public class SgMath
    {
        /// <summary>
        /// Returns true if given number is even
        /// </summary>
        /// <param name="number">Integer number</param>
        /// <returns></returns>
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}
