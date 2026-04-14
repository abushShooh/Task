class Worker
{
    public string first_name { get; set; }
    public string last_name { get; set; }
    public int age { get; set; }
    public string position_in_company { get; set; }
    public decimal set_salary { get; set; }
    public int months { get; set; }

    public void SetSalary(decimal salary)
    {
        set_salary = salary;
    }

    public decimal GetSalary()
    {
        return set_salary;
    }

    public decimal Recive(int month)
    {
        return set_salary * month;
    }

    public void GetInfo()
    {
        System.Console.WriteLine("Имя: " + first_name);
        System.Console.WriteLine("Фамилия: " + last_name);
        System.Console.WriteLine("Возраст: " + age);
        System.Console.WriteLine("Должность: " + position_in_company);
        System.Console.WriteLine("Зарплата в месяц: " + set_salary);
        System.Console.WriteLine("Накопления: " + Recive(months));
    }
}
