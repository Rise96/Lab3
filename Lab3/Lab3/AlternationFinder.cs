using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class AlternationFinder
    {
        public string IsItAlternate(int[] massiveOfNumbers)
        {
            string[] result;
            int alternate = 0;
            int previousNumber = 0;
            int currentNumber = 0;
            int NumberOfLastNumber=0;
            for(int i = 0; i < massiveOfNumbers.Length; i++)
            {
                if (massiveOfNumbers[i] % 2 == 0)
                {
                    currentNumber = 1;
                }
                if (previousNumber != currentNumber)
                {
                    alternate = 1;
                }
                else
                {
                    alternate = 0;
                    NumberOfLastNumber = i;
                }
            }
            result[1] = NumberOfLastNumber.ToString();
            return result;
        }
    }
}
