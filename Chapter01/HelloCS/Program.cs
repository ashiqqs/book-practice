#nullable enable
using System;
using static System.Console;
using System.Globalization;
using static TypeCount;
namespace HelloCS
{
    class Program
    {
        static void Main(string[] args)
        {
            TypeCount typeCount = new TypeCount(){
                Name = null
            };
            ShowAllType();
            //Console.WriteLine(typeCount);
            WriteLine(Convert.ToString(10,16));
            //typeCount.ShowAllType();
        }
    }
}
