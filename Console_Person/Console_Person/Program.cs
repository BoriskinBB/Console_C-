using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person P_1 = new Person();
            Console.WriteLine("Пример вводимых данных:");
            Console.WriteLine("Ваше Фамилия:" + " " + "Иванов");
            Console.WriteLine("Ваше Имя:" + " " + "Иван");
            Console.WriteLine("Ваше Отчество:" + " " + "Ивановов");
            Console.WriteLine("Вы родились:" + " " + "01.01.1600 года");
            Console.WriteLine("Введите Вашу Фамилию:"); String F = Console.ReadLine();
            Console.WriteLine("Введите Ваше Имя:");
            Console.WriteLine("Введите Ваше Отчество:");
           
            String N = Console.ReadLine();
            String L = Console.ReadLine();
            Console.WriteLine("Ваша Фамилия:" + " " + F + N + L);
            Console.ReadKey();
            Console.WriteLine("Вас зовут:" + " " + N);
        }
    }
}
