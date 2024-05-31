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

public class Shop
{
    private List<Product> _products;

    public Shop()
    {
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public void RemoveProduct(int productId)
    {
        _products.RemoveAll(p => p.Id == productId);
    }

    public Product GetProductById(int productId)
    {
        return _products.FirstOrDefault(p => p.Id == productId);
    }

    public List<Product> GetAllProducts()
    {
        return new List<Product>(_products);
    }
}

public class Cart
{
    private List<Product> _productsInCart;

    public Cart()
    {
        _productsInCart = new List<Product>();
    }

    public void AddToCart(Product product)
    {
        _productsInCart.Add(product);
    }

    public void RemoveFromCart(int productId)
    {
        _productsInCart.RemoveAll(p => p.Id == productId);
    }

    public decimal GetTotalPrice()
    {
        return _productsInCart.Sum(p => p.Price);
    }

    public List<Product> GetCartProducts()
    {
        return new List<Product>(_productsInCart);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Shop shop = new Shop();

        shop.AddProduct(new Product(1, "Apple", 0.5m));
        shop.AddProduct(new Product(2, "Banana", 0.3m));
        shop.AddProduct(new Product(3, "Orange", 0.7m));

        Console.WriteLine("Available products in the shop:");
        foreach (var product in shop.GetAllProducts())
        {
            Console.WriteLine(product);
        }

        Cart cart = new Cart();

        cart.AddToCart(shop.GetProductById(1));
        cart.AddToCart(shop.GetProductById(2));

        Console.WriteLine("\nProducts in the cart:");
        foreach (var product in cart.GetCartProducts())
        {
            Console.WriteLine(product);
        }

        Console.WriteLine($"\nTotal price: {cart.GetTotalPrice():C}");

        cart.RemoveFromCart(1);

        Console.WriteLine("\nProducts in the cart after removal:");
        foreach (var product in cart.GetCartProducts())
        {
            Console.WriteLine(product);
        }

        Console.WriteLine($"\nTotal price after removal: {cart.GetTotalPrice():C}");
    }
}