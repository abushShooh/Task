public class Person
{
    public string Name {get; set;}
    public int Age {get; set;}
    public string LastName {get; set;}

    public string getfullName(string name, string lastname)

    {
        Name = name;
        LastName = lastname;
        return $"{Name} {LastName}";
    }

    public void Getbirthday(int years)
    {
        years=Age;
        System.Console.WriteLine($"My birth year is: {years}");
    }
}