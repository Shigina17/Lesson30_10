using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson30_10
{
    class Program
    {
        public static void Task2()
        {
            Console.WriteLine("Введите вашу строку: ");
            string str = Console.ReadLine();
            char[] reverse = str.Reverse().ToArray();
            Console.WriteLine(reverse);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 8.1");
            BankAccount a = new BankAccount();
            Console.WriteLine("Введите номер первого аккаунта: ");
            a.Number = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите тип аккаунта: ");
            a.Type = Console.ReadLine();
            Console.WriteLine("Введите количество денег на счету: ");
            a.Count = int.Parse(Console.ReadLine());
            Console.WriteLine("Тип банковского аккаунта " + a.Type + ", Номер счета " + a.Number + ", Количество денег " + a.Count);
            BankAccount b = new BankAccount();
            Console.WriteLine("Введите номер второго аккаунта: ");
            b.Number = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите тип аккаунта: ");
            b.Type = Console.ReadLine();
            Console.WriteLine("Введите количество денег на счету: ");
            b.Count = int.Parse(Console.ReadLine());
            Console.WriteLine("Тип банковского аккаунта " + b.Type + ", Номер счета " + b.Number + ", Количество денег " + b.Count);
            a.GetMoney(b, -200);
            b.GetMoney(a, 200);
            Console.WriteLine($"Успешный перевод!\n Номер счета: {a.Number}, Количество денег: {a.Count}\n Номер счета: { b.Number}, Количество денег {b.Count}");

        

        
            Console.WriteLine("Упражнение 8.2");
            Task2();
             


            Console.WriteLine("Упражнение 8.3");
            Console.Write("Введите название файла: ");
            string path = @".\..\..\Res\";
            string userFileName = Console.ReadLine();
            if (File.Exists(path + userFileName))
            {
                string test = File.ReadAllText(path + userFileName);
                File.WriteAllText(path + "finish.txt", test.ToUpper());
                Console.WriteLine("Результат успешно записан в файл с именем finish");
            }
            else
            {
                Console.WriteLine($"Ошибка, файл с таким именем не найден.");
            }
            Console.ReadKey();
        }
    }
}
