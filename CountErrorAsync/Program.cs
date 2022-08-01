using CountErrorAsync;

public class Program
{
    public static async Task Main(string[] args)
    {

        //string File1 = @"C:\Users\himanshu.patil\Downloads\ErrorLogs\NexusService-20220715_003.log";
        //string File2 = @"C:\Users\himanshu.patil\Downloads\ErrorLogs\NexusService-20220715_004.log";
        //string File3 = @"C:\Users\himanshu.patil\Downloads\ErrorLogs\NexusService-20220715_005.log";
        //string File4 = @"C:\Users\himanshu.patil\Downloads\ErrorLogs\NexusService-20220716.log";
        //string File5 = @"C:\Users\himanshu.patil\Downloads\ErrorLogs\NexusService-20220716_001.log";
        //string File6 = @"C:\Users\himanshu.patil\Downloads\ErrorLogs\NexusService-20220717.log";
        //string File7 = @"C:\Users\himanshu.patil\Downloads\ErrorLogs\NexusService-20220717_001.log";
        //string File8 = @"C:\Users\himanshu.patil\Downloads\ErrorLogs\NexusService-20220717_002.log";
        //string File9 = @"C:\Users\himanshu.patil\Downloads\ErrorLogs\NexusService-20220720.log";
        //string File10 = @"C:\Users\himanshu.patil\Downloads\ErrorLogs\NexusService-20220728.log";


        //Reading Files
        string[] FilePaths = Directory.GetFiles(@"C:\Users\himanshu.patil\Downloads\ErrorLogs\", "*.log");

        foreach (string Files in FilePaths)
        {
            //Console.WriteLine(Files);


            await AsyncClass.ReadTheFile(Files);
            await AsyncClass.DeleteTheFile(Files);
        }

        //AsyncClass obj = new AsyncClass();

        //obj.ReadTheFile(File1);
        //obj.ReadTheFile(File2);
        //obj.ReadTheFile(File3);
        //obj.ReadTheFile(File4);
        //obj.ReadTheFile(File5);
        //obj.ReadTheFile(File6);
        //obj.ReadTheFile(File7);
        //obj.ReadTheFile(File8);
        //obj.ReadTheFile(File9);
        //obj.ReadTheFile(File10);


    }

    

   
}


    