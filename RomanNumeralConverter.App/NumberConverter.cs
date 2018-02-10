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
            switch (number)
            {
                case 1:
                    return "I";

                case 5:
                    return "V";

                case 9:
                    return "IV";
            }

            return "stuff broke";
        }
    }
}
