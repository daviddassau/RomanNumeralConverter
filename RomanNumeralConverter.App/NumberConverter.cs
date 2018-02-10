using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralConverter.App
{
    public class NumberConverter
    {
        public string Parse(int number)
        {
            if (number == 1)
            {
                return "I";
            }

            return "stuff broke";
        }
    }
}
