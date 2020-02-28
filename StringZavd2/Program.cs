/*
Скласти одну або кілька програм на С# для демонстрації роботи із символьними
рядками. Продемонструвати наступні дії:
Вилучення рядків;
*/


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringZavd2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool change = false;
            string line;
            string otvet = String.Empty;
            try
            {
                using (StreamReader MyFile = new StreamReader("text.txt"))
                {
                    if ((line = MyFile.ReadLine()) == null)
                    {
                        Console.WriteLine("Файл пустой");
                        Console.ReadKey();
                        Environment.Exit(1);
                    }
                    do
                    {
                        Console.WriteLine(line);
                        otvet += line;
                    } while ((line = MyFile.ReadLine()) != null);
                }
                Console.WriteLine("Введи слово для удаления");

                line = Console.ReadLine();
                while (otvet.IndexOf(line) != -1)
                {
                    otvet = otvet.Replace(line,String.Empty);
                    change = true;
                }
                if (change)
                {
                    Console.WriteLine(otvet);
                }
                else
                {
                    Console.WriteLine("Слово в тексте не найдено");
                }
            }
            
            catch (FileNotFoundException)
            {
                Console.WriteLine("Файл не существует");
            }
            Console.ReadKey();

        }
    }
}
