using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Struct
{
    class Program
    {
        public static void ClassTaker(MyClass myClass)
        {
            myClass.change = "изменено";
        }

        public static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "изменено";
        }
        static void Main(string[] args)
        {

            //Задание №1.Структура Notebook


            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Задание №1. Структура Notebook\n");
            Console.ResetColor();

            Notebook notebook = new Notebook ("Коптский переплёт, японский узор, формат А5", "Ukraine", 500);
            notebook.DisplayInfo();


            //Задание №2.Структура Train


            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nЗадание №2. Структура Train\n");
            Console.ResetColor();

            //Написать программу, выполняющую следующие действия:
            //- ввод с клавиатуры данных в массив, состоящий из восьми элементов типа Train(записи должны быть
            //упорядочены по номерам поездов);
            //- вывод на экран информации о поезде, номер которого введен с клавиатуры(если таких поездов нет, вывести
            //соответствующее сообщение).

            Train[] train = new Train[8];
            Console.WriteLine("Введите номера поездов: ");
            Console.WriteLine("1-й поезд: ");
            train[0].numberTrain  = Int32.Parse(Console.ReadLine());
            Console.WriteLine("2-й поезд: ");
            train[1].numberTrain = Int32.Parse(Console.ReadLine());
            Console.WriteLine("3-й поезд: ");
            train[2].numberTrain = Int32.Parse(Console.ReadLine());
            Console.WriteLine("4-й поезд: ");
            train[3].numberTrain = Int32.Parse(Console.ReadLine());
            Console.WriteLine("5-й поезд: ");
            train[4].numberTrain = Int32.Parse(Console.ReadLine());
            Console.WriteLine("6-й поезд: ");
            train[5].numberTrain = Int32.Parse(Console.ReadLine());
            Console.WriteLine("7-й поезд: ");
            train[6].numberTrain = Int32.Parse(Console.ReadLine());
            Console.WriteLine("8-й поезд: ");
            train[7].numberTrain = Int32.Parse(Console.ReadLine());

            train[0] = new Train("Одесса", train[0].numberTrain, new DateTime(2012, 7, 20, 18, 30, 00));
            train[1] = new Train("Сумы", train[1].numberTrain, new DateTime(2012, 7, 19, 19, 30, 00));
            train[2] = new Train("Львов", train[2].numberTrain, new DateTime(2012, 7, 18, 20, 30, 00));
            train[3] = new Train("Киев", train[3].numberTrain, new DateTime(2012, 7, 17, 21, 30, 00));
            train[4] = new Train("Ужгород", train[4].numberTrain, new DateTime(2012, 7, 16, 22, 30, 00));
            train[5] = new Train("Симферополь", train[5].numberTrain, new DateTime(2012, 7, 15, 23, 30, 00));
            train[6] = new Train("Ровно", train[6].numberTrain, new DateTime(2012, 7, 14, 00, 30, 00));
            train[7] = new Train("Хмельницкий", train[7].numberTrain, new DateTime(2012, 7, 13, 01, 30, 00));

            Console.WriteLine("Введите номера поезда для вывода информации о нём: ");         
            int numberTrain = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < 8; i++)
            {
                if (numberTrain == train[i].numberTrain)
                {
                    train[i].DisplayInfo();
                    break;
                }
                else
                {
                    if(i==7)
                    {
                        Console.WriteLine("Такой поезд отсутствует в расписании");
                    }
                }                       
            }


            //Задание №3.Класс MyClass и структура MyStruct


            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nЗадание №3. Класс MyClass и структура MyStruct\n");
            Console.ResetColor();

            MyClass myClass = new MyClass();
            MyStruct myStruct = new MyStruct(); 
            
            myStruct.change = "не изменено";

            Console.WriteLine($"Поле структуры {myStruct.change}, поле класса {myClass.change}");

            ClassTaker(myClass);
            StructTaker(myStruct);

            Console.WriteLine($"Поле структуры {myStruct.change}, поле класса {myClass.change}"); //структуры передаются по значению (то есть копируются), объекты классов - по ссылке, поэтому значение myStruct.change не изменится, а myClass.change - изменится



            //Задание №4.Структура userBirthday


            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nЗадание №4. Структура userBirthday\n");
            Console.ResetColor();

            UserBirthday user = new UserBirthday();

            Console.WriteLine("Введите свою дату рождения: ");
            Console.WriteLine("Число: ");
            int day = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Месяц: ");
            int month = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Год: ");
            int year = Int32.Parse(Console.ReadLine());

            if (month > DateTime.Now.Month)
            {
                user.userBirthdayNext = new DateTime(DateTime.Now.Year, month, day, 00, 00, 00);
                user.DisplayInfoNextBirthday();
            }
            else if (month < DateTime.Now.Month)
            {
                user.userBirthdayNext = new DateTime(DateTime.Now.Year + 1, month, day, 00, 00, 00);
                user.DisplayInfoNextBirthday();
            }
            else if (month == DateTime.Now.Month)
            {
                if (day > DateTime.Now.Day)
                {
                    user.userBirthdayNext = new DateTime(DateTime.Now.Year, month, day, 00, 00, 00);
                    user.DisplayInfoNextBirthday();
                }
                else
                {
                    user.userBirthdayNext = new DateTime(DateTime.Now.Year + 1, month, day, 00, 00, 00);
                    user.DisplayInfoNextBirthday();
                }

            }


            //Задание №5.Класс Color


            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nЗадание №5. Класс Color\n");
            Console.ResetColor();

            Console.WriteLine("Введите строку: ");
            string stroka = String.Format(Console.ReadLine());
            Console.WriteLine("Введите номер цвета (1 - красный, 2 - зелёный, 3 - синий, \n4 - жёлтый, 5 - маджента): ");
            int color = Int32.Parse(Console.ReadLine());
            Color.Print(stroka, color);

            //Задание №6.Класс Accauntant, перечисление Post

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nЗадание №6. Класс Accauntant, перечисление Post\n");
            Console.ResetColor();

            Console.WriteLine("Введите индекс должности: 0 - Sales, 1 - CEO, 2 - Marketer, 3 - Support: ");
            int d = Int32.Parse(Console.ReadLine());
            Post[] worker = new[] { Post.Sales, Post.CEO, Post.Marketer, Post.Support };
            Console.WriteLine("Введите количество отработанных часов: ");
            int hours = Int32.Parse(Console.ReadLine());
            Accauntant accauntant = new Accauntant();
            Console.WriteLine($"Стоит ли давать премию данному сотруднику? - {accauntant.AskForBonus(worker[d], hours)}");
            Console.ReadLine();     
        }
    }
}
