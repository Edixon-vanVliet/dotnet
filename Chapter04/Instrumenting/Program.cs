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
            // write to a text file in the project folder
            Trace.Listeners.Add(
                new TextWriterTraceListener(File.CreateText("log.txt"))
            );

            // writer is buffered, so this option calls
            // Flush() on all listeners after writing
            Trace.AutoFlush = true;

            Debug.WriteLine("Debug says, I am watching!");
            Trace.WriteLine("Trace says, I am watching!");

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true);

            IConfigurationRoot configuration = builder.Build();

            var ts = new TraceSwitch(
                "PacktSwitch",
                "This switch is set via a JSON config."
            );

            configuration.GetSection("PacktSwitch").Bind(ts);

            Trace.WriteLine(ts.TraceError, "Trace error");
            Trace.WriteLine(ts.TraceWarning, "Trace warning");
            Trace.WriteLine(ts.TraceInfo, "Trace info");
            Trace.WriteLine(ts.TraceVerbose, "Trace verbose");
        }
    }
}
