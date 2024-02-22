using System.Collections;

namespace AlgorithmizationAndProgramming2102
{
    internal class Program
    {

        static String[] array = new String[10] { "trim", "2nd string", "temp", "123", "smart", "peekp", "456", "999", "abc", "cdec" };
        static ArrayList arrayList = new ArrayList() { "trim", "2nd string", "temp", "123", "smart", "peekp", "456", "999", "abc", "cdec" };
        static SortedList sortedList = new SortedList();

        static void Main(string[] args)
        {
            Console.WriteLine("Методы для Array\nИзначальный массив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("[" + array[i] + "]");
            }

            Console.WriteLine("\nCount: " + array.Count());

            Console.WriteLine("Copy для 5 элементов изначального массива начиная со второго элемента: ");
            String[] copiedArray = new String[5];
            Array.Copy(array, 1, copiedArray, 0, 5);
            for (int i = 0; i < copiedArray.Length; i++)
            {
                Console.Write("[" + copiedArray[i] + "]");
            }
            
            Console.WriteLine("\nFind для строки, длиннее 5 символов: " + Array.Find(array, str => str.Length > 5));
            
            Console.WriteLine("FindLast для строки, оканчивающейся на <p>: " + Array.FindLast(array, str => str.Substring(str.Length - 1).ToLower().Equals("p")));
            
            Console.WriteLine("IndexOf для строки <temp>: " + Array.IndexOf(array, "temp"));
            
            Console.WriteLine("Reverse: ");
            Array.Reverse(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("[" + array[i] + "]");
            }
            Array.Reverse(array);
            

            Array.Resize(ref array, 15);
            Console.WriteLine("\nResize до 15 элементов: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("[" + array[i] + "]");
            }
            Array.Resize(ref array, 10);
            

            Console.WriteLine("\nSort: ");
            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("[" + array[i] + "]");
            }
            
            Console.WriteLine("\nBinSearch для строки <trim> в отсортированном массиве: " + Array.BinarySearch(array, "trim"));
            
            Console.WriteLine("Нажмите любую клавишу для перехода на методы для ArrayList...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Методы для ArrayList\nИзначальный список:");
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.Write("[" + arrayList[i] + "]");
            }
            

            Console.WriteLine("\nCount: " + arrayList.Count);
            
            String[] targetArray = new String[arrayList.Count + 3];
            arrayList.CopyTo(targetArray, 3);
            Console.WriteLine("CopyTo в массив с целевым индексом 3: ");
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.Write("[" + targetArray[i] + "]");
            }
            
            Console.WriteLine("\nIndexOf для строки <smart>: " + arrayList.IndexOf("smart"));

            arrayList.Insert(7, "000");
            Console.WriteLine("Insert для строки <000> с индексом 7: ");
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.Write("[" + arrayList[i] + "]");
            }

            Console.WriteLine("\nReverse: ");
            arrayList.Reverse();
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.Write("[" + arrayList[i] + "]");
            }
            arrayList.Reverse();

            Console.WriteLine("Add для строки <CoffeeLake>: ");
            arrayList.Add("CoffeeLake");
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.Write("[" + arrayList[i] + "]");
            }

            Console.WriteLine("Sort: ");
            arrayList.Sort();
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.Write("[" + arrayList[i] + "]");
            }

            Console.WriteLine("\nBinSearch для строки <peekp>: " + arrayList.BinarySearch("peekp"));
            
            Console.WriteLine("Нажмите любую клавишу для перехода на методы для SortedList...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Методы для SortedList\nИзначальный список:");
            for (int i = 0; i < sortedList.Count; i++)
            {
                Console.Write("[" + sortedList[i] + "]");
            }

            Console.WriteLine("Add");

            Console.WriteLine("IndexOf по ключу");

            Console.WriteLine("IndexOf по значению");
            
            Console.WriteLine("Вывод ключа по индексу");
            
            Console.WriteLine("Вывод значения по индексу");
            Thread.Sleep(2000);
        }
    }
}