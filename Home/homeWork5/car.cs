using System;

public class Car
{
    // 1) Свойства
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public double Mileage { get; private set; }
    public double Fuel { get; private set; }

    // Сколько миль проезжаем на 1 галлоне
    private const double MilesPerGallon = 20.0;

    // 2) Конструктор
    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
        Mileage = 0;
        Fuel = 0;
    }

    // 3) Метод поездки
    public void Drive(double miles)
    {
        if (miles <= 0)
        {
            Console.WriteLine("Distance must be greater than 0.");
            return;
        }

        double neededFuel = miles / MilesPerGallon;

        if (Fuel < neededFuel)
        {
            Console.WriteLine("Not enough fuel. Please refuel.");
            return;
        }

        Fuel -= neededFuel;
        Mileage += miles;

        Console.WriteLine($"You have driven {miles:0.##} miles. Current mileage: {Mileage:0.##} miles. Remaining fuel: {Fuel:0.##} gallons.");
    }

    // 4) Метод заправки
    public void AddFuel(double gallons)
    {
        if (gallons <= 0)
        {
            Console.WriteLine("Fuel amount must be greater than 0.");
            return;
        }

        Fuel += gallons;
        Console.WriteLine($"Added {gallons:0.##} gallons of fuel. Current fuel level: {Fuel:0.##} gallons.");
    }
}