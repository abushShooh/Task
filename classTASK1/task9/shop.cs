public class Shop
{
    public List<Product> Products {get; set;} = new List<Product>();

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }
    public void RemoveProduct(Product product)
    {
        Products.Remove(product);   
    }

    public void ShowProducts()
    {
        foreach (var item in Products)
        {
            item.GetInfo();
        }
    }


}

public class Product
{
    public string Name {get; set;}
    public decimal Price {get; set;}

    public Product(string name, decimal price)
    {
        Name = name;
        Price =price;
    }

    public virtual void GetInfo()
    {
        System.Console.WriteLine($"Product: {Name}, Price: {Price}" );
    }
}
public class Phone :Product
{
    public int Memory {get; set;}
    public string Brand {get; set;}

    public Phone(string name, decimal price, string brand, int memory) : base(name, price)
    {
        Memory = memory;
        Brand = brand;
    }

    public override void GetInfo()
    {
        System.Console.WriteLine($"Phone: {Name}, Price: {Price}, Memory: {Memory}, Brand: {Brand}" );
    }

}

public class Car : Product
{
    public string Model {get; set;}
    public int Power {get; set;}

    public Car(string name, decimal price, string model, int power) : base(name,price)
    {
        Model = model;
        Power = power;
    }

    public override void GetInfo()
    {
        System.Console.WriteLine($"Car: {Name}, Price: {Price}, Model: {Model}, Power: {Power}hp" );
    }
}

