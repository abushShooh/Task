public class Group
{
    private static readonly List<Group> _groups = new();

    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public Group(int id, string name, string description)
    {
        Id = id;
        Name = name;
        Description = description;
    }

    public static void CreateGroup(int id, string name, string description)
    {
        if (_groups.Any(g => g.Id == id))
        {
            Console.WriteLine("Group with this ID already exists.");
            return;
        }

        _groups.Add(new Group(id, name, description));
        Console.WriteLine("Group created successfully.");
    }

    public static void GetGroups(int id)
    {
        var group = _groups.FirstOrDefault(g => g.Id == id);

        if (group is null)
        {
            Console.WriteLine("Group not found.");
            return;
        }

        Console.WriteLine($"ID: {group.Id}");
        Console.WriteLine($"Name: {group.Name}");
        Console.WriteLine($"Description: {group.Description}");
    }

    public static void UpdateGroup(int id, string name, string description)
    {
        var group = _groups.FirstOrDefault(g => g.Id == id);

        if (group is null)
        {
            Console.WriteLine("Group not found.");
            return;
        }

        group.Name = name;
        group.Description = description;
        Console.WriteLine("Group updated successfully.");
    }

    public static void DeleteGroup(int id)
    {
        var group = _groups.FirstOrDefault(g => g.Id == id);

        if (group is null)
        {
            Console.WriteLine("Group not found.");
            return;
        }

        _groups.Remove(group);
        Console.WriteLine("Group deleted successfully.");
    }
}
