using System;

namespace Guess_Game
{
    class Guess
    {
        static int N = 84;
        public static void Final(int[] abc)
        {
            guess_process(abc);
            Print(abc);
            Sorting(abc);
            Counting(abc);
        }
        private static void guess_process(int[] abc)
        {
            for (int i = 0; i < abc.Length; i++)
            {
                Console.WriteLine("Please enter a two digit number!");

                abc[i] = int.Parse(Console.ReadLine());
                int dif = Math.Abs(abc[i] - N);
                if (dif == 0)
                {
                    Console.WriteLine("Bravo you guess the right number");
                    break;
                }
                else if (dif < 5)
                {
                    Console.WriteLine("You are too close to the right number");
                }
                else if (dif >= 5 && dif < 10)
                {
                    Console.WriteLine("You are close to the right number");
                }
                else if (dif >= 10 && dif < 20)
                {
                    Console.WriteLine("You are far from the right number");
                }
                else if (dif >= 20 && dif < 50)
                {
                    Console.WriteLine("You are too far from the right number");
                }
                else if (dif >= 50)
                {
                    Console.WriteLine("You are far for more than 50 numbers");
                }
            }
        }

        private static void Print(int[] abc)
        {
            Console.Write("inputs are: \n ");
            for (int i = 0; i < abc.Length; i++)
            {
                Console.Write(" " + abc[i] + " ");
            }
        }

        private static void Sorting(int[] abc)
        {
            int n = abc.Length;
            for (int i = 0; i < abc.Length - 1; i++)
            {
                for (int j = i + 1; j < abc.Length; j++)
                {
                    if (abc[i] > abc[j])
                    {
                        int h = abc[i];
                        abc[i] = abc[j];
                        abc[j] = h;
                    }
                }
            }
            Console.Write("\nSorted inputs are: \n ");
            for (int i = 0; i < abc.Length; i++)
            {
                Console.Write(" " + abc[i] + " ");
            }
        }
        private static void Counting(int[] abc)
        {
            int m = 0;

            for (int i = 0; i < abc.Length - 1; i++)
            {
                for (int j = i + 1; j < i + 2; j++)
                {
                    if (abc[i] == 0 && abc[j] == 0)
                        break;
                    else if (abc[i] == abc[j])
                    {

                        m++;
                    }
                }

            }
            Console.WriteLine("\nnumber of repeated trials: " + m);
        }
    }

    class program
    {
        static void Main(string[] arg)
        {
            Console.Write("Welcome To The Guess-Game!\n");
            int[] abc = new int[5];

            Guess.Final(abc);

            Console.ReadKey();
        }
    }
}