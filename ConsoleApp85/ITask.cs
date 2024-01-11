namespace ConsoleApp85;

public interface ITask
{
    public void AddTask(string name,DateTime tasktime,int tasktype);
    public void ShowTask();
}