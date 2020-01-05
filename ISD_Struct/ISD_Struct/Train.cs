using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Struct
{ 
//Задание 2
//Требуется: Описать структуру с именем Train, содержащую следующие поля: название пункта назначения,
//номер поезда, время отправления.
//Написать программу, выполняющую следующие действия:
//- ввод с клавиатуры данных в массив, состоящий из восьми элементов типа Train(записи должны быть
//упорядочены по номерам поездов);
//- вывод на экран информации о поезде, номер которого введен с клавиатуры(если таких поездов нет, вывести
//соответствующее сообщение).

    struct Train
    {
        public string destination;
        public int numberTrain;
        public DateTime time;
        public Train(string destination, int numberTrain, DateTime time)
        {
            this.destination = destination;
            this.numberTrain = numberTrain;
            this.time = time;
        }
        public void DisplayInfo()
        {          
            Console.WriteLine($"Номер поезда: {numberTrain};  \nПункт назначения: {destination};  \nВремя прибытия: {time}");
        }
    }
}
