using System;

namespace Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int decimalNumber = 1_345_384_256;
            int binaryNumber = 0b_1111;
            int hexaNumber = 0x_AA;
            
            Console.WriteLine(0.1+0.2==0.3); //False
            Console.WriteLine((decimal)(0.1+0.2)==(decimal)0.3); // True
            Console.ReadLine();
        }
    }
}
