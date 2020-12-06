using System;

namespace Tuples
{
    class Program
    {
        public string Name=>"Ashiq";
        public static  (string Name, int Price) GetItems(){
            return (Name: "Apples", Price:150);
        }
        public Program this[int index]{
            get{
                return Name;
            }
            set{

            }
        }
        static void Main(string[] args)
        {
            (string Name, int Price) item = GetItems();
            var c = ("ashiq",5);
            Console.WriteLine($"Name:{c.Item1} Price: {c.Item2}");
        }
    }
}
