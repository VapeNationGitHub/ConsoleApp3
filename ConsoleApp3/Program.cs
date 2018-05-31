using System;
using System.Collections.Generic;
using System.Threading;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создадим связный список
            LinkedList<string> link = new LinkedList<string>();

            // Добавим несколько элементов
            link.AddFirst("A");
            link.AddFirst("B");
            link.AddFirst("C");
            link.AddFirst("D");

            // Отобразим элементы
            LinkedListNode<string> node;
            RepeatWord1:
            Console.WriteLine("\n\nЭлементы коллекции: ");
            for (node = link.Last; node != null; node = node.Previous)
                Console.Write(node.Value + "\t");

            
            Console.Write("Введите первое слово: ");
            string word = Console.ReadLine();
            if (word == "A" | word == "a")
            {

                Console.WriteLine("Слово введено правильно, повторяйте следующие слова!");
                Console.WriteLine("Второе слово появится через 1 день...");
                Thread.Sleep(5000);
                LinkedList<string> link1 = new LinkedList<string>();
                link1.AddFirst("B");
                link1.AddFirst("C");
                link1.AddFirst("D");
                link1.AddFirst("A");

                LinkedListNode<string> node1;
                Console.WriteLine("\n\nЭлементы коллекции: ");
                for (node1 = link1.Last; node1 != null; node1 = node1.Previous)
                    Console.Write(node1.Value + "\t");
            }

            RepeatWord2:
            Console.Write("Введите второе слово: ");
            string word2 = Console.ReadLine();
            if (word2 == "B" | word2 == "b")
            {
                Console.WriteLine("Слово введено правильно, повторяйте следующие слова!");
                Console.WriteLine("Третье слово появится через 2 дня...");
                Thread.Sleep(6000);
                LinkedList<string> link1 = new LinkedList<string>();
                link1.AddFirst("C");
                link1.AddFirst("D");
                link1.AddFirst("A");
                link1.AddFirst("B");

                LinkedListNode<string> node1;
                Console.WriteLine("\n\nЭлементы коллекции: ");
                for (node1 = link1.Last; node1 != null; node1 = node1.Previous)
                    Console.Write(node1.Value + "\t");
            }
            else
            {
                Console.WriteLine("Воторое слово введено не правильно, возвращаетесь к первому слову!");
                goto RepeatWord1;
            }

            RepeatWord3:
            Console.Write("Введите третье слово: ");
            string word3 = Console.ReadLine();
            if (word3 == "C" | word3 == "c")
            {
                Console.WriteLine("Слово введено правильно, повторяйте следующие слова!");
                Console.WriteLine("Четвертое слово появится через 3 дня...");
                Thread.Sleep(7000);
                LinkedList<string> link1 = new LinkedList<string>();
                link1.AddFirst("D");
                link1.AddFirst("A");
                link1.AddFirst("B");
                link1.AddFirst("C");

                LinkedListNode<string> node1;
                Console.WriteLine("\n\nЭлементы коллекции: ");
                for (node1 = link1.Last; node1 != null; node1 = node1.Previous)
                    Console.Write(node1.Value + "\t");
            }
            else
            {
                Console.WriteLine("Третье слово введено не правильно, возвращаетесь ко второму слову!");
                goto RepeatWord2;
            }

            
            Console.Write("Введите четвертое слово: ");
            string word4 = Console.ReadLine();
            if (word4 == "D" | word4 == "d")
            {
                Console.WriteLine("Все слова введены правильно, вы прошли обучение!");
                LinkedList<string> link1 = new LinkedList<string>();
                link1.AddFirst("A");
                link1.AddFirst("B");
                link1.AddFirst("C");
                link1.AddFirst("D");

                LinkedListNode<string> node1;
                Console.WriteLine("\n\nЭлементы коллекции: ");
                for (node1 = link1.Last; node1 != null; node1 = node1.Previous)
                    Console.Write(node1.Value + "\t");
            }
            else
            {
                Console.WriteLine("Четвертое слово введено не правильно, возвращаетесь к третьему слову!");
                goto RepeatWord3;
            }

            Console.ReadLine();
        }
    }
}