using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Classes
{
    //Задание 4
    //Требуется:
    //Создать классы Point и Figure.
    //Класс Point должен содержать два целочисленных поля и одно строковое поле.
    //Создать три свойства с одним методом доступа get.
    //Создать пользовательский конструктор, в теле которого проинициализируйте поля значениями аргументов.
    //Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти аргументов типа Point.
    //Создать два метода: double LengthSide(Point A, Point B), который рассчитывает длину стороны
    //многоугольника; void PerimeterCalculator(), который рассчитывает периметр многоугольника.
    //Написать программу, которая выводит на экран название и периметр многоугольника.

    public class Figure
    {
        public Point point1;
        public Point point2;
        public Point point3;
        public Point point4;
        public Point point5;

        public Figure(Point point1, Point point2, Point point3)
        {
            Console.WriteLine("Фигура - треугольник");
            this.point1 = point1;
            this.point2 = point2;
            this.point3 = point3;
        }

        public Figure(Point point1, Point point2, Point point3, Point point4)
        {
            Console.WriteLine("Фигура - четырёхугольник");
            this.point1 = point1;
            this.point2 = point2;
            this.point3 = point3;
            this.point4 = point4;
        }

        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            Console.WriteLine("Фигура - пятиугольник");
            this.point1 = point1;
            this.point2 = point2;
            this.point3 = point3;
            this.point4 = point4;
            this.point4 = point5;
        }

        public static double LengthSide(Point A, Point B)
        {
            new Point(A.PointX, A.PointY);
            new Point(B.PointX, B.PointY);
            double lengthSide = Math.Sqrt(Math.Pow(A.PointX - B.PointX, 2) + Math.Pow(A.PointY - B.PointY, 2));
            return lengthSide;
        }

        public void PerimeterCalculator(Point point1, Point point2, Point point3)
        {
            double perimeterCalculator = Figure.LengthSide(point1, point2) + Figure.LengthSide(point2, point3) + Figure.LengthSide(point3, point1);
            Console.WriteLine($"Периметр треугольника равен {perimeterCalculator}");
        }

        public void PerimeterCalculator(Point point1, Point point2, Point point3, Point point4)
        {
            double perimeterCalculator = Figure.LengthSide(point1, point2) + Figure.LengthSide(point2, point3) + Figure.LengthSide(point3, point4) + Figure.LengthSide(point4, point1);
            Console.WriteLine($"Периметр четырёхугольника равен {perimeterCalculator}");
        }

        public void PerimeterCalculator(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            double perimeterCalculator = Figure.LengthSide(point1, point2) + Figure.LengthSide(point2, point3) + Figure.LengthSide(point3, point4) + Figure.LengthSide(point4, point5) + Figure.LengthSide(point5, point1);
            Console.WriteLine($"Периметр пятиугольника равен {perimeterCalculator}");
        }
    }
}
