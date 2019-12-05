using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Inheritance
{//Задание 2
 //Создать класс, представляющий учебный класс ClassRoom.
 //Создайте класс ученик Pupil. В теле класса создайте методы void Study(), void Read(), void Write(), void
 //Relax().
 //Создайте 3 производных класса ExcelentPupil, GoodPupil, BadPupil от класса базового класса Pupil и
 //переопределите каждый из методов, в зависимости от успеваемости ученика.
 //Конструктор класса ClassRoom принимает аргументы типа Pupil, класс должен состоять из 4 учеников.
 //Предусмотрите возможность того, что пользователь может передать 2 или 3 аргумента.
 //Выведите информацию о том, как все ученики экземпляра класса ClassRoom умеют учиться, читать, писать,
 //отдыхать.

    class ClassRoom
    {
        public ClassRoom(Pupil pupil1, Pupil pupil2)
        {
            ClassRoom.StudyInClassRoom(pupil1, pupil2);
        }
        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            ClassRoom.StudyInClassRoom(pupil1, pupil2, pupil3);
        }
        public ClassRoom (Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
        {
            ClassRoom.StudyInClassRoom(pupil1, pupil2, pupil3, pupil4);  
        }

        public static void StudyInClassRoom(Pupil pupil1, Pupil pupil2)
        {
            pupil1 = new ExcelentPupil();
            pupil2 = new GoodPupil();
            
            Console.WriteLine("\nПервый ученик: ");
            pupil1.Study();
            pupil1.Read();
            pupil1.Write();
            pupil1.Relax();
            Console.WriteLine("\nВторой ученик: ");
            pupil2.Study();
            pupil2.Read();
            pupil2.Write();
            pupil2.Relax();
           
        }
        public static void StudyInClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            pupil1 = new ExcelentPupil();
            pupil2 = new GoodPupil();
            pupil3 = new BadPupil();
            

            Console.WriteLine("\nПервый ученик: ");
            pupil1.Study();
            pupil1.Read();
            pupil1.Write();
            pupil1.Relax();
            Console.WriteLine("\nВторой ученик: ");
            pupil2.Study();
            pupil2.Read();
            pupil2.Write();
            pupil2.Relax();
            Console.WriteLine("\nТретий ученик: ");
            pupil3.Study();
            pupil3.Read();
            pupil3.Write();
            pupil3.Relax();          
        }
        public static void StudyInClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
        {
            pupil1 = new ExcelentPupil();
            pupil2 = new GoodPupil();
            pupil3 = new GoodPupil();
            pupil4 = new BadPupil();

            Console.WriteLine("\nПервый ученик: ");
            pupil1.Study();
            pupil1.Read();
            pupil1.Write();
            pupil1.Relax();
            Console.WriteLine("\nВторой ученик: ");
            pupil2.Study();
            pupil2.Read();
            pupil2.Write();
            pupil2.Relax();
            Console.WriteLine("\nТретий ученик: ");
            pupil3.Study();
            pupil3.Read();
            pupil3.Write();
            pupil3.Relax();
            Console.WriteLine("\nЧетвёртый ученик: ");
            pupil4.Study();
            pupil4.Read();
            pupil4.Write();
            pupil4.Relax();
        }

    }

    public abstract class Pupil
    {
           public virtual void Study()
        {
            
        }
            public virtual void Read()
        {
            
        }
            public virtual void Write()
        {
            
        }
            public virtual void Relax()
        {
            
        }
    }

    class ExcelentPupil : Pupil
    {
        public override void Study()
        {       
            Console.WriteLine("Учится блестяще");
        }
        public override void Read()
        {
            
            Console.WriteLine("Читает лучше всех в классе!");
        }
        public override void Write()
        {         
            Console.WriteLine("Пишет очень красиво");
        }
        public override void Relax()
        {         
            Console.WriteLine("Отдыхает мало, но активно и разнообразно");
        }

    }

    class GoodPupil : Pupil
    {
        public override void Study()
        {          
            Console.WriteLine("Учится хорошо");
        }
        public override void Read()
        {
            Console.WriteLine("Читает с выражением");
        }
        public override void Write()
        {
            Console.WriteLine("Пишет хорошо, но нужно больше практики");
        }
        public override void Relax()
        {
            Console.WriteLine("Любит отдыхать за художественной книгой");
        }
    }

    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Учится ужасно");
        }
        public override void Read()
        {
            Console.WriteLine("Плохо читает и мало");
        }
        public override void Write()
        {
            Console.WriteLine("Пишет коряво, очень много ошибок");
        }
        public override void Relax()
        {
            Console.WriteLine("Рубится в игры на телефоне");
        }

    }
}
