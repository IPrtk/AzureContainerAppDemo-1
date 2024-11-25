// See https://aka.ms/new-console-template for more information

using Microsoft.Extensions.Logging;

using ILoggerFactory factory = LoggerFactory.Create(builder =>
{
    builder.SetMinimumLevel(LogLevel.Trace);
});
ILogger logger = factory.CreateLogger("Program");

Console.WriteLine("Hello, World!");
MyMethod();

void MyMethod()
{
    logger.LogError("Hello World! Logging is {Description}.", "fun");
}
