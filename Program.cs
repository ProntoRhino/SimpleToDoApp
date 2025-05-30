using System.Collections;
using System.Diagnostics.Metrics;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace SimplePetProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> tasks = new List<string>();

            tasks.Add("Do the dishes");
            tasks.Add("Shower");
            tasks.Add("Go to bed");

            while (true)
            {
                Console.WriteLine("===== Menu =====\n" +
                "1. Add task\n" +
                "2. Remove task\n" +
                "3. Show all tasks\n" +
                "4. Close the program\n");

                string userInputChoice = Console.ReadLine();

                switch (userInputChoice)
                {
                    case "1":
                        AddTask(tasks);
                        break;

                    case "2":
                        RemoveTask(tasks);
                        break;

                    case "3":
                        ShowTasks(tasks);
                        break;

                    case "4":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }

                Console.WriteLine();
            }
        }

        public static void AddTask(List<string> tasks)
        {
            Console.WriteLine("Please enter task fo to-do list");
            tasks.Add(Console.ReadLine());
        }

        public static void RemoveTask(List<string> tasks)
        {
            Console.WriteLine("Please choose which task to remove");
            tasks.RemoveAt(Convert.ToInt32(Console.ReadLine())-1);
        }

        public static void ShowTasks(List<string> tasks)
        {
            Console.WriteLine("tasks list:");
            int counter = 1;
            foreach (string task in tasks)
            {
                Console.WriteLine(counter + ". " + task);
                counter++;
            }
        }
    }
}
