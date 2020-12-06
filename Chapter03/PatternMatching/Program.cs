using System;
using System.IO;
using static System.Console;
using static System.Convert;
using static System.Math;

namespace PatternMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Directory.GetCurrentDirectory();
            Stream s = File.Open(Path.Combine(path,"my_file.txt"), FileMode.OpenOrCreate);
            // string msg = string.Empty;
            // switch(s){
            //     case FileStream writeableFile when s.CanWrite:
            //         msg ="Writeable";
            //         break;
            //     case FileStream readOonlyFile when s.CanRead:
            //         msg = "Read able";
            //         break;
            //     case MemoryStream memoryStream:
            //         msg = "The stram is a memory stream";
            //         break;
            //     default:
            //         msg = "The stream is other type";
            //         break;
            //     case null:
            //         msg = "The stream is null";
            //         break;
            // }
            
            string msg = s switch{
                FileStream writableFile when s.CanWrite=>"This file can be write",
                FileStream readOnly when s.CanRead=>"This file is read only",
                MemoryStream ms=>"This is memory stream",
                null=>"Stream is null",
                _=>"The stream is other type"
            };
            WriteLine(msg);
            s.Close();

            WriteLine(ToInt16(9.4));  //9
            WriteLine(Round(9.5,0,MidpointRounding.AwayFromZero));  //10
            WriteLine(ToInt16(9.6));  //10
            WriteLine(ToInt16(10.4)); //10
            WriteLine(Round(10.5,0,MidpointRounding.AwayFromZero)); //11
            WriteLine(ToInt16(10.6)); //11

        }
    }
}
