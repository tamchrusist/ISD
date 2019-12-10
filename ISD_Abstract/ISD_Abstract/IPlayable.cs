using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Abstract
{//Задание 2
 //Создайте 2 интерфейса IPlayable и IRecodable. В каждом из
 //интерфейсов создайте по 3 метода void Play() / void Pause() / void
 //Stop() и void Record() / void Pause() / void Stop() соответственно.
 //Создайте производный класс Player от базовых интерфейсов
 //IPlayable и IRecodable.
 //Написать программу, которая выполняет проигрывание и запись.
    public interface IPlayable
    {
        void Play();
        void PausePlay();
        void StopPlay();
    }
}
