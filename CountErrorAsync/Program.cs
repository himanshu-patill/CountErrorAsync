public class Program
{
    public static void Main(string[] args)
    {
        string File1 = @"C:\Users\himanshu.patil\Downloads\ErrorLogs\NexusService-20220715_003.log";
        string File2 = @"C:\Users\himanshu.patil\Downloads\ErrorLogs\NexusService-20220715_004.log";
        string File3 = @"C:\Users\himanshu.patil\Downloads\ErrorLogs\NexusService-20220715_005.log";
        string File4 = @"C:\Users\himanshu.patil\Downloads\ErrorLogs\NexusService-20220716.log";
        string File5 = @"C:\Users\himanshu.patil\Downloads\ErrorLogs\NexusService-20220716_001.log";
        string File6 = @"C:\Users\himanshu.patil\Downloads\ErrorLogs\NexusService-20220717.log";
        string File7 = @"C:\Users\himanshu.patil\Downloads\ErrorLogs\NexusService-20220717_001.log";
        string File8 = @"C:\Users\himanshu.patil\Downloads\ErrorLogs\NexusService-20220717_002.log";
        string File9 = @"C:\Users\himanshu.patil\Downloads\ErrorLogs\NexusService-20220720.log";
        string File10 = @"C:\Users\himanshu.patil\Downloads\ErrorLogs\NexusService-20220728.log";

        ReadTheFile(File1);
        ReadTheFile(File2);
        ReadTheFile(File3);
        ReadTheFile(File4);
        ReadTheFile(File5);
        ReadTheFile(File6);
        ReadTheFile(File7);
        ReadTheFile(File8);
        ReadTheFile(File9);
        ReadTheFile(File10);

        
    }

    static async void ReadTheFile(string GivenFile)
    {
        string[] lines = File.ReadAllLines(GivenFile);
        //Console.WriteLine(text);

        int Count = 0;

        await Task.Run(() =>
        {
            foreach (var line in lines)
            {
                //Console.WriteLine(line);
                if (line.Contains("[Error]"))
                {
                    Count += 1;
                }
                //break;
            }
            Console.WriteLine("{0} contains : {1}", GivenFile, Count);
        });
    }

   
}


    