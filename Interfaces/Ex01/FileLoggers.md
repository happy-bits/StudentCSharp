# FileLoggers

## Without interfaces

First you will create an app that *don't* use interfaces.

Create an app that read a textfile *loggerchoice.txt* and depending on the content of the file create one of the following loggers:
- FileLogger
- ConsoleLogger
- DetailedFileLogger

...and call one of the following methods:
- DivideTwoNumbers_FileLogger
- DivideTwoNumbers_ConsoleLogger
- DivideTwoNumbers_DetailedFileLogger

See below:

	public void Run()
	{
		string loggerchoice = File.ReadAllText(@"Interfaces\loggerchoice.txt");

		switch (loggerchoice)
		{
			case "File":
				DivideTwoNumbers_FileLogger(new FileLogger(), 4, 10);
				break;
			case "Console":
				DivideTwoNumbers_ConsoleLogger(new ConsoleLogger(), 4, 10);
				break;
			case "Detailed":
				DivideTwoNumbers_DetailedFileLogger(new DetailedFileLogger(), 4, 10);
				break;
			default:
				throw new Exception($"Okänd logger: {loggerchoice}");
		}
	}

The implementation of *DivideTwoNumbers_FileLogger* should look like this:

    void DivideTwoNumbers_FileLogger(FileLogger filelogger, decimal a, decimal b)
    {

        filelogger.Log("DivideTwoNumbers started!");
        filelogger.Log($"a={a} and b={b}");

        decimal result = a / b;

        filelogger.Log($"Result of calculation: {result}");
        filelogger.Log("DivideTwoNumbers finished!");
    }

The other methods should work in similair ways.

### With Interfaces

Now create a (better) solution with interfaces.

Create an interface *ILog* and just one method *DivideTwoNumbers*, so the following code will work:

	public void Run_WithInterface()
	{
		string loggerchoice = File.ReadAllText(@"Interfaces\loggerchoice.txt");

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

Now you just need one method *DivideTwoNumbers* (instead of three very similair methods)