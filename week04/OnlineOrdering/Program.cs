using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        // Product data
        string[] productNames =
        {
            "Laptop", "Mouse", "Keyboard", "Monitor", "Phone",
            "Tablet", "Headphones", "Speaker", "Camera", "Microphone",
            "Printer", "Charger", "USB Cable", "Desk Lamp", "Router",
            "Smart Watch", "SSD Drive", "Graphics Card", "Webcam", "Power Bank"
        };

        // USA Customer
        Address address1 = new Address(
            "123 Main Street",
            "Phoenix",
            "Arizona",
            "USA"
        );

        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);

        // International Customer
        Address address2 = new Address(
            "55 Queen Road",
            "London",
            "England",
            "UK"
        );

        Customer customer2 = new Customer("Emma Brown", address2);

        Order order2 = new Order(customer2);

        // Add RANDOM products to Order 1
        for (int i = 0; i < 3; i++)
        {
            string name = productNames[random.Next(productNames.Length)];

            string productId = $"P{random.Next(1000, 9999)}";

            double price = random.Next(10, 1000);

            int quantity = random.Next(1, 5);

            Product product = new Product(
                name,
                productId,
                price,
                quantity
            );

            order1.AddProduct(product);
        }

        // Add RANDOM products to Order 2
        for (int i = 0; i < 3; i++)
        {
            string name = productNames[random.Next(productNames.Length)];

            string productId = $"P{random.Next(1000, 9999)}";

            double price = random.Next(10, 1000);

            int quantity = random.Next(1, 5);

            Product product = new Product(
                name,
                productId,
                price,
                quantity
            );

            order2.AddProduct(product);
        }

        // Display Order 1
        Console.WriteLine("ORDER 1");
        Console.WriteLine("-------------------");

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine(
            $"Total Cost: ${order1.CalculateTotalCost()}"
        );

        Console.WriteLine();

        // Display Order 2
        Console.WriteLine("ORDER 2");
        Console.WriteLine("-------------------");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine(
            $"Total Cost: ${order2.CalculateTotalCost()}"
        );
    }
}