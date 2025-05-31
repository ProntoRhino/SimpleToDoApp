using System.Collections;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace SimplePetProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TaskItem> tasks = new List<TaskItem>();

            while (true)
            {
                Console.WriteLine("===== Menu =====\n" +
                "1. Add task\n" +
                "2. Remove task\n" +
                "3. Show all tasks\n" +
                "4. Mark task as complited\n" +
                "5. Close the program\n");

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
                        MarkComplited(tasks);
                        break;

                    case "5":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }

                Console.WriteLine();
            }
        }

        public static void AddTask(List<TaskItem> tasks)
        {
            Console.WriteLine("Please add a task");
            string description = Console.ReadLine();
            TaskItem task = new TaskItem(description);
            tasks.Add(task);
        }

        public static void RemoveTask(List<TaskItem> tasks)
        {
            ShowTasks(tasks);
            Console.Write("Please choose which task to remove:");
            tasks.RemoveAt(Convert.ToInt32(Console.ReadLine())-1);
        }

        public static void ShowTasks(List<TaskItem> tasks)
        {
            Console.WriteLine("tasks list:");
            int counter = 1;
            foreach (TaskItem task in tasks)
            {
                Console.WriteLine(counter + ". " + task);
                counter++;
            }
        }

        public static void MarkComplited(List<TaskItem> tasks)
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("There are no tasks to be marked as completed.");
                return;
            }

            ShowTasks(tasks);
            Console.Write("Please choose which task should be marked as complited:");

            if (int.TryParse(Console.ReadLine(), out int choosed)) 
            { 
                if (choosed >= 1 && choosed <= tasks.Count)
                {
                    tasks[choosed - 1].IsCompleted = true;
                    Console.WriteLine("Task marked as completed.");
                }
                else
                {
                    Console.WriteLine("Invalid task number.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}
