using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cheakLINK // это объявление пространства имен с именем. Все типы, определенные внутри этого блока кода, будут принадлежать к пространству имен "cheakLINK"
{
    internal class Program // это объявление класса с именем Program. Ключевое слово internal означает, что класс доступен только внутри текущей сборки (assembly).
    {
        static void Main(string[] args)
        //static означает, что метод принадлежит классу, а не конкретному объекту этого класса.
        //void указывает на то, что метод не возвращает никакого значения.
        //(string[] args) - это параметры метода. В данном случае string[] args означает, что метод Main принимает массив строк в качестве аргументов.
        //Обычно args используется для передачи аргументов командной строки в программу. Квадратные скобки указывают на то, что это массив.
        {
            Console.WriteLine("Веедите ссылку:");
            string link = Console.ReadLine();
            Console.WriteLine("Вы введи даннную ссылку:" + link);
            string linkgood = LinkCorrected(link);
            Console.WriteLine("Исправленный вариант:" + linkgood);
            Console.ReadLine();
        }
        public static string LinkCorrected (string str)
        {
        if (str.StartsWith("https://"))
            {
                return str;
            }
        else
            {
                return "https://" + str;
            }
        }

    }
}
