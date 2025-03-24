using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha
{
    internal class PrinterQueue
    {
        private Queue<Document> queue = new Queue<Document>();
        private Stack<Document> history = new Stack<Document>();

        public void AddDocument(string title, int pages)
        {
            queue.Enqueue(new Document(title, pages));
            Console.WriteLine($"Добавен документ: {title} с {pages} стр.");
        }

        public void PrintDocument()
        {
            if (queue.Count == 0)
            {
                Console.WriteLine("Няма документи за печат.");
                return;
            }

            Document doc = queue.Dequeue();
            Console.WriteLine($"Отпечатан документ: {doc}");

            history.Push(doc);
            if (history.Count > 3)
            {
                Stack<Document> tempStack = new Stack<Document>();
                for (int i = 0; i < 3; i++)
                {
                    tempStack.Push(history.Pop());
                }
                history.Clear();
                while (tempStack.Count > 0)
                {
                    history.Push(tempStack.Pop());
                }
            }
        }

        public void ShowHistory()
        {
            if (history.Count == 0)
            {
                Console.WriteLine("Няма отпечатани документи.");
                return;
            }

            Console.WriteLine("Последни три отпечатани документа:");
            foreach (var doc in history)
            {
                Console.WriteLine(doc);
            }
        }
    }
}
