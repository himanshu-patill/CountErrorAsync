using CountErrorAsync;

public class Program
{
    public static async Task Main(string[] args)
    {
        //Reading Files
        string[] FilePaths = Directory.GetFiles(@"C:\Users\himanshu.patil\Downloads\ErrorLogs\", "*.log");

        AsyncClass asyncClass = new AsyncClass();

        foreach (string Files in FilePaths)
        {
            await asyncClass.ReadTheFile(Files);
        }
    }
}


    