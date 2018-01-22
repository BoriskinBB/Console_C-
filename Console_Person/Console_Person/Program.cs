using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Person
{
    class Program //Класс программы, точка входа
    {
        static void Main(string[] args)
        {
            //Конструктор без параметров
            Person P_1 = new Person();
            P_1.FName = "Борискин";
            P_1.SName = "Борис";
            P_1.TName = "Борисович";
            P_1.Birthday = new DateTime(1980, 03, 12);
            P_1.Snils = "003-020-010-00";
            Console.WriteLine("Фамилия:" + " " + P_1.FName);
            Console.WriteLine("Имя:" + " " + P_1.SName);
            Console.WriteLine("Отчество:" + " " + P_1.TName);
           
            Console.WriteLine("Дата рождения:" + " " + "{0:d}", P_1.Birthday); //Формат сокращённой даты

            Console.WriteLine("СНИЛС:" + P_1.Snils);

            Console.ReadKey();

        }//End of Main
    }//End of class Program
}//End of namespase Console_Person
