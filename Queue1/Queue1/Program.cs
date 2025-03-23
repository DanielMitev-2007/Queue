using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете число N от интервала [10..100]: ");
            int N = int.Parse(Console.ReadLine());

            if (N < 10 || N > 100)
            {
                Console.WriteLine("Числото трябва да бъде в интервала [10..100].");
                return;
            }

            Queue<int> queue = new Queue<int>();

            Random rand = new Random();
            for (int i = 0; i < N; i++)
            {
                int num = rand.Next(1, 102);  
                queue.Enqueue(num);
            }

            Console.WriteLine("Генерираните числа:");
            foreach (int num in queue)
            {
                Console.Write(num + " ");
            }

            List<int> evenNumbers = new List<int>();
            Stack<int> oddNumbers = new Stack<int>();

            while (queue.Count > 0)
            {
                int num = queue.Dequeue();
                if (num % 2 == 0)
                {
                    evenNumbers.Add(num);
                }
                else
                {
                    oddNumbers.Push(num);
                }
            }

            Console.WriteLine("");
            foreach (int even in evenNumbers)
            {
                Console.Write(even + " ");
            }

            while (oddNumbers.Count > 0)
            {
                Console.Write(oddNumbers.Pop() + " ");
            }

            Console.ReadKey();
        }
    }
}
