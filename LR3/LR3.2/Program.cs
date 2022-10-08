using System;
class Book
{
    public static void Show()
    {
        Title.Show();
        Author.Show();
        Content.Show();
    }
    public static class Title
    {
        public static string title;
        public static void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Title: " + title);
        }
    }
    public static class Author
    {
        public static string author;
        public static void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Author: " + author);
        }
    }
    public static class Content
    {
        public static string content;
        public static void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Content: " + content);
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Enter book name: ");
        Book.Title.title = Console.ReadLine();
        Console.WriteLine("Enter book's author: ");
        Book.Author.author = Console.ReadLine();
        Console.WriteLine("Enter content: ");
        Book.Content.content = Console.ReadLine();
        Book.Show();
    }
}