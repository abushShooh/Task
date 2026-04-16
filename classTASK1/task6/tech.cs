public class Teacher
{
    private string name {get; set;}
    private string subject {get; set;}
    private int experience {get; set;}
    public Teacher(string name, string subject,int experience)
    {
        this.name = name;
        this.subject = subject;
        this.experience = experience;
    }
    public Teacher(string name, string subject)
    {
        this.name = name;
        this.subject = subject;
    }
    public string teach()
    {
        return $"{name} is teaching {subject}";
    }
    public void setExperience(int experience)
    {
        this.experience = experience;
    }
    public int getExperience()
    {
        return experience;
    }

}