using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turn
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Ініціалізація звичайної черги
            QueueExample queueExample = new QueueExample();

            // Введення n та k користувачем
            Console.Write("Введiть кiлькiсть елементiв у черзi (n): ");
            int n = int.Parse(Console.ReadLine());
            queueExample.FillQueue(n);

            queueExample.DisplayQueue();

            Console.Write("Введiть кiлькiсть елементiв для видалення (k): ");
            int k = int.Parse(Console.ReadLine());
            queueExample.DequeueElements(k);

            queueExample.DisplayQueue();

            // Тестування методу clear()
            queueExample.Clear();
            queueExample.DisplayQueue();

            // Ініціалізація пріоритетної черги
            PriorityQueue priorityQueue = new PriorityQueue();

            // Додавання елементів з пріоритетами
            priorityQueue.Enqueue(10, 1); // Пріоритет 1
            priorityQueue.Enqueue(20, 3); // Пріоритет 3
            priorityQueue.Enqueue(30, 2); // Пріоритет 2
            priorityQueue.Enqueue(40, 1); // Пріоритет 1

            priorityQueue.DisplayPriorityQueue();

            // Видалення елемента з найвищим пріоритетом
            Console.WriteLine("Видалення елемента з найвищим прiоритетом: " + priorityQueue.Dequeue());
            priorityQueue.DisplayPriorityQueue();
        }
    }
}
