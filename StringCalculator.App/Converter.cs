using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator.App
{
    public class Converter
    {
        //Create a simple String calculator with a method int Add(string numbers)
        public int Add(string numbers)
        {
            var result = 0;

            var numberCount = numbers.Length;

            if (numberCount == 0 || numbers == " ")
            {
                return result;

            } else if (numberCount == 1)
            {
                result = int.Parse(numbers);
                return result;
            }
            else
            {
                return 0;
            }
        }
    }
}
