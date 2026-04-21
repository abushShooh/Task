Console.WriteLine("Choose option:");

while (true)
{
    Console.WriteLine("1 - Create Group");
    Console.WriteLine("2 - Get Group");
    Console.WriteLine("3 - Update Group");
    Console.WriteLine("4 - Delete Group");
    Console.WriteLine("0 - Exit");

    var choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
        {
            int id = ReadInt("Enter group ID:");
            string name = ReadRequired("Enter group name:");
            string description = ReadRequired("Enter group description:");

            Group.CreateGroup(id, name, description);
            break;
        }
        case "2":
        {
            int id = ReadInt("Enter group ID:");
            Group.GetGroups(id);
            break;
        }
        case "3":
        {
            int id = ReadInt("Enter group ID to update:");
            string name = ReadRequired("Enter new name:");
            string description = ReadRequired("Enter new description:");

            Group.UpdateGroup(id, name, description);
            break;
        }
        case "4":
        {
            int id = ReadInt("Enter group ID to delete:");
            Group.DeleteGroup(id);
            break;
        }
        case "0":
            return;
        default:
            Console.WriteLine("Invalid option. Try again.");
            break;
    }

    Console.WriteLine();
}

static int ReadInt(string prompt)
{
    while (true)
    {
        Console.WriteLine(prompt);
        var input = Console.ReadLine();

        if (int.TryParse(input, out int value))
        {
            return value;
        }

        Console.WriteLine("Please enter a valid integer.");
    }
}

static string ReadRequired(string prompt)
{
    while (true)
    {
        Console.WriteLine(prompt);
        var input = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(input))
        {
            return input.Trim();
        }

        Console.WriteLine("Value cannot be empty.");
    }
}
