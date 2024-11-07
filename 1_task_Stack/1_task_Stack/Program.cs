using System;
using System.Collections.Generic;

namespace _1_task_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть рядок, що мiстить символи i числа:");
            string input = Console.ReadLine();

            Stack<char> symbolStack = new Stack<char>();
            Stack<int> numberStack = new Stack<int>();

            foreach (char ch in input)
            {
                if (char.IsDigit(ch)) 
                {
                    numberStack.Push(int.Parse(ch.ToString()));
                }
                else if (char.IsLetter(ch))
                {
                    symbolStack.Push(ch);
                }
            }

            Console.WriteLine("Стек символів:");
            while (symbolStack.Count > 0)
            {
                Console.Write(symbolStack.Pop() + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Стек чисел:");
            while (numberStack.Count > 0)
            {
                Console.Write(numberStack.Pop() + " ");
            }
            Console.WriteLine();
        }
    }
}
