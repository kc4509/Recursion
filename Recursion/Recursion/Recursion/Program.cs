//Kelly Chen | kc4509@g.rit.edu
//E11 Recursion
//Recursive functions for factorials, sum, and division

using System;

namespace Recursive
{
    class Program
    {
        //user input and printing
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number for factorial: ");
            int number = Convert.ToInt32(Console.ReadLine());
            double factorial = Factorial(number);
            Console.WriteLine("factorial of " + number + " is " + factorial.ToString());

            Console.WriteLine();

            Console.WriteLine("Enter number for recurisve sum: ");
            number = Convert.ToInt32(Console.ReadLine());
            double RecursiveSum = RecusiveSum(number);
            Console.WriteLine("recursive sum of " + number + " is " + RecursiveSum.ToString());

            Console.WriteLine();

            Console.WriteLine("Enter numerator: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter denominator: ");
            int deno = Convert.ToInt32(Console.ReadLine());
            while (deno == 0)
            {
                Console.WriteLine("Cannot divide by zero");
                Console.WriteLine("Enter new denominator: ");
                deno = Convert.ToInt32(Console.ReadLine());
            }
            double RecursiveDivsion = RecursiveDivision(number, deno);
            Console.WriteLine("recursive division of " + number + "/" + deno + " is " + RecursiveDivsion.ToString());
        }

        //factorial method
        //I had help from here:
        //https://www.c-sharpcorner.com/UploadFile/955025/C-Sharp-interview-questions-part4what-is-a-recursive-function-in/ 
        public static double Factorial (int number)
        {
            if (number == 0)
            {
                return 1;
            }
            return number * Factorial(number - 1);
        }
        // The big-Theta for recursive function that calculates factorials is O(n), since the function
        // loops n amount of times.

        //recursive sum method 
        public static double RecusiveSum (int number)
        {
            if (number == 0)
            {
                return 0;
            }
            return number + RecusiveSum(number - 1);
        }

        //recursive division method
        //I had help from
        //https://www.csinfo360.com/2020/09/divide-two-numbers-using-recursion.html 
        public static double RecursiveDivision(int num, int deno)
        {
            if (Math.Abs(num) < Math.Abs(deno))
            {
                return 0;
            }
            return 1 + RecursiveDivision(Math.Abs(num)-Math.Abs(deno), deno);
        }

    }
}




