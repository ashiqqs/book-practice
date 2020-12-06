
using System;
using static System.Console;
namespace Arguments
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine($"There are {args.Length} Arguments");
            ForegroundColor = (ConsoleColor)Enum.Parse(enumType:typeof(ConsoleColor), value:args[0], ignoreCase:true);
            BackgroundColor = (ConsoleColor)Enum.Parse(enumType:typeof(ConsoleColor),value:args[1], ignoreCase:true);
            WindowWidth = int.Parse(args[3]);
            WindowHeight = int.Parse(args[2]);
            
        }
    }
}
