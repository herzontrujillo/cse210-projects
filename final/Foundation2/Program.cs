using System.Collections.Generic;
using System;
using System.IO;
using System.ComponentModel;


class Program
{
    static void Main(string[] args)
    {

        List<Order> _orders = new List<Order>();      
        List<Product> products = new List<Product>(); 
        Product p01 = new Product("Nestle Pure Water", "2503558", 1, 3.00);
        Product p02 = new Product("Milk","546513", 2, 4.25 );
        Product p03 = new Product("Grapes","86546", 2, 2.50);
        products.Add(p01);
        products.Add(p02);
        products.Add(p03);
        //New Customer Information
        Address address = new Address("3540 Brady ct", "Arlington", "TX", "USA");
        Customer customer1 = new Customer("Rafael Reyes", address);
        Order order1 = new Order(products, customer1);
        _orders.Add(order1);

        Console.WriteLine();
        Console.WriteLine($"Here is what you've ordered <> {customer1.GetName}");
        order1.Display();
        Console.WriteLine();
        


        // Customer order #2
        products = new List<Product>();
        Product p04 = new Product("set of pens","a556", 2, 4.80);
        Product p05 = new Product("Post-it tags", "p545656", 1, 3.25);
        Product p06 = new Product("Epson Ink", "es250", 1, 55.00);
        products.Add(p04);
        products.Add(p05);
        products.Add(p06);
        //New Customer Information
        Address address2 = new Address("845 FortWorth Av.", "Plano", "OK", "USA" );
        Customer customer2 = new Customer("Montty Jackson", address2 );
        Order order2 = new Order(products, customer2);
        _orders.Add(order2);

        Console.WriteLine();
        Console.WriteLine($"Here is what you've ordered");
        order2.Display();
        Console.WriteLine();



        // Customer order #3
        List<Product> list = new List<Product>();
        Product p07 = new Product("Polo Jeans", "j6545", 1, 105.00);
        Product p08 = new Product("Polo Shirt", "S5633", 2, 36.00);
        //New Customer Information
        Address address3 = new Address("Calle al Sur #3", "Monterrey", "Monterrey", "MExico");
        Customer customer3 = new Customer("Carlos Martinez", address3);
        list.Add(p07);
        list.Add(p08);
        Order order3 = new Order(list, customer3);   
        _orders.Add(order3);

        Console.WriteLine();
        Console.WriteLine($"Here is what you've ordered");
        order3.Display();
        Console.WriteLine();

        
        
          
    }
    
}
