using System;

namespace Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 2
            System.Console.WriteLine("Введите длины сторон вашего прямоугольника :");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Rectangle rect = new Rectangle(a, b);
            System.Console.WriteLine($"Площадь вашего прямоугольника : {rect.Area}\nПериметр вашего прямоугольника : {rect.Perimeter}\n");

            //Задача 3
            //Реализация №1
            Book book1 = new Book("Clr via C#", "Рихтер Дж.", "Сделаем вид что тут контент на 896 страниц");
            book1.Show();
            System.Console.WriteLine();
            //Реализация №2
            Book book2 = new Book();
            book2.AddAllInfo(new Title("Некий заголовок"), new Author("От некого автора"), new Content("С неким контентом"));
            book2.title.Show();
            book2.author.Show();
            book2.content.Show();
            Console.ResetColor();
        }
    }
    class Rectangle
    {
        public Rectangle(double a, double b) { side1 = a; side2 = b; }
        private readonly double side1, side2;
        public Double Area { get => AreaCalculator(); }
        public Double Perimeter { get => PerimeterCalculator(); }
        public double AreaCalculator() => side1 * side2;
        public double PerimeterCalculator() => (side1 + side2) * 2;
    }
    class Title
    {
        private readonly string title;
        public Title(string title) => this.title = title;
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine($"Заголовок : {title}");
        }
    }
    class Author
    {
        private readonly string author;
        public Author(string author) => this.author = author;
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine($"Автор : {author}");
        }
    }
    class Content
    {
        private readonly string content;
        public Content(string content) => this.content = content;
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.WriteLine($"Контент : {content}");
        }
    }
    class Book
    {
        public Title title { get; private set; }
        public Author author { get; private set; }
        public Content content { get; private set; }
        public Book(string title, string author, string content)
        {
            this.title = new Title(title);
            this.author = new Author(author);
            this.content = new Content(content);
        }
        public Book() { }
        public void AddAllInfo(Title title, Author author, Content content)
        {
            this.title = title;
            this.author = author;
            this.content = content;
        }
        public void Show()
        {
            title.Show();
            author.Show();
            content.Show();
        }
    }
}
