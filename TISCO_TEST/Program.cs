using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TISCO_TEST
{
    class Program
    {
        private static int TARGET_SUM = 100;
        private static int[] VALUES = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        static void Main(string[] args)
        {
            //1    -----------------------------------------------------------------------------------
            Console.WriteLine("-------------------------START-----------------------");
            //[Default] Write a function reverse_words() that takes a string message and reverses the order of the words.
            //Example: "I like to read" ==> "read to like I"

            Console.Write("(1)  ");
            Console.Write("Reverse Words Input :  ");
            string textWord = Console.ReadLine();
            string word = String.Join(" ", textWord.Split(' ').Reverse().ToArray());
            Console.WriteLine("Output :  " + word);
            Console.WriteLine("-----------------------------------------------------");




            //2    -----------------------------------------------------------------------------------
            //[20] Write a function to print a sequence of strings composed of characters ‘a’ and ‘b’ in any order.No letter should be printed more than 2 times repeatedly in the sequence and all the characters should be used.
            //Example:  f(a= 3, b= 4)  -> abababb
            //          f(a= 5, b= 4) -> aabbaabba

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
                Console.WriteLine();
            }
            else
            {
                int countA = 0, countB = 0;
                for (int i = 1; a > i; i = countA)
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
                Console.WriteLine();
            }
            Console.WriteLine("-----------------------------------------------------");



            //3    -----------------------------------------------------------------------------------
            //[20] If we have a count of x heads and y legs among the birds and dogs in a farm. Write a function to how many dogs and how many birds?
            //Example: 35 heads and 94 legs-> 23 birds and 12 dogs

            Console.Write("(3)  ");
            int x, y;
            Console.Write("X head :  ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("     Y leg :  ");
            y = Convert.ToInt32(Console.ReadLine());

            var dog = (y - (x * 2)) / 2;
            var bird = x - dog;
            Console.Write($"Output : Bird {bird} AND Dog {dog} ");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------");


            //4    -----------------------------------------------------------------------------------
            //[50] Write a program that outputs all possibilities to put + or - or nothing between 
            //numbers 1, 2, ..., 9(in this order) such that the result is always 100.
            //Example: 1 + 2 + 34 – 5 + 67 – 8 + 9 = 100.
            int count = 0;
            solution(ref count);
            Console.WriteLine();
            Console.WriteLine("Solution For numbers 1, 2, ..., 9(in this order) such that the result is always 100.");
            Console.WriteLine(" ==>  " + count);
            Console.WriteLine();
            Console.WriteLine("-------------------------END--------------------------");
            Console.ReadKey();
        }

        private static void solution(ref int count)
        {
            //int count = 0;
            foreach (String _string in f(TARGET_SUM, VALUES[0], 1))
            {
                Console.WriteLine(_string);
                count++;
            }
        }
        private static List<String> f(int sum, int number, int index)
        {
            int digit = Math.Abs(number % 10);
            if (index >= VALUES.Length)
            {
                if (sum == number)
                {
                    List<String> result = new List<String>();
                    result.Add(digit.ToString());
                    return result;
                }
                else
                {
                    return new List<String>();
                }
            }

            List<String> branch1 = f(sum - number, VALUES[index], index + 1);
            List<String> branch2 = f(sum - number, -VALUES[index], index + 1);

            int concatenatedNumber = number >= 0
                ? 10 * number + VALUES[index]
                : 10 * number - VALUES[index];
            List<String> branch3 = f(sum, concatenatedNumber, index + 1);

            List<String> results = new List<String>();

            results.AddRange(add(digit, "+", branch1));
            results.AddRange(add(digit, "-", branch2));
            results.AddRange(add(digit, "", branch3));

            return results;
        }
        private static List<String> add(int digit, String sign, List<String> branches)
        {
            for (int i = 0; i < branches.Count(); i++)
            {
                branches[i] = (digit + sign + branches[i].ToString());
            }

            return branches;
        }
    }
}
