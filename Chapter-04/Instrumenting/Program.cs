using Microsoft.Extensions.Configuration;
using System.Diagnostics;

//Define log path
string logPath = "log.txt";

WriteLine($"Writing to: {logPath}");

//Create log file
TextWriterTraceListener logFile = new(File.CreateText(logPath));

//Listeners file
Trace.Listeners.Add(logFile);

//Text writer is buffered, so this option calls
//Flush() on all listeners after writing
Trace.AutoFlush = true;

//Debug.WriteLine("Debug says, I am watching!");
//Trace.WriteLine("Trace says, I am watching!");

WriteLine($"Reading from appsettings.json in {Directory.GetCurrentDirectory()}");

ConfigurationBuilder builder = new();

builder.SetBasePath(Directory.GetCurrentDirectory());

builder.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

IConfigurationRoot configuration = builder.Build();

TraceSwitch ts = new("PacktSwitch", "This switch is set a JSON  config.");

configuration.GetSection("PacktSwitch").Bind(ts);

WriteLine($"{ts.Level}");

//Trace.TraceInformation("Configuration working ...");
//Trace.TraceInformation("Thread working ...");
//Trace.TraceWarning("Warning variable name is empty");
//Trace.TraceInformation("System Status - Ok");
//Trace.WriteLine("Trace Verbose");
//Trace.TraceError("Error: Update files");


Trace.WriteLineIf(ts.TraceInfo, "Configuration working ...");
Trace.WriteLineIf(ts.TraceInfo, "Thread working ...");
Trace.WriteLineIf(ts.TraceWarning, "Warning variable name is empty");
Trace.WriteLineIf(ts.TraceInfo, "System Status - Ok");
Trace.WriteLineIf(ts.TraceVerbose, "Trace Verbose");
Trace.WriteLineIf(ts.TraceError, "Error: Update files");

Trace.WriteLineIf(ts.TraceVerbose, "Trace verbose");
int unitsInStock = 12;
LogSourceDetails(unitsInStock > 10);

Console.ReadLine();