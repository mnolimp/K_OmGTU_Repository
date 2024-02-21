using System.Collections;

namespace AlgorithmizationAndProgramming2102
{
    internal class Program
    {

        static String[] array = new String[10] { "123", "2nd string", "education", "trim", "smart", "glory", "456", "999", "abc", "cdec" };
        static ArrayList arrayList = new ArrayList() { "123", "2nd string", "education", "trim", "smart", "glory", "456", "999", "abc", "cdec" };
        static SortedList sortedList = new SortedList();

        static void Main(string[] args)
        {
            Console.WriteLine("Методы для Array\nИзначальный массив:");
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write("[" + array[i] + "]");
            }

            Console.WriteLine("\nCount: " + array.Count());
            Thread.Sleep(400);
            Console.WriteLine("BinSearch: ");
            Thread.Sleep(400);
            Console.WriteLine("Copy: ");
            Thread.Sleep(400);
            Console.WriteLine("Find: ");
            Thread.Sleep(400);
            Console.WriteLine("FindLast: ");
            Thread.Sleep(400);
            Console.WriteLine("IndexOf: ");
            Thread.Sleep(400);
            Console.WriteLine("Reverse: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("[" + array[i] + "]");
                Thread.Sleep(100);
            }
            Thread.Sleep(400);
            Console.WriteLine("\nResize: ");
            Thread.Sleep(400);
            Console.WriteLine("Sort: ");
            Thread.Sleep(400);

            Console.WriteLine("Нажмите любую клавишу для перехода на методы для ArrayList...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Методы для ArrayList\nИзначальный список:");
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.Write("[" + arrayList[i] + "]");
            }

            Console.WriteLine("\nCount: " + arrayList.Count);
            Thread.Sleep(400);
            Console.WriteLine("BinSearch");
            Thread.Sleep(400);
            Console.WriteLine("Copy");
            Thread.Sleep(400);
            Console.WriteLine("IndexOf");
            Thread.Sleep(400);
            Console.WriteLine("Insert");
            Thread.Sleep(400);
            Console.WriteLine("Reverse");
            Thread.Sleep(400);
            Console.WriteLine("Sort");
            Thread.Sleep(400);
            Console.WriteLine("Add");
            Thread.Sleep(400);

            Console.WriteLine("Нажмите любую клавишу для перехода на методы для SortedList...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Методы для SortedList\nИзначальный список:");
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.Write("[" + arrayList[i] + "]");
            }

            Console.WriteLine("Add");
            Thread.Sleep(400);
            Console.WriteLine("IndexOf по ключу");
            Thread.Sleep(400);
            Console.WriteLine("IndexOf по значению");
            Thread.Sleep(400);
            Console.WriteLine("Вывод ключа по индексу");
            Thread.Sleep(400);
            Console.WriteLine("Вывод значения по индексу");
            Thread.Sleep(2000);
        }
    }
}