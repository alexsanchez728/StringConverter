using System.Collections.Generic;
using System.Linq;

namespace StringCalculator.App
{
    public class Converter
    {
        public int Add(string numbers)
        {
            var result = 0;
            var stringList = ListOfNumbersAsStrings(numbers);

            if (stringList.Count == 0 || numbers == " ")
            {
                return result;

            }
            else if (stringList.Count == 1)
            {

                result = NumbersAsIntList(stringList);

                return result;

            }
            else if (stringList.Count == 2)
            {
                result = NumbersAsIntList(stringList);

                return result;
            }
            else
            {
                return 0;
            }
        }

        private int NumbersAsIntList(List<string> StringList)
        {
            var numberList = new List<int>();

            foreach (var number in StringList)
            {
                numberList.Add(int.Parse(number));
            }

            return numberList.Sum();
        }



        private List<string> ListOfNumbersAsStrings(string inputString)
        {
            var numbersAsStrings = new List<string>();

            if (inputString.Contains(','))
            {
                numbersAsStrings = inputString.Split(',').ToList();
            }
            else
            {
                numbersAsStrings.Add(inputString);
            }

            return numbersAsStrings;
        }
    }
}
