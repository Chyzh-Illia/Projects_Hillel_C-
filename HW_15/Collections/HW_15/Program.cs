using System;
using System.Collections.Generic;
using System.Linq;

namespace GroceryStore
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name} (ID: {Id}, Price: {Price:C})";
        }
    }

    public class Store
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void RemoveProduct(int productId)
        {
            products.RemoveAll(p => p.Id == productId);
        }

        public Product GetProductById(int productId)
        {
            return products.FirstOrDefault(p => p.Id == productId);
        }

        public List<Product> GetAvailableProducts()
        {
            return products;
        }
    }

    public class Cart
    {
        private List<Product> items = new List<Product>();

        public void AddToCart(Product product)
        {
            items.Add(product);
        }

        public void RemoveFromCart(int productId)
        {
            items.RemoveAll(p => p.Id == productId);
        }

        public decimal CalculateTotalPrice()
        {
            return items.Sum(p => p.Price);
        }

        public List<Product> GetCartItems()
        {
            return items;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Store store = new Store();
            Cart cart = new Cart();

            store.AddProduct(new Product(1, "Apple", 0.50m));
            store.AddProduct(new Product(2, "Banana", 0.30m));
            store.AddProduct(new Product(3, "Milk", 1.20m));
            store.AddProduct(new Product(4, "Bread", 1.00m));

            Console.WriteLine("Available products in the store:");
            foreach (var product in store.GetAvailableProducts())
            {
                Console.WriteLine(product);
            }

            cart.AddToCart(store.GetProductById(1));
            cart.AddToCart(store.GetProductById(3));

            Console.WriteLine("\nProducts in the cart:");
            foreach (var item in cart.GetCartItems())
            {
                Console.WriteLine(item);
            }

            cart.RemoveFromCart(1);

            Console.WriteLine("\nProducts in the cart after removing Apple:");
            foreach (var item in cart.GetCartItems())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"\nTotal price of products in the cart: {cart.CalculateTotalPrice():C}");
        }
    }
}