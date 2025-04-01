using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address(456, "Craft Lane", "Boston", "MA", "USA");
        Customer customer1 = new Customer("Alice Smith", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Sewing Machine", 201, 350, 1));
        order1.AddProduct(new Product("Fabric Scissors", 202, 20, 1));
        order1.AddProduct(new Product("Thread Packk", 203, 15, 3));
        
    
        Address address2 = new Address(101, "High Street", "London", "", "UK");
        Customer customer2 = new Customer("Jane Brown", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Embroidery Kit", 301, 50, 1));
        order2.AddProduct(new Product("Fabric Marker Set", 302, 25, 2));

        Console.WriteLine("Order 1");
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine();
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine($"Total Price: ${order1.TotalPrice()}");
        Console.WriteLine();

        Console.WriteLine("Order 2");
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine();
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine($"Total Price: ${order2.TotalPrice()}");
        Console.WriteLine();
    }
}