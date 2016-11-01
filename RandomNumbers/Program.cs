using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbers
{
    class Program
    {
        static Random randyRandom = new Random();

        static void Main(string[] args)
        {
            GetRandomNumbers1To100();
            Console.WriteLine(-1);
        }

        private static void GetRandomNumbers1To100()
        {
            int[] arrayOfRandomNumbers = new int[50];

            for (int i = 0; i < 50; i++)
            {
                arrayOfRandomNumbers[i] = randyRandom.Next(0, 100);
            }

            foreach (int item in arrayOfRandomNumbers)
            {
                Console.WriteLine(item);
            }
        }

    }
}
