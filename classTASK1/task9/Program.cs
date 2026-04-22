var shop = new Shop();

while (true)
{
System.Console.WriteLine(@$"1. Add Product
2. Remove Product
3. Show Products
4. Exit
");
    System.Console.WriteLine("Enter option: ");
    var option = Console.ReadLine();
    switch (option)
    {
        case "1":
            Console.Write("Type (1-Phone, 2-Car): ");
            var type = Console.ReadLine();

            Console.Write("Enter product name: ");
            var name = Console.ReadLine() ?? "";

            Console.Write("Enter product price: ");
            if (!decimal.TryParse(Console.ReadLine(), out var price))
            {
                Console.WriteLine("Invalid price.");
                break;
            }

            if (type == "1")
            {
                Console.Write("Enter brand: ");
                var brand = Console.ReadLine() ?? "";

                Console.Write("Enter memory (GB): ");
                if (!int.TryParse(Console.ReadLine(), out var memory))
                {
                    Console.WriteLine("Invalid memory.");
                    break;
                }

                shop.AddProduct(new Phone(name, price, brand, memory));
            }
            else if (type == "2")
            {
                Console.Write("Enter brand: ");
                var brand = Console.ReadLine() ?? "";

                Console.Write("Enter horse power: ");
                if (!int.TryParse(Console.ReadLine(), out var hp))
                {
                    Console.WriteLine("Invalid horse power.");
                    break;
                }

                shop.AddProduct(new Car(name, price, brand, hp));
            }
            else
            {
                Console.WriteLine("Invalid product type.");
            }
            break;

        case "2":
            Console.Write("Enter product name to remove: ");
            var nameToRemove = Console.ReadLine();
            var productToRemove = shop.Products.FirstOrDefault(p => p.Name == nameToRemove);

            if (productToRemove != null)
            {
                shop.RemoveProduct(productToRemove);
                Console.WriteLine("Product removed.");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
            break;

        case "3":
           
            shop.ShowProducts();
            break;

        case "4":
            return;

        default:
            Console.WriteLine("Invalid option. Try again.");
            break;
    }
}