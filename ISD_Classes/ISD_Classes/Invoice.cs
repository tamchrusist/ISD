using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Classes
{   //Задание 8
    //Требуется:
    //Создать класс Invoice.
    //В теле класса создать три поля int account, string customer, string provider которые должны быть
    //проинициализированы один раз (при создании экземпляра данного класса) без возможности их дальнейшего
    //изменения.
    //В теле класса создать два закрытых поля string article, int quantity
    //Создать метод расчета стоимости заказа стоимости заказа с НДС и без НДС.
    //Написать программу, которая выводит на экран сумму оплаты заказанного товара с НДС или без НДС.
    class Invoice
    {
        private int account;
        private string customer;
        private string provider;

        private string article;
        private int quantity;

        private static Invoice instance;

        public int Account { get; private set; }
        public string Customer { get; private set; }
        public string Provider { get; private set; }
        public int Article { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        protected Invoice(int account, string customer, string provider) 
        {
            this.Account = account;
            this.Customer = customer;
            this.Provider = provider;
        }

        public static Invoice getInstance(int account, string customer, string provider)
        {
            if (instance == null)
                instance = new Invoice (account, customer, provider);
            return instance;
        }

        public double getPrice(int article, int quantity)
        {
            switch (article)
            {
                case 1:                    
                    Price = 3000 * quantity;
                    break;
                case 2:
                    Price = 5000 * quantity;
                    break;                  
                case 3:
                    Price = 1000 * quantity;
                    break;
                case 4:
                    Price = 8500 * quantity;
                    break;
                case 5:
                    Price = 14600 * quantity;
                    break;
                default:
                    Console.WriteLine("Такого товара нет на складе");
                    break;
            }
            return Price;
        }
    }
}
