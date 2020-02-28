/*
Вихідним є текстовий файл.У текст можуть входити слова з латинських букв, цифри,
знаки арифметичних операцій, крапка, кома, пробіл.Потрібно зчитати текст з файлу,
вивести його на екран, після рішення задачі вивести на екран результат.Групою букв
будемо називати таку сукупність послідовно розташованих букв (слово), якій
безпосередньо не передує і за якою безпосередньо не слідує буква.Аналогічно
визначається група цифр і група знаків.
Якщо в тексті немає символу «+», то залишити текст без змін, інакше кожну цифру
в тексті замінити на «*»
*/


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringZavd1
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
                        otvet+=line;
                    } while ((line = MyFile.ReadLine()) != null);
                }
                if(otvet.IndexOf('+') != -1)
                foreach (var item in otvet)
                {
                    if (Char.IsDigit(item))
                    {
                        otvet = otvet.Replace(item, '*');
                        change = true;
                    }

                }

                if (change)
                {
                    Console.WriteLine("Ответ: " + otvet);
                }
                else
                {
                    Console.WriteLine("Менять строку не нужно");
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
