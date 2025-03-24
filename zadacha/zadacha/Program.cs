using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrinterQueue printerQueue = new PrinterQueue();
            string command;
            Console.WriteLine("Принтерна опашка. Въведете команда (add <title> <pages>, print, history, exit):");
            while (true)
            {
                Console.Write(" > ");
                command = Console.ReadLine()?.Trim();

                if (string.IsNullOrEmpty(command)) continue;
                if (command.ToLower() == "exit") break;

                string[] parts = command.Split(' ');
                if (parts.Length > 0)
                {
                    switch (parts[0].ToLower())
                    {
                        case "add":
                            if (parts.Length < 3 || !int.TryParse(parts[2], out int pages))
                            {
                                Console.WriteLine("Грешен формат. Използвайте: add <title> <pages>");
                            }
                            else
                            {
                                printerQueue.AddDocument(parts[1], pages);
                            }
                            break;
                        case "print":
                            printerQueue.PrintDocument();
                            break;
                        case "history":
                            printerQueue.ShowHistory();
                            break;
                        default:
                            Console.WriteLine("Невалидна команда. Опитайте отново.");
                            break;
                    }
                }
            }
                Console.ReadKey();
        }
    }
}
