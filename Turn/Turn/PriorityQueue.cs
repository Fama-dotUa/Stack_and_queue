using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turn
{
    internal class PriorityQueue
    {
        private SortedDictionary<int, Queue<int>> priorityQueue = new SortedDictionary<int, Queue<int>>();

        // Метод для додавання елементів з пріоритетом
        public void Enqueue(int item, int priority)
        {
            if (!priorityQueue.ContainsKey(priority))
            {
                priorityQueue[priority] = new Queue<int>();
            }
            priorityQueue[priority].Enqueue(item);
        }

        // Метод для видалення елемента з найвищим пріоритетом
        public int? Dequeue()
        {
            if (priorityQueue.Count == 0)
                return null;

            foreach (var priority in priorityQueue.Keys)
            {
                if (priorityQueue[priority].Count > 0)
                {
                    int item = priorityQueue[priority].Dequeue();
                    if (priorityQueue[priority].Count == 0)
                    {
                        priorityQueue.Remove(priority);
                    }
                    return item;
                }
            }
            return null;
        }

        // Метод для виведення вмісту пріоритетної черги
        public void DisplayPriorityQueue()
        {
            if (priorityQueue.Count == 0)
            {
                Console.WriteLine("Прiоритетна черга порожня.");
                return;
            }

            Console.WriteLine("Вмiст прiоритетної черги:");
            foreach (var pair in priorityQueue)
            {
                foreach (var item in pair.Value)
                {
                    Console.WriteLine($"Елемент: {item}, Прiоритет: {pair.Key}");
                }
            }
        }
    }
}
