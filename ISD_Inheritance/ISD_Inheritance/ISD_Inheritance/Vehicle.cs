using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Inheritance
{//Задание 3
 //Создать класс Vehicle.
 //В теле класса создайте поля: координаты и параметры средств передвижения (цена, скорость, год выпуска).
 //Создайте 3 производных класса Plane, Саг и Ship.
 //Для класса Plane должна быть определена высота и количество пассажиров.
 //Для класса Ship — количество пассажиров и порт приписки.
 //Написать программу, которая выводит на экран информацию о каждом средстве передвижения.
    class Vehicle
    {
        public double Price { get; set; }
        public double Speed { get; set; }
        public int Year { get; set; }
    }

    class Plane : Vehicle
    {
        public double Height { get; set; }
        public double Passengers { get; set; }
    }
    class Car : Vehicle
    {


    }
    class Ship : Vehicle
    {
        public double Passengers { get; set; }
        public string Port { get; set; }

    }
}