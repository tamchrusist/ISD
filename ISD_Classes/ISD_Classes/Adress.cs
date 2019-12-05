using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Classes
{
 //Задание 1
 //Требуется:
 //Создать класс с именем Address.
 //В теле класса требуется создать поля: index, country, city, street, house, apartment. Для каждого поля,
 //создать свойство с двумя методами доступа.
 //Создать экземпляр класса Address.
 //В поля экземпляра записать информацию о почтовом адресе.
 //Выведите на экран значения полей, описывающих адрес.
    class Adress
    {
        private int index;
        private string country;
        private string city;
        private string street;
        private string house;
        private string apartment;

        public int Index { set; get; }
        public string Country { set; get; }
        public string City { set; get; }
        public string Street { set; get; }
        public string House { set; get; }
        public string Apartment { set; get; }
    }
}
