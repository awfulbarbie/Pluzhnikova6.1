using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace lab6._1._2_console_
{
    internal class Program
    {
        static int[,] Input(out int n, out int m)
        {
            while (true)
            {
                Console.WriteLine("Введите размерность двумерного массива (n - количество строк, m - количество столбцов)");
                //  Console.Write("n = ");
                try
                {
                    n = int.Parse(Console.ReadLine());
                    //   Console.Write("m = ");
                    m = int.Parse(Console.ReadLine());
                    if (n <= 0 || m <= 0)
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
            int[,] array = new int[n, m];
            Console.WriteLine("Заполните массив:");
            try
            {
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write("a[{0},{1}] = ", i, j);
                        array[i, j] = int.Parse(Console.ReadLine());
                    }
            }
            catch
            {
                Console.WriteLine("Неверные данные!");
                Environment.Exit(0); //остановка программы
            }
            
            return array;
        }
        static void Print(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++, Console.WriteLine())
                for (int j = 0; j < array.GetLength(1); j++)
                    Console.Write("{0,5} ", array[i, j]);   //5 - ширина ячейки для одного элемента
        }
        static void Sum(int[,] array)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }
            }
            if (sum < 10 || sum > 99)
            {
                Console.WriteLine($"Сумма элементов равна {sum} - не двузначное число");
            }
            else
            {
                Console.WriteLine($"Сумма элементов равна {sum} - двузначное число");
            }
        }

        static void Main(string[] args)
        {
            int n, m;
            int[,] Array = Input(out n, out m);
            Print(Array);
            Sum(Array);
        }
    }
}

