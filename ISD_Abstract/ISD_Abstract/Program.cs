using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Abstract
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Задание №1. Класс AbstractHandler\n");
            Console.ForegroundColor = ConsoleColor.White;

            XMLHandler xml = new XMLHandler();
            TXTHandler txt = new TXTHandler();
            DOCHandler doc = new DOCHandler();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nXML-файл:\n");
            Console.ResetColor();
            xml.Open();
            xml.Change();
            xml.Create();
            xml.Save();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nTXT-файл:\n");
            Console.ResetColor();
            txt.Open();
            txt.Change();
            txt.Create();
            txt.Save();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nDOC-файл:\n");
            Console.ResetColor();
            doc.Open();
            doc.Change();
            doc.Create();
            doc.Save();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nЗадание №2. Класс Player\n");
            Console.ForegroundColor = ConsoleColor.White;

            Player player = new Player();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Проигрывание трека:\n");
            Console.ResetColor();
            player.Play();
            player.PausePlay();
            player.StopPlay();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nЗапись трека:\n");
            Console.ResetColor();
            player.Record();
            player.PauseRecord();
            player.StopRecord();

            Console.ReadLine();
        }
    }
}
