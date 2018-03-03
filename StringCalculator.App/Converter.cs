using System.Collections.Generic;
using System.Linq;

namespace StringCalculator.App
{
    public class Converter
    {
        public int Add(string numbers)
        {
            var stringList = ListOfNumbersAsStrings(numbers);


            if (numbers != " ")
            {
                return NumbersAsIntList(stringList);

            }
            else
            {
                return 0;
            }
        }

        //Helper funtcions

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

        private int NumbersAsIntList(List<string> StringList)
        {
            var numberList = new List<int>();

            foreach (var number in StringList)
            {
                var numberAsInt = int.Parse(number);

                numberList.Add(numberAsInt);
            }
            var listWithoutThousands = RemoveNumbersInThousands(numberList);
            return listWithoutThousands.Sum();
        }

        private List<int> RemoveNumbersInThousands(List<int> numberList)
        {
            var correctedNumberList = new List<int>();

            foreach (var number in numberList)
            {
                if (number <= 1000)
                    correctedNumberList.Add(number);
            }
            return correctedNumberList;
        }
    }
}
