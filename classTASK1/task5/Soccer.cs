class Player
{
    public string? Name { get; set; }
    public int Number { get; set; }
    public string? Position { get; set; }
    public string? Team { get; set; }
    public int Goal { get; set; }

    public void ScoreGoal()
    {
        Goal++;
        Console.WriteLine($"Игрок {Name}");
        Console.WriteLine($"Под номером {Number}");
        Console.WriteLine($"Забил: {Goal}");
    }

    public void CreatePlayer(string name, int number, string position, string team)
    {
        Name = name;
        Number = number;
        Position = position;
        Team = team;
        Console.WriteLine("Player already created...");
    }

    public void AssistGoal(string playerName)
    {
        Console.WriteLine($"Игрок {Name} под номером {Number} отдал пас игроку {playerName}");
    }

    public void GetInfo()
    {
        Console.WriteLine("Имя игрока: " + Name);
        Console.WriteLine("Номер игрока: " + Number);
        Console.WriteLine("Позиция игрока: " + Position);
        Console.WriteLine("Команда: " + Team);
        Console.WriteLine("Забитые голы: " + Goal);
    }
}