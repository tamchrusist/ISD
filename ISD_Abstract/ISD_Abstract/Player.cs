using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Abstract
{
    class Player : IPlayable, IRecodable
    {
        public void PausePlay()
        {
            Console.WriteLine("Пауза проигрывания трека");
        }

        public void PauseRecord()
        {
            Console.WriteLine("Пауза записи трека");
        }

        public void Play()
        {
            Console.WriteLine("Проигрывание трека");
        }

        public void Record()
        {
            Console.WriteLine("Запись трека");
        }

        public void StopPlay()
        {
            Console.WriteLine("Остановка проигрывания трека");
        }

        public void StopRecord()
        {
            Console.WriteLine("Остановка записи трека");
        }
    }
}

