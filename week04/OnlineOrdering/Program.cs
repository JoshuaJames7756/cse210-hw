using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1: USA Customer
        Address address1 = new Address("123 Main St", "Springfield", "OR", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Wireless Mouse", "P101", 25.50, 2));
        order1.AddProduct(new Product("Mechanical Keyboard", "P102", 75.00, 1));

        // Order 2: International Customer
        Address address2 = new Address("Av. Heroínas 456", "Cochabamba", "Cochabamba", "Bolivia");
        Customer customer2 = new Customer("Maria Gutierrez", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("USB-C Hub", "P201", 15.00, 3));
        order2.AddProduct(new Product("HD Monitor", "P202", 150.00, 1));
        order2.AddProduct(new Product("HDMI Cable", "P203", 8.50, 2));

        // Display results for Order 1
        Console.WriteLine("========================================");
        Console.WriteLine("ORDER 1 DETAILS");
        Console.WriteLine("========================================");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalCost():F2}\n");

        // Display results for Order 2
        Console.WriteLine("========================================");
        Console.WriteLine("ORDER 2 DETAILS");
        Console.WriteLine("========================================");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalCost():F2}\n");
    }
}