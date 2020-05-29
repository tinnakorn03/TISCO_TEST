using System;
using System.Linq;

namespace TISCO_TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            //1-----------------------------------------------------------------------------------
            Console.Write("(1)  ");
            Console.Write("Reverse Words Input :  ");
            string textWord = Console.ReadLine();
            string word = String.Join(" ", textWord.Split(' ').Reverse().ToArray());
            Console.WriteLine("Output :  " + word);
            Console.WriteLine("-----------------------------------------------------");


            //2-----------------------------------------------------------------------------------
            Console.Write("(2)  ");
            int a, b;
            Console.Write("A Input :  ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("     B Input :  ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Output :  ");
            if (a < b)
            {
                for (int i = 1; b >= i; i++)
                {
                    if (a >= i)
                        Console.Write("a");
                    Console.Write("b");
                }
                Console.WriteLine("-----------------------------------------------------");
            }
            else
            {
                int countA = 0, countB = 0;
                for (int i = 1; a > i; i=countA)
                {
                    for (int ii = 1; 2 >= ii; ii++)
                    {
                        if (countA < a)
                        {
                            Console.Write("a");
                            countA++;
                        }
                    }
                    for (int ii = 1; 2 >= ii; ii++)
                    {
                        if (countB < b)
                        {
                            Console.Write("b");
                            countB++;
                        }
                    }
                }
                Console.WriteLine("-----------------------------------------------------");
            }

            //3-----------------------------------------------------------------------------------

        }
    }
}
