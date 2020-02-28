/*Визначити два одновимірних масиви із довільною кількістю елементів,
значення яких отримувати за допомогою генератора випадкових чисел.Перший
масив зросту співробітників в сантиметрах, а другий – відповідна їхня вага в
кілограмах.Зріст і вага повинні знаходитися в заданих межах.Відсортувати їх в
порядку зростання зросту і результати вивести на екран. Кількість елементів
ввести із клавіатури.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortZavd2
{
    class Program
    {
        static void Main(string[] args)
        {
            int leaght = 0, minzr = 150, maxzr = 200, minvg = 45, maxvg = 120;
            Console.Write("Введи количество сотрудников:");
            try
            {
                leaght = Int32.Parse(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Неверный формат данных");
                Environment.Exit(1);
            }
            int[] zr = new int[leaght], vg = new int[leaght];
            Random rnd = new Random();
            for (int i = 0; i < leaght; i++)
            {
                zr[i] = rnd.Next(minzr, maxzr);
                vg[i] = rnd.Next(minvg, maxvg);
            }            PrintMass(zr, vg);
            Array.Sort(zr, vg);
            Console.WriteLine("Параметры сотрудников после сортировки по росту:");
            PrintMass(zr, vg);
            Console.ReadKey();
        }


        static void PrintMass(int[] a, int[] b)
        {
            Console.Write("Рост:");
            foreach (var item in a)
            {
                Console.Write("{0,3} ",item);
            }

            Console.Write("\nВес :");
            foreach (var item in b)
            {
                Console.Write("{0,3} ", item);
            }
            Console.WriteLine();
        }
    }
}
