
// task1
// var person =new Person();
// System.Console.WriteLine("Enter your name:");
// person.Name=Console.ReadLine();
// System.Console.WriteLine("Enter your last name:");
// person.LastName=Console.ReadLine();
// System.Console.WriteLine("Enter your age:");
// person.Age=int.Parse(Console.ReadLine());
// System.Console.WriteLine($"My full name is {person.getfullName(person.Name, person.LastName)}");
// person.Getbirthday(person.Age);

// task2
// var area = new Area();
// System.Console.Write("Width = ");
// area.Width =double.Parse(Console.ReadLine());
// System.Console.Write("Height = ");
// area.Height =double.Parse(Console.ReadLine());
// System.Console.WriteLine($"Area = {area.GetArea(area.Width, area.Height)}");

// task3
// Student[] students =
// {
//     new Student("Alice", 10, new int[] {85, 90, 92}),
//     new Student("Bob", 11, new int[] {78, 82, 88}),
//     new Student("Charlie", 12, new int[] {90, 95, 93}),
//     new Student("David", 10, new int[] {80, 85, 87}),
//     new Student("Eve", 11, new int[] {88, 90, 91}),
// };
// foreach (Student student in students)
// {
//     double avg = student.getAverage();

//     if (avg > 85)
//     {
//         Console.WriteLine($"Congratulations {student.Name}! Your average score is {avg:F1} in grade {student.gradeLevel}.");
//         Console.WriteLine("Keep up the good work!");
//     }
//     else if (avg < 70)
//     {
//         Console.WriteLine($"{student.Name}, your average score is {avg:F1} in grade {student.gradeLevel}.");
//         Console.WriteLine("We are here to support you. Please seek additional help if needed.");
//     }
//     else
//     {
//         Console.WriteLine($"{student.Name}, good job! Your average score is {avg:F1} in grade {student.gradeLevel}.");
//         Console.WriteLine("Keep working hard for even better results!");
//     }

//     Console.WriteLine("------------------------------------------------");
// }

// task4
 Car myCar = new Car("Toyota", "Camry", 2022);

        Console.WriteLine($"Make: {myCar.Make}");
        Console.WriteLine($"Model: {myCar.Model}");
        Console.WriteLine($"Year: {myCar.Year}");
        Console.WriteLine($"Mileage: {myCar.Mileage:0.##} miles");
        Console.WriteLine($"Fuel level: {myCar.Fuel:0.##} gallons");

        myCar.AddFuel(10);
        myCar.Drive(100);
        myCar.AddFuel(10);

        Console.WriteLine("\nAfter the trip and refueling:");
        Console.WriteLine($"Mileage: {myCar.Mileage:0.##} miles");
        Console.WriteLine($"Fuel level: {myCar.Fuel:0.##} gallons");