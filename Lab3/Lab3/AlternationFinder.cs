
namespace Lab3
{
    class AlternationFinder
    {
        public string IsItAlternate(int[] massiveOfNumbers)
        {
            int alternate = 0;
            bool previousNumber =IsItEven(massiveOfNumbers[0]);
            bool currentNumber = false;
            for(int i = 1; i < massiveOfNumbers.Length; i++)
            {
                currentNumber = IsItEven(massiveOfNumbers[i]);
                if (previousNumber == currentNumber)
                {
                    alternate = i + 1;
                    break;
                }
                previousNumber = currentNumber;
            }
            return alternate.ToString();
        }
        private bool IsItEven(int number)
        {
            if(number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
