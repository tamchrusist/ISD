using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Struct
{  //{Задание 1
   //Создайте структуру с именем - Notebook.
   //Поля структуры: модель, производитель, цена.
   //В структуре должен быть реализован конструктор для инициализации полей и метод для вывода содержимого
   //полей на экран
    struct Notebook
    {
        public string model;
        public string manufacturer;
        public double price;
        public Notebook (string model, string manufacturer, double price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
        }
        public void DisplayInfo()
        {
            Console.WriteLine ($"Модель: {model};  \nПроизводитель: {manufacturer};  \nЦена: {price} грн.");
        }
    }
}
