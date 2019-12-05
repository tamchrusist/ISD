using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Classes
{   
    //Задание 6
    //Требуется:
    //Создать класс Converter.
    //В теле класса создать пользовательский конструктор, который принимает три вещественных аргумента, и
    //инициализирует поля соответствующие курсу 3-х основных валют, по отношению к гривне - public
    //Converter(double usd, double eur, double rub).
    //Написать программу, которая будет выполнять конвертацию из гривны в одну из указанных валют, также
    //программа должна производить конвертацию из указанных валют в гривну.
    class Converter
    {
        public double UahUsd { set; get; }
        public double UahEur { set; get; }
        public double UahRub { set; get; }

        public Converter(double usd, double eur, double rub)
        {
            UahUsd =  usd * 24.03;
            UahEur =  eur * 26.5;
            UahRub =  rub * 0.37;
        }

        public Converter(double uah)
        {
            UahUsd = uah / 24.03;
            UahEur = uah / 26.5;
            UahRub = uah / 0.37;
        }
    }
}
