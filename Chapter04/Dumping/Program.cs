using System;
using SharpPad;
using System.Threading.Tasks;
using static System.Console;
namespace Dumping
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var complexObj = new{
                FirstName = "Ashiq",
                BirthDate = new DateTime(year:1999,month:6,day:1),
                Friends = new[]{"Roni","Reshad", "Noman"}
            };
            WriteLine($"Dumping {nameof(complexObj)} to SharpPad.");
            await complexObj.Dump();
        }
    }
}
