using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    class Program
    {
        static int input;
        static int[] Histogram = new int[10];
        //static int[] Histogram = { 1, 2, 4, 6, 6, 8, 8, 2, 1, 0 };
        static Random randyRandom = new Random();


        static void Main(string[] args)
        {
            GetInput();
            DisplayHistogram();
        }

        private static void DisplayHistogram()
        {
            //clears errors and previous histogram before drawing another one
            Console.Clear();


            Console.WriteLine("0".PadLeft(3) + " -" + "9".PadLeft(3) + ": " + GetHoizPipsString(0));
            Console.WriteLine();
            Console.WriteLine("10".PadLeft(3) + " -" + "19".PadLeft(3) + ": " + GetHoizPipsString(1));
            Console.WriteLine();
            Console.WriteLine("20".PadLeft(3) + " -" + "29".PadLeft(3) + ": " + GetHoizPipsString(2));
            Console.WriteLine();
            Console.WriteLine("30".PadLeft(3) + " -" + "39".PadLeft(3) + ": " + GetHoizPipsString(3));
            Console.WriteLine();
            Console.WriteLine("40".PadLeft(3) + " -" + "49".PadLeft(3) + ": " + GetHoizPipsString(4));
            Console.WriteLine();
            Console.WriteLine("50".PadLeft(3) + " -" + "59".PadLeft(3) + ": " + GetHoizPipsString(5));
            Console.WriteLine();
            Console.WriteLine("60".PadLeft(3) + " -" + "69".PadLeft(3) + ": " + GetHoizPipsString(6));
            Console.WriteLine();
            Console.WriteLine("70".PadLeft(3) + " -" + "79".PadLeft(3) + ": " + GetHoizPipsString(7));
            Console.WriteLine();
            Console.WriteLine("80".PadLeft(3) + " -" + "89".PadLeft(3) + ": " + GetHoizPipsString(8));
            Console.WriteLine();
            Console.WriteLine("90".PadLeft(3) + " -" + "100".PadLeft(3) + ": " + GetHoizPipsString(9));
            Console.WriteLine();



            int maxHeight = GetMaxNumber();
            for (int height = maxHeight; height > 0; height--)
            {
                //This wrights one line and uses the array index and the current row to run the method to check if there is a pip or not
                Console.WriteLine((GetVertPip(0, height).PadLeft(3)) + 
                    (GetVertPip(1, height).PadLeft(6)) + 
                    (GetVertPip(2, height).PadLeft(6)) + 
                    (GetVertPip(3, height).PadLeft(6)) + 
                    (GetVertPip(4, height).PadLeft(6)) + 
                    (GetVertPip(5, height).PadLeft(6)) + 
                    (GetVertPip(6, height).PadLeft(6)) + 
                    (GetVertPip(7, height).PadLeft(6)) + 
                    (GetVertPip(8, height).PadLeft(6)) + 
                    (GetVertPip(9, height).PadLeft(6)));
                Console.WriteLine();
            }
            Console.WriteLine(" 0-9  10-19 20-29 30-39 40-49 50-59 60-69 70-79 80-89 90-100");

        }

        private static int GetMaxNumber()
        {
            int max = Histogram[0];
            foreach (int item in Histogram)
            {
                if (max < item) max = item;
            }
            return max;
        }

        private static string GetVertPip(int arrayIndex, int rowFromBottom)
        {
            string pip = "";

            if (Histogram[arrayIndex] >= rowFromBottom) pip += "*";

            return pip;
        }

        private static string GetHoizPipsString(int arrayIndex)
        {
            string pipString = "";

            for (int i = 0; i < Histogram[arrayIndex]; i++)
            {
                pipString += "*"/*.PadRight(2)*/;
            }

            return pipString;
        }

        private static void GetInput()
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out input))
                {
                    if(input >= -1 && input <= 100)
                    {
                        if (input == 100) input = 99;
                        if (input == -1) break;
                        Histogram[(input / 10)]++;
                    } else
                    {
                        Console.Write("Bad input, try again: ");
                    }
                }
            }
        }

    }
}
