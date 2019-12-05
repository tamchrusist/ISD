using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Classes
{       

    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Задание №1. Класс Adress\n");
            Console.ForegroundColor = ConsoleColor.White;
            Adress adress = new Adress();
            adress.Index = 49106;
            adress.Country = "Ukraine";
            adress.City = "Dnipro";
            adress.Street = "Novorichna";
            adress.House = "77";
            adress.Apartment = "54";
            Console.WriteLine($"Dear Saint Nicholas, send gifts to: \n{adress.Index}, {adress.Country}, {adress.City}, {adress.Street} street, house {adress.House}, apartment {adress.Apartment}");


            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nЗадание №2. Класс Rectangle\n");
            Console.ForegroundColor = ConsoleColor.White;
            Rectangle rectangle = new Rectangle(2.6, 5.77);
            Console.WriteLine($"Площадь прямоугольника равна {rectangle.AreaCalculator()} см2, периметр прямоугольника равен {rectangle.PerimeterCalculator()} см");


            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nЗадание №3. Класс Book (Title, Author, Content)\n");
            Console.ForegroundColor = ConsoleColor.White;
            Title title = new Title("Оно");
            Author author = new Author("Стивен Кинг");
            Content content = new Content("\nГлава 1. Наводнение(1957).\nГлава 2. Праздник (1984).\nГлава 3. Шесть телефонных звонков(1985)\nГлава 4. Эдди Каспбрак собирает аптечку\nГлава 5. Беверли Роган получает взбучку\nГлава 6. Билл Денборо берет тайм-аут\nГлава 7. Запруда в Барренс\nГлава 8. Комната Джорджи и дом на Нейболт-Стрит\nГлава 9. Уборка");
            Book book = new Book(title, author, content);
            book.Show();


            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nЗадание №4. Класс Point, Figure\n");
            Console.ForegroundColor = ConsoleColor.White;
            Point A = new Point(5, -8);
            Point B = new Point(8, -2);
            Point C = new Point(17, 12);
            Point D = new Point(-1, -1);
            //Point E = new Point(0, 18);
            Figure figure = new Figure(A, B, C, D/*, E*/);
            figure.PerimeterCalculator(A, B, C, D/*, E*/);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nЗадание №5. Класс User\n");
            Console.ForegroundColor = ConsoleColor.White;

            User user = new User();
            user.Login = "tamchrusist";
            user.FirstName = "Sergey";
            user.LastName = "Krivosheya";
            user.Age = 34;
            
            Console.WriteLine($"User: {user.Login}, {user.FirstName}, {user.LastName}, {user.Age}, {user.Date}");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nЗадание №6. Класс Converter\n");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Введите сумму в долларах:");
            double usd = Double.Parse(Console.ReadLine());  
            Console.WriteLine("Введите сумму в евро:");
            double eur = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите сумму в рублях:");
            double rub = Double.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Blue;
            Converter converterVal = new Converter(usd, eur, rub);
            Console.WriteLine($"\nПеревод валют в гривну:\n{usd} долларов - {converterVal.UahUsd} гривен;\n{eur} евро - {converterVal.UahEur} гривен;\n{rub} рублей - {converterVal.UahRub} гривен");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\nВведите сумму в гривнах:");
            double uah = Double.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Yellow;
            Converter converterUah = new Converter(uah);
            Console.WriteLine($"\nПеревод гривны в валюту:\n{uah} гривен - {converterUah.UahUsd} долларов;\n{uah} гривен - {converterUah.UahEur} евро;\n{uah} гривен - {converterUah.UahRub} рублей");
            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nЗадание №7. Класс Employee\n");
            Console.ForegroundColor = ConsoleColor.White;

            Employee employee1 = new Employee("John", "Smith");
            Employee employee2 = new Employee("Sara", "Connor");
            Employee employee3 = new Employee("Jerry", "Heil");

            employee1.Position = "manager";
            employee1.Experience = 2;
            employee2.Position = "marketer";
            employee2.Experience = 4;
            employee3.Position = "hr";
            employee3.Experience = 5;

            Console.WriteLine($"\nСотрудник №1:\nИмя - {employee1.FirstName};\nФамилия - {employee1.LastName};\nДолжность - {employee1.Position};\nСтаж - {employee1.Experience};\nЗарплата - {employee1.getSalary()} за вычетом налогового сбора - {employee1.Tax}% или в деньгах минус {employee1.Tax* employee1.getSalary()}");
            Console.WriteLine($"\nСотрудник №2:\nИмя - {employee2.FirstName};\nФамилия - {employee2.LastName};\nДолжность - {employee2.Position};\nСтаж - {employee2.Experience};\nЗарплата - {employee2.getSalary()} за вычетом налогового сбора - {employee2.Tax}% или в деньгах минус {employee2.Tax * employee2.getSalary()}");
            Console.WriteLine($"\nСотрудник №3:\nИмя - {employee3.FirstName};\nФамилия - {employee3.LastName};\nДолжность - {employee3.Position};\nСтаж - {employee3.Experience};\nЗарплата - {employee3.getSalary()} за вычетом налогового сбора - {employee3.Tax}% или в деньгах минус {employee3.Tax * employee3.getSalary()}");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nЗадание №8. Класс Invoice\n");
            Console.ForegroundColor = ConsoleColor.White;

            Invoice invoice = Invoice.getInstance (33321, "Krivosheya S. A.", "MultiToys");
            invoice.Article = 3;
            invoice.Quantity = 7;
            Console.WriteLine($"\nАккаунт: {invoice.Account}; \nПокупатель: {invoice.Customer}; \nПоставщик: {invoice.Provider}; \nАртикль товара: {invoice.Article}; \nКоличество товара: {invoice.Quantity};\nЦена всего: {invoice.getPrice(invoice.Article, invoice.Quantity)}; \nЦена всего с учётом НДС: {1.2*(invoice.getPrice(invoice.Article, invoice.Quantity))}");          
            Console.ReadLine();
        }
    }
}
