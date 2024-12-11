namespace Todo.lib;

public class MyTask :TodoList
{
    private string _description;

    public string Title { get; set; }

    public string Description { get; set; }

    public MyTask(string title, string description)
    {
        Title = title;
        Description = description;
        Console.WriteLine("Created task");
        PushTask(this);
    }
}