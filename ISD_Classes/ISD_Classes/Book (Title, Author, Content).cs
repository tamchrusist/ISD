using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Classes
{
    //Задание 3
    //Требуется:
    //Создать класс Book.Создать классы Title, Author и Content, каждый из которых должен содержать одно
    //строковое поле и метод void Show().
    //Реализуйте возможность добавления в книгу названия книги, имени автора и содержания.
    //Выведите на экран разными цветами при помощи метода Show() название книги, имя автора и содержание.
    class Book
    {
        public Title title;
        public Author author;
        public Content content;

        public Book (Title title, Author author, Content content)
        {
            this.content = content;
            this.author = author;
            this.title = title;
        }
        public void Show()
        {
            title.Show();
            author.Show();
            content.Show();           
        }

    }

    class Title
    {
        private string title;
        public Title (string title)
            {
                this.title = title;
            }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Название книги: {title}");
        }
    }

    class Author
    {
        private string author;
        public Author(string author)
        {
            this.author = author;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Автор книги: {author}");
        }
    }

    class Content
    {
        private string content;
        public Content (string content)
        {
            this.content = content;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Содержание книги: {content}");
        }
    }
}
