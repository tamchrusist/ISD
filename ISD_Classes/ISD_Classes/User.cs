using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Classes
{   //Задание 5
    //Требуется:
    //Создать класс User, содержащий информацию о пользователе (логин, имя, фамилия, возраст, дата заполнения
    //анкеты). Поле дата заполнения анкеты должно быть проинициализировано только один раз(при создании
    //экземпляра данного класса) без возможности его дальнейшего изменения.
    //Реализуйте вывод на экран информации о пользователе.
    class User
    {
        private string login;
        private string firstName;
        private string lastName;
        private int age;
        private DateTime date;

        public string Login { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime Date { get; private set; } = DateTime.Today;      
    }
}
