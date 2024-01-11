namespace ConsoleApp85;

public class Management : ITask
{
    private static List<Task> _tasks = new List<Task>();
    public void AddTask(string name, DateTime tasktime, int tasktype)
    {
        if (tasktype==1)
        {
            var task = new NormalTask(name,tasktime);
            task.setTasttype(TaskType.normal);
            _tasks.Add(task);
        }

        if (tasktype==2)
        {
            var task = new ImportantTask(name, tasktime);
            task.setTasttype(TaskType.important);
            _tasks.Add(task);
        }
    }

    public void ShowTask()
    {
        foreach (var task in _tasks)
        {
                Console.WriteLine($"name:{task.Name} - type:{task.TaskType} - time to do:{task.TaskTime}");
        }
    }
}