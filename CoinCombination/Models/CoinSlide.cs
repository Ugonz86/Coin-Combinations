using System;

namespace CoinCombination.Models
{
    public class CoinSlide
    {
        public static int numQuarters = 0;
        public static int numDimes = 0;
        public static int numNickels = 0;
        public static int numPennies = 0;

        public static void GetCoins(int changeNo)
        {
            numQuarters = changeNo / 25;  // if changeNo = 47, numQuarters = 3
            changeNo = changeNo - numQuarters * 25; // reassign changeNo to 47 - (3 * 25), which is 22

            numDimes = changeNo / 10; // numDimes is 22 / 10, which is 2
            changeNo = changeNo - numDimes * 10; // reassign changeNo to 22 - (2 * 10), which is 2

            numNickels = changeNo / 5; // numNickels = 2 / 5, which is 0
            changeNo = changeNo - numNickels * 5;

            numPennies = changeNo / 1;
        }
    }
}
