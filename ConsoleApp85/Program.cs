// See https://aka.ms/new-console-template for more information

using ConsoleApp85;

ITask task = new Management();
while (true)
{
    try
    {
        Run();

    }
    catch (Exception exception)
    {
        ShowError(exception.Message);
    }
}


void Run()
{var Option = GetNumberFromUser("Choose option:\n" +
                                "1.Add Task\n" +
                                "2.Show Tasks");
    switch (Option)
    {
        case 1:
        {
            var name = GetValidStringFromUser("enter name of task");
            var tasktype = GetNumberFromUser("choose:\n" +
                                             "1.normal task\n" +
                                             "2.important task");
            var taskdate = GetDateFromUser("enter date to do for this task");
            task.AddTask(name,taskdate,tasktype);
            
            break;
        }
        case 2:
        {
            task.ShowTask();
            break;
        }
        
    }
    
}


static string GetValidStringFromUser(string message)
{
    bool tryparse = false;
    string? value;
    do
    {
        Console.WriteLine(message);
        value = Console.ReadLine();
          
    } while ( string.IsNullOrWhiteSpace(value)   );
 
    return value;
}

static int GetNumberFromUser(string message)
{
    var resultTryParseFirstNumber = false;
    int number;
    do
    {
        Console.WriteLine(message);
        resultTryParseFirstNumber =
            int.TryParse(Console.ReadLine(), out number);
    } while (!resultTryParseFirstNumber );

    return number;
}
static DateTime GetDateFromUser(string message)
{
    var resultTryParseFirstNumber = false;
    DateTime dateTime;
    do
    {
        Console.WriteLine(message);
        resultTryParseFirstNumber =
            DateTime.TryParse(Console.ReadLine(), out dateTime);
    } while (!resultTryParseFirstNumber );

    return dateTime;
}


static void ShowError(string error)
{
    Console.WriteLine("*********");
    Console.WriteLine(error);
    Console.WriteLine("*********");
}