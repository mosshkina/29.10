using _29._10;

    partial class Program
    {
        internal static void Main(String[] args)
        {
            string[] tasks = { "Разработать мобильное приложение", "Сделать алгоритм для видеохостинга",
            "Обновить устаревшее ПО", "Сделать сайт для заказчика" };
            StreamReader info = new StreamReader(@"C:\Users\Анастасия\source\repos\29.10\29.10\1.txt");
            Console.WriteLine(info.ReadToEnd());
            Console.WriteLine($"Список задач перед компанией: \n 1 - {tasks[0]} \n 2 - {tasks[1]} \n 3 - {tasks[2]} \n " +
                $"4 - {tasks[3]} \n");
            Console.WriteLine("Введите номер задачи, которую хотите дать одному из работников компании");
            string task = tasks[int.Parse(Console.ReadLine()) - 1];
            Console.WriteLine($"Кому дать задачу <<{task}>>");
            var person1 = Staf.ReturnPerson(Console.ReadLine());
            Console.WriteLine($"Кому {person1.name} перенаправит задачу?");
            var person2 = Staf.ReturnPerson(Console.ReadLine());


            Console.WriteLine($"\n{person1.name} дает задачу <<{task}>>, которую исполнит {person2.name} \n");
            if ((person2.number - 1 == person1.number) && ((person1.department == person2.department) || ((person1.department == "superiors") && (person2.department == "system")) || ((person1.department == "superiors") && (person2.department == "development"))))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{person2.name} берет эту задачу");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{person2.name} не берет эту задачу");
                Console.ResetColor();
            }
        }
    }
