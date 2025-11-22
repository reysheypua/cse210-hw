using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        List<Order> orders = new List<Order>();

        Address address1 = new Address("1428 Elm Street", "San Junipero", "CA", "USA");
        Customer customer1 = new Customer("Holly Golightly", address1);

        List<Product> products1 = new List<Product>
        {
            new Product("Bluetooth Speaker", "BS-8821", 45.99, 1),
            new Product("USB-C Cable (Pack)", "UC-2003", 12.50, 3),
            new Product("Phone Case", "PC-1140", 9.99, 1)
        };

        orders.Add(new Order(products1, customer1));


        Address address2 = new Address("5-17-3 Shinjuku", "Tokyo", "Tokyo Prefecture", "Japan");
        Customer customer2 = new Customer("Hiroshi Tanaka", address2);

        List<Product> products2 = new List<Product>
        {
            new Product("Wireless Keyboard", "WK-5900", 39.50, 1),
            new Product("Laptop Stand", "LS-7742", 22.00, 2)
        };

        orders.Add(new Order(products2, customer2));

        int orderCount = 1;
        foreach (Order order in orders)
        {
            Customer customer = order.Customer;

            Console.WriteLine($"----------------ORDER {orderCount}----------------\n");
            
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Total Order Price: ${order.GetTotalCost():F2}");
            Console.WriteLine("\n\n\n");

            orderCount++;
        }
    }
}