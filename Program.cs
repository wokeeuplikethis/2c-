using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Data.OleDb;

namespace secondKR
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Berdiev Eduard 415gr. KR - 2 Variant - 1");
            Console.WriteLine("Напишите программу, находящую медиану массива");
            Console.WriteLine("То есть индекс ячейки массива сумма элементов слева от которой минимально отличается от суммы элементов справа.");
            List<int> array;
            array = ArrayInput();

            int choice = int.Parse(Console.ReadLine());
            int number = 0;
            var median = Median(array);

            Console.WriteLine("Array: {0}", string.Join(", ", array.Select(_ => _.ToString()).ToArray()));
            Console.WriteLine("Median: {0}", number + "`s element of array");
            Console.WriteLine("Сохранить");

            Console.ReadKey();
        }

         static List<int> ArrayInput()
        {
            Console.WriteLine("Menu: ");
            Console.WriteLine("1 - Manual input ");
            Console.WriteLine("2 - Random input ");
            Console.WriteLine("3 - File input ");
            int choice = int.Parse(Console.ReadLine());
            List<int> arr;
            switch (choice)
            {
                case 1:
                   return ManualInput();
                    
                case 2:
                   return RandomInput();
                   
                case 3:
                   return FileInput();
                    
                default:
                    Console.WriteLine("Entered wrong menu item");
                    break;
            }
            return ArrayInput();
        }
            
               
    
        
        static List <int> ManualInput()
        {
            List<int> arr;
            int size;
            Console.WriteLine("Enter the length of the array: ");
            size = int.Parse(Console.ReadLine());
            arr = new List<int>(size);

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter " + i + "`s element of array");
                arr[i] = int.Parse(Console.ReadLine());
            }

            return arr;
        }
        static List <int> RandomInput()
        {
            List<int> arr;
            int size;
            Console.WriteLine("Enter the length of the array: ");
            size = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            arr = new List <int> (size);

            for (int i = 0; i < size; i++)
            {
                arr[i] = rnd.Next(100);
            }
            return arr;
        }
        static List<int> FileInput()
        {
            List<int> arr;
            int size;
            Console.WriteLine("Enter the length of the array: ");
            size = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            arr = new List<int>(size);

            for (int i = 0; i < size; i++)
            {
                arr[i] = rnd.Next(100);
            }  
            
            return arr;
        }
        private static object Median(List<int> arr)
        {
            //считаем общую сумму
            var sum = arr.Sum();
            //перебираем элементы, пока не достигнем 50% от суммы:
            var accum = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                accum += arr[i];
                if (accum >= sum / 2)
                    return i;
            }

            return arr.Count;
        }
  
    }
}

