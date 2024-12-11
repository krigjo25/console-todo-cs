namespace Todo.lib;

public class TodoList
{
    private readonly List<MyTask> TaskToDo = [];
    private List<MyTask> TaskDone = [];
    
    protected void PushTask(MyTask obj)
    { 
        TaskToDo.Add(obj);
        
    }

    private void PrintTitle()
    {
        foreach (var task in TaskToDo)
        {
            Console.WriteLine($"{task.Title}");

        }
    }

    public void PrintTodo()
    {

        foreach (var task in TaskToDo)
        {
            Console.WriteLine($"List test");
            Console.WriteLine($"{task.Title}");
            Console.WriteLine($"{task.Description}");
        }
    }

    public void InitializeTasks()
    {
        var unused = new MyTask("Kake spising", "Skal spise kake sammens med mamma idag");
    }
}