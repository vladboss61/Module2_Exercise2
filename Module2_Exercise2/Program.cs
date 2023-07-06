using System;
using System.IO;

namespace Module2_Exercise2;

internal class Program
{
    static void Main(string[] args)
    {
        // 30
        var products = new Product[]
        {
            new Product { Name = "Iphone 0" },
            new Product { Name = "Iphone 1" },
            new Product { Name = "Iphone 2" },
            new Product { Name = "Iphone 3" }
        };

        var card = new ShoppingCard();

        card.AddProduct(new Product { Name = "Iphone" });
        card.AddProduct(new Product { Name = "Audi" });



        Logger.Instance.Log(LogType.Info, "Hello Info");
        Logger.Instance.Log(LogType.Warning, "Hello Warning");
        Logger.Instance.Log(LogType.Error, "Hello Error");

        var instance1 = Logger.Instance;
        var instance2 = Logger.Instance;

        if (instance1 == instance2)
        {
            Console.WriteLine("The Same");
        }

        Console.WriteLine(Logger.Instance.GetMessage());
        File.WriteAllText("log.txt", Logger.Instance.GetMessage());

        Console.WriteLine("Hello, World!");
    }
}
