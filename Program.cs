using Todo.lib;

class Program
{
    private static List<MyTask> TaskToDo = [];
    private List<MyTask> TaskDone = [];
    public static void Main(string[] args)
    {
        
        var input = new MyTask("Kake Spising", "Kake spising med mamma");

        TaskToDo.Add(input);

        while (true)
        {
            Console.WriteLine("Enter a task to do Title");
            var task = Console.ReadLine();

            
            Console.WriteLine("Enter a task to do Description");
            var task2 = Console.ReadLine();

            var unused = new MyTask(task, task2);
            TaskToDo.Add(unused);
            if (task == "q")
            {
                break;
            }
            
        }
        
        foreach (var element in TaskToDo)
        {
            Console.WriteLine(element.Title);
            Console.WriteLine(element.Description);
        }
        
        
    }
}