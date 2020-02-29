using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;



namespace ISD_Generics
{
    class Program
    {
        //Задание 1
        //Создайте класс MyClass<T>, содержащий статический фабричный метод - T FacrotyMethod(), который
        //будет порождать экземпляры типа, указанного в качестве параметра типа(указателя места заполнения типом –
        //Т).

        //Задание 2
        //Создайте класс MyList<T>.Реализуйте в простейшем приближении возможность использования его
        //экземпляра аналогично экземпляру класса List<T>.Минимально требуемый интерфейс взаимодействия с
        //экземпляром, должен включать метод добавления элемента, индексатор для получения значения элемента по
        //указанному индексу и свойство только для чтения для получения общего количества элементов.


        //Задание 3
        //Создайте класс MyDictionary<TKey, TValue>.Реализуйте в простейшем приближении возможность
        //использования его экземпляра Минимально требуемый интерфейс взаимодействия с экземпляром, должен
        //включать метод добавления пар элементов, индексатор для получения значения элемента по указанному
        //индексу и свойство только для чтения для получения общего количества пар элементов.
        //Задание 4
        //Создайте расширяющий метод: public static T[] GetArray<T>(this MyList<T> list)
        //Примените расширяющий метод к экземпляру типа MyList<T>, разработанному в домашнем задании 2 для
        //данного урока.Выведите на экран значения элементов массива, который вернул расширяющий метод
        //GetArray().
        //Задание 5
        //Создайте класс CarCollection<T>.Реализуйте в простейшем приближении возможность использования его
        //экземпляра для создания парка машин.Минимально требуемый интерфейс взаимодействия с экземпляром,
        //должен включать метод добавления машин с названием машины и года ее выпуска, индексатор для получения
        //значения элемента по указанному индексу и свойство только для чтения для получения общего количества
        //элементов.
        //Создайте метод удаления всех машин автопарка.
        //Задание 6
        //Создайте класс Dictionary<TKey, TValue>.Реализуйте в простейшем приближении возможность
        //использования его экземпляра аналогично экземпляру класса Dictionary из пространства имен
        //System.Collections.Generic.Минимально требуемый интерфейс взаимодействия с экземпляром, должен
        //включать метод добавления пар элементов, индексатор для получения значения элемента по указанному
        //индексу и свойство только для чтения для получения общего количества пар элементов.
        //Задание 7
        //Создайте класс ArrayList.Реализуйте в простейшем приближении возможность использования его
        //экземпляра аналогично экземпляру класса ArrayList из пространства имен System.Collections.


        //К заданию №7:
        public static void PrintValues(IEnumerable obj)
        {

            Console.WriteLine("Dinemic array");

            foreach (var item in obj)

                Console.Write("   {0}", item);
            Console.WriteLine();
        }
        //К заданию №5:
        static void Test<T>() where T : ICar, new()
        {
            var collection = new CarCollection<T>();
            collection.Add("Mersedes", 1999);
            collection.Add("BMW", 2005);
            collection.Add("Bugatti", 2020);
            
            Console.WriteLine("Test collection of type " + typeof(T).Name);
            Console.WriteLine("Total collection: {0}", collection.Count) ;
            for (int i = 0; i < collection.Count; i++)
            Console.WriteLine(collection[i]);
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Задание №1. MyClass<T>, содержащий статический фабричный метод - T FactoryMethod()\n");
            Console.ResetColor();

            var a = MyClass<bool>.FactoryMethod();
            var b = MyClass<decimal>.FactoryMethod();
            var c = MyClass<int>.FactoryMethod();
            var d = MyClass<float>.FactoryMethod();

            Console.WriteLine(a.GetType().Name);
            Console.WriteLine(b.GetType().Name);
            Console.WriteLine(c.GetType().Name);
            Console.WriteLine(d.GetType().Name);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nЗадание №2. MyList<T>\n");
            Console.ResetColor();

            MyList<int> mylist = new MyList<int>();
            
            Console.WriteLine("Емкость списка: {0} элемент(-ов)", mylist.Count);
            Console.WriteLine("Добавляем в список элементы 15, 14, 13:");
            mylist.Add(15);
            mylist.Add(14);
            mylist.Add(13);
            Console.WriteLine("Список фактически содержит: {0} элемент(-ов)", mylist.Count);
            Console.WriteLine("Элемент с индексом 1 (заданное значение - 14): {0}", mylist[1]);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nЗадание №3. MyDictionary<T>\n");
            Console.ResetColor();

            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();

            myDictionary.Add(0, "ноль");
            myDictionary.Add(1, "один");
            myDictionary.Add(2, "два");
            myDictionary.Add(3, "три");
            myDictionary.Add(4, "четыре");

            Console.WriteLine("Емкость элементов {0}", myDictionary.Counter);
            Console.WriteLine("Ключ элемента 3: {0}", myDictionary[3]);
            Console.WriteLine("Ключ элемента 4: {0}", myDictionary[4]);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nЗадание №5. CarCollection<T>\n");
            Console.ResetColor();

                Test<CarA>();
                Test<CarB>();
                Test<CarC>();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nЗадание №6. Dictionary<TKey, TValue> - дубль задания 3\n");
            Console.ResetColor();


            MyDictionary<int, string> myDictionary6 = new MyDictionary<int, string>();

            myDictionary6.Add(1, "одинарный");
            myDictionary6.Add(2, "двойной");
            myDictionary6.Add(3, "тройной");
            myDictionary6.Add(4, "четвертной");
            myDictionary6.Add(5, "пятерной");

            Console.WriteLine("Емкость элементов {0}", myDictionary6.Counter);
            Console.WriteLine("Ключ элемента 3: {0}", myDictionary6[3]);
            Console.WriteLine("Ключ элемента 4: {0}", myDictionary6[4]);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nЗадание №7. ArrayList\n");
            Console.ResetColor();

            int[] array = { 5, 10, 15, 20, 25 };

            ArrayList<int> dArr = new ArrayList<int>(array);

            Console.WriteLine("Значение 5 пренадлежит массиву: {0} ", dArr.Contains(5));

            Console.WriteLine("Индекс элемента 15: {0}", dArr.IndexOf(15));

            PrintValues(dArr);

            Console.WriteLine("Remove 15:");

            dArr.Remove(15);

            PrintValues(dArr);

            Console.ReadLine();
        }
    }
}
