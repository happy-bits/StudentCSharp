namespace CSharpCourse.Interfaces.Ex01;

public class Solution
{
    interface ILog
    {
        void Log(string message);
    }

    class ConsoleLogger : ILog
    {
        public void Log(string message)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message);
        }
    }

    class FileLogger : ILog
    {
        public void Log(string message)
        {
            using (var sr = File.AppendText(@"C:\TMP\loggfile.txt"))
            {
                sr.WriteLine(message);
            }
        }
    }

    class DetailedFileLogger : ILog
    {
        public void Log(string message)
        {
            File.AppendAllLines(@"C:\TMP\loggfile.txt", new[] { $"{DateTime.Now}\t{message}" });
        }
    }


    static void DivideTwoNumbers(ILog logger, decimal a, decimal b)
    {
        logger.Log("DivideTwoNumbers started!");
        logger.Log($"a={a} and b={b}");

        decimal result = a / b;

        logger.Log($"Result of calculation: {result}");
        logger.Log("DivideTwoNumbers finished!");
    }

    public static void Run()
    {
        string loggerchoice = File.ReadAllText(@"Interfaces\Ex02\loggerchoice.txt");

        switch (loggerchoice)
        {
            case "File":
                DivideTwoNumbers(new FileLogger(), 4, 10);
                break;
            case "Console":
                DivideTwoNumbers(new ConsoleLogger(), 4, 10);
                break;
            case "Detailed":
                DivideTwoNumbers(new DetailedFileLogger(), 4, 10);
                break;
            default:
                throw new Exception($"Okänd logger: {loggerchoice}");
        }

    }

}
