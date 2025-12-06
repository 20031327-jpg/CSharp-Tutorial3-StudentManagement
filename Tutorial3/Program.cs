using System;
using System.Collections.Generic;

// Product class
public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public double Price { get; set; }

    // Constructor
    public Product(int productId, string productName, double price)
    {
        ProductId = productId;
        ProductName = productName;
        Price = price;
    }

    // Override ToString for clean display
    public override string ToString()
    {
        return $"Product ID: {ProductId}, Name: {ProductName}, Price: ${Price:F2}";
    }
}

// Customer class - now with a list of products
public class Customer
{
    private int _id;
    private string _name;
    private string _email;

    // List to hold multiple products for this customer
    public List<Product> Products { get; set; }

    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Email
    {
        get { return _email; }
        set { _email = value; }
    }

    // Constructor
    public Customer(int id, string name, string email)
    {
        _id = id;
        _name = name;
        _email = email;
        Products = new List<Product>(); // Initialize the list
    }

    // Method to add a product to the customer's list
    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    // Override ToString to show customer and their products
    public override string ToString()
    {
        string result = $"ID: {Id}, Name: {Name}, Email: {Email}\nProducts:\n";
        if (Products.Count == 0)
        {
            result += "  No products yet.";
        }
        else
        {
            foreach (var product in Products)
            {
                result += "  - " + product + "\n";
            }
        }
        return result.Trim();
    }
}

// Main Program class
class Program
{
    static void Main(string[] args)
    {
        // Create some products
        Product p1 = new Product(1001, "Laptop", 999.99);
        Product p2 = new Product(1002, "Mouse", 25.50);
        Product p3 = new Product(1003, "Keyboard", 75.00);
        Product p4 = new Product(1004, "Monitor", 299.99);

        // Create two customers
        Customer Cust1 = new Customer(101, "Dipesh Khatri", "dipesh@gmail.com");
        Customer Cust2 = new Customer(102, "Ramesh Gautam", "ramesh@gmail.com");

        // Add products to customers
        Cust1.AddProduct(p1);
        Cust1.AddProduct(p2);
        Cust1.AddProduct(p3);

        Cust2.AddProduct(p4);
        Cust2.AddProduct(p2);

        // Display customer details with their products
        Console.WriteLine("=== Customer Details with Products ===\n");

        Console.WriteLine("Customer 1:");
        Console.WriteLine(Cust1);

        Console.WriteLine("\nCustomer 2:");
        Console.WriteLine(Cust2);

        Console.ReadKey();
    }
}