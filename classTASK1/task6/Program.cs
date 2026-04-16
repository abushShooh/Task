
// task1
// Teacher[] teachers =
// {
//     new Teacher("John Doe", "Mathematics", 10),
//     new Teacher("Jane Smith", "Physics",20),
//     new Teacher("Emily Davis", "Chemistry", 5)
// };
// foreach(var teacher in teachers)
// {
//     System.Console.WriteLine(teacher.teach());
//     System.Console.WriteLine($"\nExperience: {teacher.getExperience()} years \n");
// }

// task2
// var student = new Student();
// System.Console.WriteLine("Enter your name:");
// student.FullName = System.Console.ReadLine();
// System.Console.WriteLine("Enter your age:");
// student.Age = int.Parse(System.Console.ReadLine());
// System.Console.WriteLine("Enter your grade:");
// student.Grade = int.Parse(Console.ReadLine());
// student.SetGrade(student.Grade);
// student.GetGrade();

// task3
// Patient p = new Patient("Иванов Иван", 30);
// Doctor d = new Doctor("Петров Петр", "Терапевт", 12);

// Console.WriteLine(d.TreatPatient(p));
// Console.WriteLine(d.PerformMedicalExamination(p));
// Console.WriteLine(d.PrescribeMedication(p, "Ибупрофен"));

// p.AddMedicalRecord("ОРВИ");
// p.AddMedicalRecord("Плановый осмотр");

// Console.WriteLine("Стаж врача: " + d.GetExperience());
// Console.WriteLine("История пациента: " + string.Join(", ", p.GetMedicalHistory()));

// task4
// Actor actor = new Actor("Leonardo DiCaprio", 49, "Male");

// Movie movie1 = new Movie("Inception", 2010);
// Movie movie2 = new Movie("Titanic", 1997);

// actor.AddMovie(movie1);
// actor.AddMovie(movie2);

// Console.WriteLine($"Age: {actor.GetAge()}");
// Console.WriteLine($"Gender: {actor.GetGender()}");
// Console.WriteLine("Movies played:");

// foreach (Movie movie in actor.GetMoviesPlayed())
// {
//     Console.WriteLine($"{movie.GetTitle()} ({movie.GetReleaseYear()})");
// }