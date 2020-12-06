using System;
using static System.Console;
namespace EnumType
{
    class Program
    {
        static void Main(string[] args)
        {
            Person ashiq = new Person();
            ashiq.Name = "Ashiq";
            ashiq.Hobby = Hobby.Traveling | Hobby.Gardening;

            WriteLine($"{ashiq.Name} likes to do {ashiq.Hobby} ");
        }
    }
    public class Person{
        public string Name { get; set; }
        public Hobby Hobby{get;set;}
    }
    [System.Flags]
    public enum Hobby{
        Reading = 1,
        Gardening = 2,
        Traveling = 3
    }
}
