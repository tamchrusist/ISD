using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Inheritance
{//Задание 1
    //Создайте класс Printer.
    //В теле класса создайте метод void Print(string value), который выводит на экран значение аргумента.
    //Реализуйте возможность того, чтобы в случае наследования от данного класса других классов, и вызове
   
    //соответствующего метода их экземпляра, строки, переданные в качестве аргументов методов, выводились
    //разными цветами.
    //Обязательно используйте приведение типов.

    class Printer
    {
        public virtual void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(value);
        }
    }

    class PrinterRed : Printer
    {
        public override void Print(string value)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            base.Print(value);
        }
    }

    class PrinterYellow : Printer
    {
        public override void Print(string value)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            base.Print(value);
        }
    }

    class PrinterBlue : Printer
    {
        public override void Print(string value)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            base.Print(value);
        }
    }

    class PrinterGreen : Printer
    {
        public override void Print(string value)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            base.Print(value);
        }
    }

    class PrinterCyan : Printer
    {
        public override void Print(string value)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            base.Print(value);
        }
    }

    class PrinterDarkBlue : Printer
    {
        public override void Print(string value)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            base.Print(value);
        }
    }
}
