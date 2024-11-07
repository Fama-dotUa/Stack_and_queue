using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_tasks_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 34, 3, 31, 98, 92, 23 };

            int[] sortedArray = SortArrayUsingStack(array);

            Console.WriteLine("Вiдсортований масив:");
            foreach (int num in sortedArray)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        static int[] SortArrayUsingStack(int[] array)
        {
            Stack<int> stack = new Stack<int>();
            Stack<int> tempStack = new Stack<int>();

            foreach (int num in array)
            {
                while (stack.Count > 0 && stack.Peek() > num)
                {
                    tempStack.Push(stack.Pop());
                }

                stack.Push(num);

                while (tempStack.Count > 0)
                {
                    stack.Push(tempStack.Pop());
                }
            }

            int[] sortedArray = new int[array.Length];
            int index = 0;

            while (stack.Count > 0)
            {
                sortedArray[index++] = stack.Pop();
            }

            Array.Reverse(sortedArray);

            return sortedArray;
        }
    }
}
