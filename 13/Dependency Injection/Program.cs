namespace Dependency_Injection
{
    internal class Program
    {
        //Create an interface ILogger with a method Log(string message).
        //Implement two classes: ConsoleLogger(logs to console) and FileLogger(logs to a file).
        //Create a service class that accepts an ILogger instance via constructor injection and uses it to log messages.
        static void Main(string[] args)
        {
            ILogger consoleLogger = new ConsoleLogger();
            ILogger fileLogger = new FileLogger();

            string message = "New message";

            Service consolelog = new Service(consoleLogger, message);
            Service fileLog = new Service(fileLogger, message); 
        }
    }
}
