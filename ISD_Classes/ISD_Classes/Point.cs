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

    public class Point
    {
        private int pointX;
        private int pointY;
        private string name;

        public int PointX { get; }
        public int PointY { get; }
        public string Name { get; }

        public Point (int pointX, int pointY)
            {
                PointX = pointX;
                PointY = pointY;
            }
    }
}
