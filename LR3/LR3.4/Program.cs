using System;

class Invoice
{
    int account;
    string customer;
    string provider;
    private static string article;
    private static int quantity;
    public static double cost;
    public static double price;
    public Invoice(int account, string customer, string provider)
    {
        this.account = account;
        this.customer = customer;
        this.provider = provider;
    }
    public Invoice(string article, int quantity, double price)
    {
        Invoice.article = article;
        Invoice.quantity = quantity;
        Invoice.price = price;
        Invoice.WithHDC();
        Invoice.NoHDC();
    }
    public static void WithHDC()
    {
        cost = quantity * price * 0.8;
        Console.WriteLine("Сума платежу з ПДВ товару: " + cost);
    }
    public static void NoHDC()
    {
        cost = quantity * price;
        Console.WriteLine("Сума платежу без ПДВ товару: " + cost);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Product name: ");
        string article = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Кількість: ");
        int quantity = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ціна: ");
        double price = Convert.ToDouble(Console.ReadLine());
        Invoice Person = new Invoice(343434, "Олексiй", "Кривошеенко");
        Invoice Item = new Invoice(article, quantity, price);
    }
}