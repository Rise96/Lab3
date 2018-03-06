
namespace Lab3
{
    class AlternationFinder
    {
        public string IsItAlternate(int[] arrayOfNumbers)
        {
            int alternation = 0;
            bool previousNumber = IsEven(arrayOfNumbers[0]);
            bool currentNumberIsEven = false;
            for (int i = 1; i < arrayOfNumbers.Length; i++)
            {
                currentNumberIsEven = IsEven(arrayOfNumbers[i]);
                if (previousNumber == currentNumberIsEven)
                {
                    alternation = i + 1;
                    break;
                }
                previousNumber = currentNumberIsEven;
            }
            return alternation.ToString();
        }

        private bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}
