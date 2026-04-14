class Person
{
    public string FisrtName {get; set;}
    public string LastName {get; set;}
    public int Age {get; set;}

    public void GetInfo()
    {
        System.Console.WriteLine("FirstName: "+ FisrtName);
        System.Console.WriteLine("LastName: "+ LastName);
        System.Console.WriteLine("Age: "+ Age);
    }
    
}