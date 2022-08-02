using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountErrorAsync
{
    internal class AsyncClass
    {

        public static async Task ReadTheFile(string Files)
        {
            int Count = await CountOccurence(Files);
            Console.WriteLine("{0} contains : {1}", Files, Count);

            await AsyncClass.DeleteTheFile(Files);

        }

        public static async Task DeleteTheFile(string Files)
        {
            int Count = await CountOccurence(Files);
            if (Count > 50)
            {
                //Console.WriteLine("*****for {0} got count={1}", Files,Count);
                File.Delete(Files);
                Console.WriteLine("ATTENTION!! File {0} -- is deleted with [ERROR] Count = {1}", Files, Count);

            }
            else if (Count > 20 && Count < 50)
            {
                System.IO.File.WriteAllText(Files, string.Empty);
            }
        }

        public static async Task<int> CountOccurence(string Files)
        {
            string[] lines = File.ReadAllLines(Files);
            //Console.WriteLine(text);

            int Count = 0;

            foreach (var line in lines)
            {
                //Console.WriteLine(line);
                if (line.Contains("[Error]"))
                {
                    Count += 1;
                }
                //break;


            }
            return Count;
        }
        
            
        



    }
}
