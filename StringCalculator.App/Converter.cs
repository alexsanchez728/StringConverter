using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator.App
{
    public class Converter
    {
        public int Add(string numbers)
        {
            var result = 0;

            var numberList = new List<int>();

            var numbersAsStrings = new List<string>();

            if (numbers.Contains(','))
            {
                numbersAsStrings = numbers.Split(',').ToList();
            }
            else
            {
                numbersAsStrings.Add(numbers);
            }

            if (numbersAsStrings.Count == 0 || numbers == " ")
            {
                return result;

            }
            else if (numbersAsStrings.Count == 1)
            {
                foreach (var number in numbersAsStrings)
                {
                    numberList.Add(int.Parse(number));
                }

                result = numberList[0];
                return result;

            }
            else if (numbersAsStrings.Count == 2)
            {
                foreach (var number in numbersAsStrings)
                {
                    numberList.Add(int.Parse(number));
                }

                return numberList[0] + numberList[1];
            }
            else
            {
                return 0;
            }
        }
    }
}
