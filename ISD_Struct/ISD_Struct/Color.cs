using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Struct
{
    //Задание 5
//Создайте статический класс с методом void Print(string stroka, int color), который выводит на экран
//строку заданным цветом.Используя перечисление, создайте набор цветов, доступных пользователю.Ввод
//строки и выбор цвета предоставьте пользователю.
    static class Color
    {

        static public void Print(string stroka, int color)
        {
            if (color==1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(stroka);
                Console.ResetColor();
            }
            else if (color == 2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(stroka);
                Console.ResetColor();
            }
            else if (color == 3)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(stroka);
                Console.ResetColor();
            }
            else if (color == 4)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(stroka);
                Console.ResetColor();
            }
            else if (color == 5)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(stroka);
                Console.ResetColor();
            }
        }
    }
}
