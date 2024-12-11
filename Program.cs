using Todo.lib;

class Program
{
    private static List<MyTask> TaskToDo = [];
    private static string? command;
    private List<MyTask> TaskDone = [];


    public static void Main(string[] args)
    {

        var input = new MyTask("Kake Spising", "Kake spising med mamma");


        TaskToDo.Add(input);

        do
        {
            Console.WriteLine("1 legg til oppgave, 2 vis oppgaver, 3 vis oppgave detaljer, 4 slett oppgaver, 5 slutt ");
            command = Console.ReadLine();
            switch (command)
            {
                case "1":


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

                    ;
                    break;
                case "2":
                    foreach (var element in TaskToDo)
                    {
                        Console.WriteLine(element.Title);
                    }

                    break;
                case "3":
                    foreach (var element in TaskToDo)
                    {
                        Console.WriteLine(element.Title);
                        Console.WriteLine(element.Description);
                    }

                    break;
                case "4":
                    for (int i = 0; i < TaskToDo.Count; i++)
                    {
                        Console.WriteLine($"nummer[{i}]: {TaskToDo[i].Title}");
                        Console.WriteLine(TaskToDo[i].Description);
                    }

                    Console.WriteLine("velg hvilken å slette");
                    int Deletenummer = Convert.ToInt32(Console.ReadLine());
                    TaskToDo.RemoveAt(Deletenummer);
                    break;

            }

        } while (command != "5");
    }
}