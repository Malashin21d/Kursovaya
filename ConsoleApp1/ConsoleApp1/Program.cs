using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Queue queue = new Queue();
        Random rnd = new Random();

        // заполним очередь случайными числами
        for (int i = 0; i < 10; i++)
        {
            int num = rnd.Next(1, 100);
            queue.Enqueue(num);
        }

        // выведем на экран все элементы очереди
        Console.WriteLine("Элементы очереди:");
        foreach (int num in queue)
        {
            Console.Write(num + " ");
        }

        // извлечем два элемента из очереди
        int first = (int)queue.Dequeue();
        int second = (int)queue.Dequeue();

        Console.WriteLine("\n\nПервый извлеченный элемент: " + first);
        Console.WriteLine("Второй извлеченный элемент: " + second);

        // выведем на экран все элементы очереди после извлечения двух элементов
        Console.WriteLine("\nЭлементы очереди после извлечения двух элементов:");
        foreach (int num in queue)
        {
            Console.Write(num + " ");
        }

        // добавим еще один элемент в очередь
        int newNum = rnd.Next(1, 100);
        queue.Enqueue(newNum);

        Console.WriteLine("\n\nНовый элемент, добавленный в очередь: " + newNum);

        // выведем на экран все элементы очереди после добавления нового элемента
        Console.WriteLine("\nЭлементы очереди после добавления нового элемента:");
        foreach (int num in queue)
        {
            Console.Write(num + " ");
        }

        Console.ReadKey();
    }
}