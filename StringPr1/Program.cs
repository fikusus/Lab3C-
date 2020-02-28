/*1) В тексті самі цифри
2) В тексті букви, але текст не містить слів, де на другій позиції буква d.
3) Файл існує, але він пустий.
Реалізувати код з урахування даних тестів та вивести результати тестування на
екран.*/



using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPr1
{
    class Program
    {
 static void Main(string[] args)
        {
            int counter = 0; // лічильник слів, де d стоїть на 2-му місці
            string line; // допоміжний рядок
            char[] separator = { ' ', '.', '*', '+', ';', ',', '?', '!', '‐', '/' }; // масив
            StringBuilder otvet = new StringBuilder(); // рядок-відповідь
            try
            {
                using (StreamReader MyFile = new StreamReader("text.txt"))
                {

                    if((line = MyFile.ReadLine()) == null)
                    {
                        Console.WriteLine("Файл пустой");
                        Console.ReadKey();
                        Environment.Exit(1);
                    }

                    // читання рядка з файлу, поки це можливо
                    do
                    {
                        Console.WriteLine(line); // друкуємо, що прочитали
                                                 //виділяємо слова
                        string[] words = line.Split(separator);
                        foreach (string slovo in words) //цикл за словами, цикл foreach
                        {
                            if ((slovo.Length >= 2) && (slovo[1] == 'd'))
                            {
                                counter++;
                                otvet.Append(slovo);
                                otvet.Append(" ");
                            }
                        }
                    } while ((line = MyFile.ReadLine()) != null);
                }
                if (counter == 0)
                {
                    Console.WriteLine("Нет слов со 2 буквой d");
                }
                else
                {
                    Console.WriteLine("There were {0} sequences.", counter);
                    Console.WriteLine(otvet.ToString());
                    Console.ReadLine();
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
