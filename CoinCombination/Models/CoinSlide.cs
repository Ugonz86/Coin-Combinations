using System;

namespace CoinCombination.Models
{
    public class CoinSlide
    {
        public static int numQuarters = 0;
        public static int numDimes = 0;
        public static int numNickels = 0;
        public static int numPennies = 0;

        // public CoinSlide()
        // {
        //     NumQuarters = 0;
        //     NumDimes = 0;
        //     NumNickels = 0;
        //     NumPennies = 0;
        // }

        public static void GetCoins(int changeNo)
        {
            numQuarters = changeNo / 25;
            numDimes = changeNo / 10;
            numNickels = changeNo / 5;
            numPennies = changeNo / 1;
        }

        // public static int GetQuarters(int changeNo)
        // {
        //     return changeNo / 25;
        // }
        // public static int GetDimes(int changeNo)
        // {
        //     return changeNo / 10;
        // }
        // public static int GetNickels(int changeNo)
        // {
        //     return changeNo / 5;
        // }
        // public static int GetPennies(int changeNo)
        // {
        //     return changeNo / 1;
        // }
    }
}
