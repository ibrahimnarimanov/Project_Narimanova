using System;

namespace Core
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Code { get; set; }

        public Product(string name, double price, int code)
        {
            Name = name;
            Price = price;
            Code = code;
        }

        public string GetInfo()
        {
            return $"[Товар] Код: {Code}, Назва: {Name}, Ціна: {Price} грн.";
        }
    }
}