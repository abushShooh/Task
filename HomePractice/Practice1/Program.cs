var market = new Mini_market();

while (true)
{
    System.Console.WriteLine(@$"
----------------------
1. Add Product
2. Remove Product
3. Show Products
4. Exit
----------------------
");
System.Console.Write("Enter option: ");
    var option = Console.ReadLine();
    switch (option)
    {

        case "1":
            System.Console.WriteLine("Enter product type (1-Laptop, 2-Book): ");
            var type = Console.ReadLine();
            if (type == "1")
            {
                System.Console.WriteLine("Enter product name: ");
                var name = Console.ReadLine();
                System.Console.WriteLine("Enter product price: ");
                decimal price = decimal.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter product ram: ");
                int ram = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter product brand: ");
                var brand = Console.ReadLine();
                market.AddProduct(new Laptop(name, price, ram, brand));
            }
            else
            {
                System.Console.WriteLine("Enter Book name: ");
                var name = Console.ReadLine();
                System.Console.WriteLine("Enter product price: ");
                decimal price = decimal.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter Book aughtor: ");
                var aughtor = Console.ReadLine();
                System.Console.WriteLine("Enter Book pages: ");
                int pages = int.Parse(Console.ReadLine());
                market.AddProduct(new Book(name, price, aughtor, pages));
            }
            break;
        case "2":
            System.Console.WriteLine("Enter product name to remove: ");
            var nameToRemove = Console.ReadLine();
            var productToRemove = market.Products.RemoveAll(p => p.Name == nameToRemove);
            if (productToRemove > 0)
            {
                System.Console.WriteLine("Product removed successfully.");
            }
            else
            {
                System.Console.WriteLine("Product not found.");
            }
            break;
        case "3":
            market.ShowP();
            break;
        case "4":
            return;
        default:
            System.Console.WriteLine("Invalid option. Please try again.");
            break;
    }
}