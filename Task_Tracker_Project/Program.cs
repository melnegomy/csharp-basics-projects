namespace Task_Tracker_Project
{
    internal class Program
    {

        static string[] tasks = new string[100];
        static int taskIndex = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom To My Task Tracker App");
            
            Console.WriteLine("----------------------");
            Console.WriteLine("1 - add");
            Console.WriteLine("2 - view all tasks");
            Console.WriteLine("3 - mark task complete");
            Console.WriteLine("4 - remove task");
            Console.WriteLine("5 - exit");
          
            while(true){
            Console.WriteLine("----------------------");
            Console.WriteLine("Enter Your Choice From 1 To 5");
            string userchoice = Console.ReadLine();
            switch (userchoice)
            {
                case "1":
                    //add
                    AddTasks();
                    break;
                case "2":
                    //view all tasks
                    ViewTasks();
                    break;
                case "3":
                        //mark task complete
                        TaskCompleted();
                        break;
                case "4":
                        //remove task
                        RemoveTask();
                        break;  
                case "5":
                    //exit
                Environment.Exit(0);
                        break;
                default:
                    Console.WriteLine("Thanks");
                    break;
            }
            }
            
        }

        private static void AddTasks()
        {
            Console.WriteLine("Enter The Task");
            string taskTilte = Console.ReadLine();
            tasks[taskIndex] = taskTilte;
            Console.WriteLine("Task Added");
            taskIndex++;   
        }
        private static void ViewTasks()
        {
            Console.WriteLine("Task List : ");

            for (int i = 0; i < taskIndex; i++)
            {
                Console.WriteLine($"{i + 1}. Task Title: {tasks[i]}");
            }



        }
        private static void TaskCompleted() 
        {
            Console.WriteLine("Enter The Number Of Tasks : ");
            int numberTask=Convert.ToInt32(Console.ReadLine());
            tasks[numberTask] = tasks[numberTask] + " --Completed";
        }

        private static void RemoveTask()
        {

            Console.WriteLine("Enter The Number Of Tasks To Delete : ");
            int numberTask = Convert.ToInt32(Console.ReadLine());
            // tasks[numberTask] = "";
             tasks[numberTask] = string.Empty;


        }
    }
}
