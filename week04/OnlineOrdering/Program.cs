using System;

class Program
{
    static void Main(string[] args)
    {
        
        Address address1 = new Address(
            "123 Main Street",
            "Phoenix",
            "Arizona",
            "USA"
        );

        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Laptop", "A100", 800, 1));
        order1.AddProduct(new Product("Mouse", "B200", 25, 2));

        
        Address address2 = new Address(
            "55 Queen Road",
            "London",
            "England",
            "UK"
        );

        Customer customer2 = new Customer("Emma Brown", address2);

        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Phone", "C300", 600, 1));
        order2.AddProduct(new Product("Charger", "D400", 20, 3));

        // Display Order 1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}");

        Console.WriteLine();

        // Display Order 2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
    }
}