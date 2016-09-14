using System;

namespace NetMentoring
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var memoryStreamLogger = new MemoryStreamLogger())
            {
                for (var i = 0; i < 100000; i++)
                    memoryStreamLogger.Log("Interation number #" + i);
            }
            Console.WriteLine("Finished");
            Console.ReadKey();
        }
    }
}
