
// task1
// Book book = new Book("Агар ҷавонӣ медонист…", "Башир Усмон", 2019);

// book.GetInfo();
// Console.WriteLine(book.IsPublishedRecently());

// task2
// Console.Write("Enter circle radius: ");
// string? input = Console.ReadLine();

// if (double.TryParse(input, out double userRadius) && userRadius >= 0)
// {
//     Circle circle = new Circle(userRadius);

//     Console.WriteLine($"Radius: {circle.GetRadius():F2}");
//     Console.WriteLine($"Area: {circle.GetArea():F2}");
//     Console.WriteLine($"Diameter: {circle.GetDiameter():F2}");
//     Console.WriteLine($"Circumference: {circle.GetCircumference():F2}");
// }
// else
// {
//     Console.WriteLine("Invalid input. Please enter a non-negative number.");
// }

// task3
// Date date = new Date();
// date.SetDate(1, 12, 2023);
// Console.WriteLine(date.ToString());

// task4
// BankAccount account = new BankAccount(1001, "John Doe", 5000.00m);

// Console.WriteLine($"AccountId: {account.AccountId}");
// Console.WriteLine($"Owner: {account.OwnerName}");
// Console.WriteLine($"Balance: {account.Balance:F2}");
// Console.WriteLine();

// account.Deposit(1000.00m);
// account.Withdraw(200.00m);

// account.FreezeAccount();
// account.Deposit(500.00m); // не выполнится

// account.UnfreezeAccount();
// account.Deposit(500.00m); // выполнится

// Console.WriteLine($"\nИтоговый баланс: {account.Balance:F2}");