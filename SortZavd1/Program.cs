/*Визначити два одновимірних масиви із заданими кількостями
елементів, значення яких в заданих межах отримувати за допомогою генератора
випадкових чисел.Відсортувати їх в порядку зростання елементів одного із них і
результати вивести на екран*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortZavd1
{
    class Program
    {
        static void Main(string[] args)
        {
            int leaght = 10, minv = 10, maxv = 99;
            int[] a = new int[leaght], b = new int[leaght];
            Random rnd = new Random();
            for(int i = 0; i < leaght; i++)
            {
                a[i] = rnd.Next(minv, maxv);
                b[i] = rnd.Next(minv, maxv);
            }            PrintMass(a, b);
            Array.Sort(a, b);
            Console.WriteLine("Массивы после cортировки по первому массиву:");
            PrintMass(a, b);
            Console.ReadKey();
        }


        static void PrintMass(int[] a, int[] b)
        {
            Console.Write("a:");
            foreach (var item in a)
            {
                Console.Write(item + " ");
            }

            Console.Write("\nb:");
            foreach (var item in b)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
