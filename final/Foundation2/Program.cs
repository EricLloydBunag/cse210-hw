using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order(new Customer("John Doe", "123 Main St", "Anytown", "California", "USA"), 
        new List<Product>
        {
            new Product("Laptop", 101, 999.99f, 1),
            new Product("Mouse", 102, 19.99f, 2),
            new Product("Keyboard", 103, 49.99f, 1)
        });

        Order order2 = new Order(new Customer("Jane Smith", "456 Oak St", "Othertown", "Texas", "USA"), 
        new List<Product>
        {
            new Product("Chair", 201, 149.99f, 1),
            new Product("Desk", 202, 299.99f, 1),
            new Product("Mouse Pad", 203, 9.99f, 3)
        });

        Order order3 = new Order(new Customer("Alice Johnson", "12 Baker St", "London", "England", "United Kingdom"), 
        new List<Product>
        {
            new Product("Monitor", 301, 199.99f, 1),
            new Product("Desk Lamp", 302, 29.99f, 2)
        });

        List<Order> orders = new List<Order>(){order1, order2, order3};

        foreach(Order order in orders){
        order.DisplayShippingLabel();
        order.DisplayPackingLabel();
        Console.WriteLine($"Total - {order.GetTotalOrderCost()}");
        Console.WriteLine();
        }
    }
            
}