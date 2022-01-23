using System;
using System.IO;

namespace UpdateBuildDatetime
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("You must provide a path to a file to write to");
                Environment.Exit(1);
            }
            File.WriteAllText(args[0], DateTime.UtcNow.ToString("MM-dd-yyyy HH:mm:ss"));
        }
    }
}