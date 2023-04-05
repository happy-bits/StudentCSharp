namespace CSharpCourse.Interfaces.Ex01;

public class Solution_WithoutInterfaces
{
    class ConsoleLogger
    {
        public void Log(string message)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message);
        }
    }

    class FileLogger
    {
        public void Log(string message)
        {
            File.AppendAllLines(@"C:\TMP\loggfile.txt", new[] { message });
        }
    }

    class DetailedFileLogger
    {
        public void Log(string message)
        {
            File.AppendAllLines(@"C:\TMP\loggfile.txt", new[] { $"{DateTime.Now}\t{message}" });
        }
    }

    static void DivideTwoNumbers_FileLog(FileLogger filelogger, decimal a, decimal b)
    {

        filelogger.Log("DivideTwoNumbers started!");
        filelogger.Log($"a={a} and b={b}");

        decimal result = a / b;

        filelogger.Log($"Result of calculation: {result}");
        filelogger.Log("DivideTwoNumbers finished!");
    }

    static void DivideTwoNumbers_ConsoleLog(ConsoleLogger consolelogger, decimal a, decimal b)
    {
        consolelogger.Log("DivideTwoNumbers started!");
        consolelogger.Log($"a={a} and b={b}");

        decimal result = a / b;

        consolelogger.Log($"Result of calculation: {result}");
        consolelogger.Log("DivideTwoNumbers finished!");
    }

    static void DivideTwoNumbers_DetailedFileLog(DetailedFileLogger detailed, decimal a, decimal b)
    {

        detailed.Log("DivideTwoNumbers started!");
        detailed.Log($"a={a} and b={b}");

        decimal result = a / b;

        detailed.Log($"Result of calculation: {result}");
        detailed.Log("DivideTwoNumbers finished!");
    }

    public static void Run()
    {
        string loggerchoice = File.ReadAllText(@"Interfaces\Ex02\loggerchoice.txt");

        switch (loggerchoice)
        {
            case "File":
                DivideTwoNumbers_FileLog(new FileLogger(), 4, 10);
                break;
            case "Console":
                DivideTwoNumbers_ConsoleLog(new ConsoleLogger(), 4, 10);
                break;
            case "Detailed":
                DivideTwoNumbers_DetailedFileLog(new DetailedFileLogger(), 4, 10);
                break;
            default:
                throw new Exception($"Okänd logger: {loggerchoice}");

        }

    }

}
