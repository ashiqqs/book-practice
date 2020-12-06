using System;
using System.Diagnostics;
using System.IO;
using Microsoft.Extensions.Configuration;
namespace Instrumenting
{
    class Program
    {
        static void Main(string[] args)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(File.CreateText("log.txt")));
            Trace.AutoFlush = true;

            Debug.WriteLine("Debug says, I am watching");
            Trace.WriteLine("Trace says, I am watching");

            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json",optional:true, reloadOnChange:true);

            IConfiguration configuration = builder.Build();

            var ts = new TraceSwitch(
                displayName:"PackateSwitch",
                description:"This switch is set via a json file"
            );

            configuration.GetSection("PackSwitch").Bind(ts);

            Trace.WriteLineIf(ts.TraceError,"Trace Error");
            Trace.WriteLineIf(ts.TraceWarning, "Trace Warning");
            Trace.WriteLineIf(ts.TraceInfo, "Trace Information");
            Trace.WriteLineIf(ts.TraceVerbose,"Trace verbose");

        }
    }
}
