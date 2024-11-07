using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turn
{
    internal class QueueExample
    {
        private Queue<int> queue = new Queue<int>();

        // Додавання елементів у чергу випадковими числами
        public void FillQueue(int n)
        {
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(random.Next(1, 100)); // Випадкові числа від 1 до 100
            }
        }

        // Метод для видалення та виведення перших k елементів
        public void DequeueElements(int k)
        {
            Console.WriteLine($"Першi {k} елементiв черги:");
            for (int i = 0; i < k && queue.Count > 0; i++)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }

        // Метод для очищення черги
        public void Clear()
        {
            queue.Clear();
            Console.WriteLine("Чергу очищено.");
        }

        // Метод для виведення вмісту черги
        public void DisplayQueue()
        {
            if (queue.Count == 0)
            {
                Console.WriteLine("Черга порожня.");
                return;
            }

            Console.WriteLine("Вмiст черги:");
            foreach (int item in queue)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
