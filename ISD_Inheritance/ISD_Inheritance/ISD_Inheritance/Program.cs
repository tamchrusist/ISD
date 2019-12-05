using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Задание №1. Класс Printer\n");
            Console.ForegroundColor = ConsoleColor.White;
        
            PrinterRed red = new PrinterRed();
            PrinterBlue blue = new PrinterBlue();
            PrinterYellow yellow = new PrinterYellow();
            PrinterGreen green = new PrinterGreen();
            PrinterCyan cyan = new PrinterCyan();
            PrinterDarkBlue darkBlue = new PrinterDarkBlue();

            red.Print("Hello darkness, my old friend");
            blue.Print("I've come to talk with you again");
            yellow.Print("Because a vision softly creeping");
            green.Print("Left its seeds while I was sleeping");
            cyan.Print("And the vision that was planted in my brain");
            darkBlue.Print("Still remains");
            red.Print("Within the sound of silence...");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nЗадание №2. Класс ClassRoom\n");
            Console.ForegroundColor = ConsoleColor.White;

            Pupil Sergey = new ExcelentPupil();
            Pupil Stepan = new GoodPupil();
            //Pupil Elena = new GoodPupil();
            Pupil Egor = new BadPupil();
            ClassRoom classRoom = new ClassRoom(Sergey, Stepan, Egor/*, Elena*/);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nЗадание №3. Класс Vehicle\n");
            Console.ForegroundColor = ConsoleColor.White;

            Plane Boeing747_400 = new Plane();
            Car LamborghiniAventador = new Car();
            Ship Azimut46 = new Ship();

            Boeing747_400.Price = 379100000;
            Boeing747_400.Speed = 912;
            Boeing747_400.Year = 2007;
            Boeing747_400.Passengers = 524;
            Boeing747_400.Height = 10700;

            LamborghiniAventador.Price = 700570;
            LamborghiniAventador.Speed = 350;
            LamborghiniAventador.Year = 2019;

            Azimut46.Price = 308970;
            Azimut46.Speed = 55;
            Azimut46.Year = 2000;
            Azimut46.Passengers = 10;
            Azimut46.Port = "Ukraine, Odessa";

            Console.WriteLine("Характеристики самолёта Boeing747-400: ");
            Console.WriteLine($"Цена: {Boeing747_400.Price} $; \nСкорость: {Boeing747_400.Speed} км/ч; \nГод выпуска: {Boeing747_400.Year}; \nНабор высоты: {Boeing747_400.Height} м; \nКоличество пассажиров: {Boeing747_400.Passengers} человека");
            Console.WriteLine("\nХарактеристики автомобиля Lamborghini Aventador: ");
            Console.WriteLine($"Цена: {LamborghiniAventador.Price} $; \nСкорость: {LamborghiniAventador.Speed} км/ч; \nГод выпуска: {LamborghiniAventador.Year}");
            Console.WriteLine("\nХарактеристики автомобиля Lamborghini Aventador: ");
            Console.WriteLine($"Цена: {Azimut46.Price} $; \nСкорость: {Azimut46.Speed} км/ч; \nГод выпуска: {Azimut46.Year}, \nКоличество пассажиров: {Azimut46.Passengers} человек; \nПорт приписки: {Azimut46.Port}");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nЗадание №4. Класс DocumentWorker\n");
            Console.ForegroundColor = ConsoleColor.White;

            int keyPro = 171185;
            int keyExpert = 160711;

            Console.WriteLine("Введите ключ: ");
            int key = Int32.Parse(Console.ReadLine());

            if (key == keyPro)
            {
                DocumentWorker document = new ProDocumentWorker();
                document.OpenDocument();
                document.EditDocument();
                document.SaveDocument();
            }
            else if (key == keyExpert)
            {
                DocumentWorker document = new ExpertDocumentWorker();
                document.OpenDocument();
                document.EditDocument();
                document.SaveDocument();
            }
            else
            {
                DocumentWorker document = new DocumentWorker();
                document.OpenDocument();
                document.EditDocument();
                document.SaveDocument();
            }

            Console.ReadLine();

        }
    }
}
