public class Mini_market
{
    public List<Product> Products {get; set;} =new List<Product>();
    
    public void AddProduct(Product prods)
    {
        Products.Add(prods);
    }
    public void RemoveProduct(Product prods)
    {
        Products.Remove(prods);
    }
    public void ShowP()
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
    public Product(string name,decimal price)
    {
        Name =name;
        Price =price;
    }
    public virtual void GetInfo()
    {
        System.Console.WriteLine($" Name: {Name}\n Price: {Price}");
    }
}

public class Laptop : Product
{
    public int Ramm {get; set;}
    public string Brand {get; set;}
    public Laptop(string name,decimal price,int ramm,string brand) : base(name, price)
    {
        Ramm =ramm;
        Brand =brand;

    }
    public override void GetInfo()
    {
        System.Console.WriteLine($"Name: {Name}\n Price: {Price}\n Ram: {Ramm}\n Brand: {Brand}");
    }
}
public class Book : Product
{
    public string Aughtor {get; set;}
    public int Pages {get; set;}

    public Book(string name,decimal price, string aughtor, int pages) : base(name, price)
    {
        Aughtor = aughtor;
        Pages = pages;
    }
    public override void GetInfo()
    {
        System.Console.WriteLine($"Name: {Name}\n Price: {Price}\n Aughtor: {Aughtor}\n Pages: {Pages}");
    }
}
