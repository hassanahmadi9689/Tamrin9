namespace ConsoleApp85;

public class Task
{
    protected Task(string name,DateTime taskTime)
    {
        Name = name;
        TaskTime = taskTime;
    }
    public string Name { get; set; }
    public DateTime TaskTime { get; set; }
    public TaskType TaskType { get; private set; }

    public void setTasttype(TaskType taskType)
    {
        TaskType = taskType;
    }
}

public enum TaskType
{
    normal,
    important
}