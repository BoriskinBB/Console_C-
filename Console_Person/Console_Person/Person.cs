using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Person //Пространство имён класса персона
{
    public class Person //Класс (таблица полей персоны в основной ветке master)
    {
        private string fName; //Поле фамилия
        private string sName; //Поле имя
        private string tName; //Отчество
        private DateTime birthday; //Дата рождения
        // Свойства полей...
        public string FName { get {return fName;} set { fName = value; } }
        public string SName { get { return sName;} set { sName = value; } }
        public string TName { get { return tName; } set { tName = value; } }
        public DateTime Birthday { get { return birthday; } set { birthday = value; } }
    } //End of class Person
} //End of namespace
