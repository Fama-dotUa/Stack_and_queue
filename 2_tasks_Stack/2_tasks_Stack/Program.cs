using System;
using System.Collections.Generic;

namespace _2_tasks_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть рядок, що мiстить лiтери:");
            string input = Console.ReadLine();

            Stack<char> vowelStack = new Stack<char>();
            Stack<char> consonantStack = new Stack<char>();

            HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'y', 'A', 'E', 'I', 'O', 'U', 'Y' };

            foreach (char ch in input)
            {
                if (char.IsLetter(ch))
                {
                    if (vowels.Contains(ch))
                    {
                        vowelStack.Push(ch);
                    }
                    else
                    {
                        consonantStack.Push(ch);
                    }
                }
            }

            Console.WriteLine("Стек голосних лiтер:");
            while (vowelStack.Count > 0)
            {
                Console.Write(vowelStack.Pop() + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Стек приголосних лiтер:");
            while (consonantStack.Count > 0)
            {
                Console.Write(consonantStack.Pop() + " ");
            }
            Console.WriteLine();
        }
    }
}
