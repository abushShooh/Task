public class Student
{
    public string Name {get; set;}
    public int gradeLevel {get; set;}
    public int[] testScores {get; set;}

    public Student(string name, int Level, int[] Scores)
    {
        Name = name;
        gradeLevel = Level;
        testScores = Scores;
    }

    public double getAverage()
    {
        int sum=0;
        for(int i=0;i<testScores.Length;i++)
        {
            sum+=testScores[i];
        }
        return sum/testScores.Length;
    }
    
}