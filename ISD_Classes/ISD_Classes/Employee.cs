using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Classes
{   //Задание 7
    //Требуется:
    //Создать класс Employee.
    //В теле класса создать пользовательский конструктор, который принимает два строковых аргумента, и
    //инициализирует поля, соответствующие фамилии и имени сотрудника.
    //Создать метод рассчитывающий оклад сотрудника (в зависимости от должности и стажа) и налоговый сбор.
    //Написать программу, которая выводит на экран информацию о сотруднике(фамилия, имя, должность), оклад и
    //налоговый сбор.
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public int Experience { get; set; }
        public double BaseSalary { get; set; } = 10000;
        public double Tax { get; set; } = 0.2;


        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public double getSalary()
        {
            if (Position == "manager" && Experience >= 3)
            {
                double salary = BaseSalary * 1.5;
                return salary;
            }
            else

            if (Position == "marketer" && Experience >= 3)
            {
                double salary = BaseSalary * 3;
                return salary;
            }
            else

            if (Position == "hr" && Experience >= 3)
            {
                double salary = BaseSalary * 2;
                return salary;
            }

            else if (Position == "marketer" && Experience < 3)
            {
                return BaseSalary * 1.5;
            }
            else
                return BaseSalary;
        }
    }
}
