using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace lab6._1._1_console_
{
    internal class Program
    {
        static int[] Input()
        {
            int n = 0;
            while (true)
            {
                Console.WriteLine("Введите размерность массива [n]");
                try
                {
                    n = int.Parse(Console.ReadLine());
                    if (n <= 0)
                    {
                        Console.WriteLine("Ошибка! Размерность массива не может иметь отрицательное или нулевое значение");
                        continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Ошибка! Неверный формат ввода данных");

                }
            }
            

            Console.WriteLine("Введите элемнты массива: ");
            int[] array = new int[n];
            try
            {
                for (int i = 0; i < n; ++i)
                {
                    Console.Write("a[{0}]= ", i);
                    array[i] = int.Parse(Console.ReadLine());
                }
            }
            catch
            {
                Console.WriteLine("Некорректные данные!");
                Environment.Exit(0); //остановка программы
            }
            return array;
        }
        static void Print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            } 
        }
        static void Sum(int[] array)
        {
            int m = 0;
            for (int i = 0; i < array.Length; i++)
            {
                m += array[i];
            }
            if (m < 10 || m > 99)
            {
                Console.WriteLine($"Сумма элементов равна {m} - не двузначное число");
            }
            else
            {
                Console.WriteLine($"Сумма элементов равна {m} - двузначное число");
            }
                
        }

        static void Main(string[] args)
        {
            int[] Array = Input();
            Print(Array);
            Sum(Array);
        }
    }
}
