using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lab6._2_console_
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

        static int Value(int[] array)
        {
            int num_value = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] < array[i + 1])
                {
                    num_value++;
                }
                else
                {
                    num_value = 0;
                }
            }
            return num_value;
        }

        static void Main(string[] args)
        {
            int[] Array = Input();
            int val = Value(Array);
            if (val > 0)
            {
                Console.WriteLine("Количество элементов, значение которых больше значения предыдущего элемента = " + val);
            }
            else
            {
                Console.WriteLine("Таких элементов нет");
            }
            

        }
        }
    }

