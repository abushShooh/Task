public class Student
{
    public string FullName { get; set; }
    public int Age { get; set; }
    public int Grade { get; set; }

    public void Study(string name)
    {
        FullName = name;
        Console.WriteLine($"{name} is studying.");
    }
    public void SetGrade(int newGrade)
    {
        Grade = newGrade;
        if (newGrade >= 90)
        {
            System.Console.WriteLine("A");

        }
        else if (newGrade >= 80)
        {
            System.Console.WriteLine("B");

        }
        else if (newGrade >= 70)
        {
            System.Console.WriteLine("C");

        }
        else if (newGrade >= 60)
        {
            System.Console.WriteLine("D");

        }
        else
        {
            System.Console.WriteLine("F");

        }

    }
    public void GetGrade()
    {
        Console.WriteLine(@$"{FullName},
        Your age is: {Age}
        Your grade is: {Grade}");
    }
}