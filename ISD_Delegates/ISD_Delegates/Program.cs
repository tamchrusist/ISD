using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Delegates
{
    delegate double Operation1 (int x, int y, int z);
    delegate double Operation2 (double x, double y);
    delegate string Operation3 (double x, double y);
    delegate int MyDelegate();
    delegate double MyDel(MyDelegate[] a);

    class Program
    {
        //Задание 1
        //Создайте анонимный метод, который принимает в качестве параметров три целочисленных аргумента и
        //возвращает среднее арифметическое этих аргументов.
        //Задание 2
        //Создайте четыре лямбда оператора для выполнения арифметических действий: (Add – сложение, Sub –
        //вычитание, Mul – умножение, Div – деление). Каждый лямбда оператор должен принимать два аргумента и
        //возвращать результат вычисления.Лямбда оператор деления должен делать проверку деления на ноль.
        //Написать программу, которая будет выполнять арифметические действия указанные пользователем.
        //Задание 3
        //Создайте анонимный метод, который принимает в качестве аргумента массив делегатов и возвращает среднее
        //арифметическое возвращаемых значений методов сообщенных с делегатами в массиве.Методы, сообщенные с
        //делегатами из массива, возвращают случайное значение типа int.
        static Random rand = new Random();
        static int GetRandom()
        {
            return rand.Next(100);
        }

        static void Main(string[] args)
        {   Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Задание №1. Анонимный метод, среднее арифметическое значение\n");
            Console.ResetColor();
            Operation1 operation = delegate (int x, int y, int z)
            {
                return (x + y + z)/3;
            };
            double d = operation (4, 5, 9);
            Console.WriteLine(d);       // 6

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nЗадание №2. Add, Sub, Mul, Div\n");
            Console.ResetColor();
           
            Operation2 Add = (x, y) => x + y;
            Operation2 Sub = (x, y) => x - y;
            Operation2 Mul = (x, y) => x * y;
            Operation3 Div = (x, y) =>
            {
                if (y != 0)
                    return (x / y).ToString();
                else
                    return "Деление на ноль!";
            };

            Console.WriteLine(Add(10, 20)); //30
            Console.WriteLine(Sub(10, 20)); //-10
            Console.WriteLine(Mul(10, 20)); //200
            Console.WriteLine(Div(10, 20)); //0.5

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nЗадание №3. Массив делегатов\n");
            Console.ResetColor();

            Console.WriteLine("Введите число элементов массива:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(new string('-', 50));

            var array = new MyDelegate[n]; 

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = () => new MyDelegate(GetRandom).Invoke();
            }

            MyDel s = delegate (MyDelegate[] c)
            {
                double sr = 0;
                for (int i = 0; i < c.Length; i++)
                {
                    sr += c[i].Invoke();

                }
                return sr / array.Length;
            };

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i].Invoke() + " ");
            }

            Console.WriteLine("\nСреднее арифметическое элементов {0}", s(array));

            Console.Read();
        }
    }
}
