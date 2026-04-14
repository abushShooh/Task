
// task1
// var p = new Person();

// Console.Write("Enter your name: ");
// p.FisrtName = Console.ReadLine();

// Console.Write("Enter your last name: ");
// p.LastName = Console.ReadLine();

// Console.Write("Enter your age: ");
// p.Age = int.Parse(Console.ReadLine());

// p.GetInfo();

// task2
// var post = new Post();

// while (true)
// {
//     System.Console.WriteLine("Choose operation: ");
//     System.Console.WriteLine(@"1.Setpost
//     2.Add Like
//     3.Add comments
//     4. Get Information");
//     string a = Console.ReadLine();

//     switch (a)
//     {
//         case "1":
//             System.Console.Write("Write post: ");
//             var text = Console.ReadLine();
//             post.SetPost(text);
//             break;
//         case "2":
//             post.AddLike();
//             Console.WriteLine("Like added");
//             break;

//         case "3":
//         System.Console.Write("Write Comments: ");
//             post.addComment(Console.ReadLine());
//             break;
//         case "4":
//             post.GetInfo();
//             break;

//     }
// }

// task3
// var soccer = new Player();

// while (true)
// {
//     Console.WriteLine("Выбери операцию:");
//     Console.WriteLine(@"1. Информация об игроке
// 2. Создать игрока
// 3. Передача паса
// 4. Забить гол");

//     string a = Console.ReadLine() ?? "";

//     switch (a)
//     {
//         case "1":
//             soccer.GetInfo();
//             break;

//         case "2":
//             Console.Write("Имя игрока: ");
//             string name = Console.ReadLine();

//             Console.Write("Номер игрока: ");
//             int number =Convert.ToInt32(Console.ReadLine());

//             Console.Write("Позиция игрока: ");
//             string pos = Console.ReadLine();

//             Console.Write("Команда игрока: ");
//             string team = Console.ReadLine();

//             soccer.CreatePlayer(name, number, pos, team);
//             break;

//         case "3":
//             Console.Write("Кому отдал пас: ");
//             string passname = Console.ReadLine();
//             soccer.AssistGoal(passname);
//             break;

//         case "4":
//             soccer.ScoreGoal();
//             break;
//     }
// }

// task4
// var worker = new Worker();

// while (true)
// {
//     Console.WriteLine("\nВыбери операцию:");
//     Console.WriteLine("1. Создать/обновить сотрудника");
//     Console.WriteLine("2. Установить зарплату");
//     Console.WriteLine("3. Показать информацию");
//     Console.WriteLine("4. Посчитать накопления за N месяцев");
//     Console.WriteLine("0. Выход");
//     Console.Write(">> ");

//     string command = Console.ReadLine() ?? "";

//     switch (command)
//     {
//         case "1":
//             Console.Write("Имя: ");
//             worker.first_name = Console.ReadLine();

//             Console.Write("Фамилия: ");
//             worker.last_name = Console.ReadLine();

//             Console.Write("Возраст: ");
//             worker.age = Convert.ToInt32(Console.ReadLine());

//             Console.Write("Должность: ");
//             worker.position_in_company = Console.ReadLine();

//             Console.WriteLine("Сотрудник сохранен.");
//             break;

//         case "2":
//             Console.Write("Зарплата в месяц: ");
//             int salary =int.Parse(Console.ReadLine());

//             worker.SetSalary(salary);
//             Console.WriteLine("Зарплата обновлена.");
//             break;

//         case "3":
//             worker.GetInfo();
//             break;

//         case "4":
//             Console.Write("Введите количество месяцев: ");
//             int months= int.Parse(Console.ReadLine());
//             Console.WriteLine($"Накопления за {months} мес.: {worker.Recive(months)}");
//             break;

//         case "0":
//             return;

//         default:
//             Console.WriteLine("Неизвестная команда. Выбери 0-4.");
//             break;
//     }
// }

