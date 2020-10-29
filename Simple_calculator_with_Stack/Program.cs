using System;
using System.Dynamic;
using System.Collections.Generic;

namespace Simple_calculator_with_stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple calculator");
            Stack<int> numbersPos = new Stack<int>();
            Stack<int> numbersNeg = new Stack<int>();

            Console.WriteLine("Enter a number");
            numbersPos.Push(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Enter + or -  To finish type =");
            string sym = Console.ReadLine();

            while (sym != "=")
            {
                Console.WriteLine("Enter a number");
                if (sym == "+")
                {
                    numbersPos.Push(Convert.ToInt32(Console.ReadLine()));
                }
                else if (sym == "-")

                {
                    numbersNeg.Push(Convert.ToInt32(Console.ReadLine()));
                }

                Console.WriteLine("Enter + or -  To finish type =");
                sym = Console.ReadLine();
            }

            int sum = 0;

            while (numbersPos.Count > 0) sum += numbersPos.Pop();
            while (numbersNeg.Count > 0) sum -= numbersNeg.Pop();


            Console.WriteLine("The sum of this operation is: " + sum);
            Console.ReadLine();
        }
    }
}