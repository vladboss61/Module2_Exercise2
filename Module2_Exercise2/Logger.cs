using System;
using System.Linq;
using System.Text;

namespace Module2_Exercise2;

enum LogType
{
    Error,
    Info,
    Warning,
}



public class Order
{
    private ShoppingCard _shoppingCard;

    public Order(ShoppingCard shoppingCard)
    {
        _shoppingCard = shoppingCard;
    }

    public void Notify()
    {

    }
}


public class ShoppingCard
{
    public int Count = 10;
    private Product[] _products;

    public ShoppingCard()
    {
        _products = new Product[0];
    }

    public void AddProduct(Product product)
    {
        if (_products.Length == Count)
        {
            return;
        }

        if (_products.Length == 0)
        {
            _products = new Product[1];
            _products[0] = product;
        }

        var copy = new Product[_products.Length + 1];

        for (int i = 0; i < _products.Length; i++)
        {
            copy[i] = _products[i];
        }

        copy[_products.Length - 1] = product;
    }

    public Product[] GetProducts()
    {
        return _products;
    }
}


public class Product
{
    public string Name { get; set; }

    public string Description { get; set; }
}

public class OrderedProduct : Product
{
    public int Id { get; set; }
}




internal class Logger
{
    private static Logger _logger;

    private StringBuilder _result;

    static Logger()
    {
        _logger = new Logger();
    }

    private Logger()
    {
        _result = new StringBuilder();
    }

    public static Logger Instance
    {
        get
        {
            return _logger;
        }
    }

    public void Log(LogType logType, string message)
    {
        _result.AppendLine($"{DateTime.Now} {logType} {message}.");
    }

    public void LogError(string message)
    {
        Log(LogType.Error, message);
        //_result.AppendLine($"{DateTime.Now} {LogType.Error} {message}.");
    }

    public string GetMessage()
    {
        return _result.ToString();
    }
}
