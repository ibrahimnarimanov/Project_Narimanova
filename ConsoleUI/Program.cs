using System;
using Core;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Загальне завдання №6: Вивід версії ОС та використання ОЗУ
            Console.WriteLine("=== Системна інформація ===");
            Console.WriteLine($"Поточна версія ОС: {Environment.OSVersion}");

            long memoryUsed = GC.GetTotalMemory(false);
            double memoryInMb = memoryUsed / (1024.0 * 1024.0);
            Console.WriteLine($"Обсяг оперативної пам'яті програми: {memoryInMb:F2} MB");
            Console.WriteLine("===========================\n");

            // Індивідуальне завдання №4: Створення екземплярів та вивід
            Console.WriteLine("=== Дані індивідуального проекту (Онлайн-магазин) ===");

            // Ініціалізація тестовими даними
            Category category = new Category(1, "Електроніка", true);
            Product product = new Product("Ігровий ноутбук", 45000.00, 10293);
            ShoppingCart cart = new ShoppingCart(777, 45000.00, DateTime.Now);

            // Вивід опису об'єктів у консоль
            Console.WriteLine(category.GetInfo());
            Console.WriteLine(product.GetInfo());
            Console.WriteLine(cart.GetInfo());

            Console.WriteLine("===========================");
            Console.ReadLine();
        }
    }
}