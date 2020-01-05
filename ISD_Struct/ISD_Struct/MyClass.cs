using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Struct
{//Задание 3
 //Создайте класс MyClass и структуру MyStruct, которые содержат в себе поля public string change.
 //В классе Program создайте два метода:
 //- static void ClassTaker(MyClass myClass), который присваивает полю change экземпляра myClass
 //значение «изменено».
 //- static void StruktTaker(MyStruct myStruct), который присваивает полю change экземпляра myStruct
 //значение «изменено».
 //Продемонстрируйте разницу в использовании классов и структур, создав в методе Main() экземпляры
 //структуры и класса.Измените, значения полей экземпляров на «не изменено», а затем вызовите методы
 //ClassTaker и StruktTaker.Выведите на экран значения полей экземпляров. Проанализируйте полученные
 //результаты.
    class MyClass
    {
        public string change = "не изменено"; // в отличие от структуры можно инициализировать поля структуры напрямую при их объявлении
    }
}
