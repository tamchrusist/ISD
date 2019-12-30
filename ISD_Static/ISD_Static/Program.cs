using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Static
{
    class Program
    {
        //метод обмена элементов
        static void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }

        //сортировка пузырьком
        static int[] BubbleSort(int[] array, string x)
        {
            var len = array.Length;
            for (var i = 1; i < len; i++)
            {
                for (var j = 0; j < len - i; j++)
                {
                    if (Direction(x))
                    {
                        if (array[j] > array[j + 1])
                        {
                            Swap(ref array[j], ref array[j + 1]);
                        }
                    }
                    else
                    {
                        if (array[j] < array[j + 1])
                        {
                            Swap(ref array[j], ref array[j + 1]);
                        }
                    }

                }
            }
            return array;
        }

        static bool Direction(string value)
        {
            if (value == "По возрастанию")
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Задание №1. Класс Calculator\n");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Введите два числа: ");
            Console.Write("a = ");
            double value1 = Double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double value2 = Double.Parse(Console.ReadLine());
            Console.WriteLine($"Сложение числа a и b: \n{Calculator.Sum(value1, value2)}");
            Console.WriteLine($"Вычитание числа b из a: \n{Calculator.Sub(value1, value2)}");
            Console.WriteLine($"Деление числа a на b: \n{Calculator.Div(value1, value2)}");
            Console.WriteLine($"Умножение числа a и b: \n{Calculator.Mult(value1, value2)}");
            Console.WriteLine($"b процентов от числа a: \n{Calculator.Percent(value1, value2)}");
            Console.WriteLine($"Остаток от деления числа a на b: \n{Calculator.Mod(value1, value2)}");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Задание №2. Сортировка. Направление сортировки\n");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Сортировка пузырьком");
            Console.Write("Введите элементы массива: ");
            var parts = Console.ReadLine().Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries);
            var array = new int[parts.Length];
            int j;
            {
                {
                    Console.WriteLine("Нажмите 1 или 2: \n1) По возрастанию \n2) По убыванию");
                    j = int.Parse(Console.ReadLine());
                    switch (j)
                    {
                        case 1:
                            Console.WriteLine("По возрастанию");
                            Direction("По возрастанию");
                            for (int i = 0; i < parts.Length; i++)
                            {
                                array[i] = Convert.ToInt32(parts[i]);
                            }
                            Console.WriteLine("Отсортированный массив: {0}", string.Join(", ", BubbleSort(array, "По возрастанию")));
                            Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("По убыванию");
                            Direction("По убыванию");
                            for (int i = 0; i < parts.Length; i++)
                            {
                                array[i] = Convert.ToInt32(parts[i]);
                            }
                            Console.WriteLine("Отсортированный массив: {0}", string.Join(", ", BubbleSort(array, "По убыванию")));
                            Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("Вы нажали что-то другое...");
                            break;
                    }
                    Console.Write("\nНажмите любую клавишу...");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Задание №3. Операции со строкой\n");
                    Console.ForegroundColor = ConsoleColor.White;

                    string test = "Hello darkness, my old friend I've come to talk with you again Because a vision softly creeping Left its seeds while I was sleeping…";

                    Console.WriteLine(test.ExtIndexOf('d'));
                    Console.WriteLine(test.ExtSubString(5, 19));
                    Console.WriteLine(test.ExtReplace("darkness", "sunless"));

                    Console.ReadLine();
                    Console.Clear();
                    Console.ReadLine();

                }
            }
        }
    }
}
