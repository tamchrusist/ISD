using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Abstract
{
 //        Задание 1
 //Создайте класс AbstractHandler.
 //В теле класса создать методы void Open(), void Create(), void Chenge(),
 //void Save().
 //Создать производные классы XMLHandler, TXTHandler, DOCHandler от
 //базового класса AbstractHandler.
 //Написать программу, которая будет выполнять определение
 //документа и для каждого формата должны быть методы открытия,
 //создания, редактирования, сохранения определенного формата
 //документа.

    public abstract class AbstractHandler
    {
        public abstract void Open();
        public abstract void Create();
        public abstract void Change();
        public abstract void Save();
    }

    public class XMLHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("Редактировать XML-файл");
        }

        public override void Create()
        {
            Console.WriteLine("Создать XML-файл");
        }

        public override void Open()
        {
            Console.WriteLine("Открыть XML-файл");
        }

        public override void Save()
        {
            Console.WriteLine("Сохранить XML-файл");
        }
    }

    public class TXTHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("Редактировать TXT-файл");
        }

        public override void Create()
        {
            Console.WriteLine("Создать TXT-файл");
        }

        public override void Open()
        {
            Console.WriteLine("Открыть TXT-файл");
        }

        public override void Save()
        {
            Console.WriteLine("Сохранить TXT-файл");
        }
    }

    public class DOCHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("Редактировать DOC-файл");
        }

        public override void Create()
        {
            Console.WriteLine("Создать DOC-файл");
        }

        public override void Open()
        {
            Console.WriteLine("Открыть DOC-файл");
        }

        public override void Save()
        {
            Console.WriteLine("Сохранить DOC-файл");
        }
    }
}
