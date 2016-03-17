
using System;
/// <summary>
/// 
/// Dependency Injection (DI) is a design pattern that demonstrates how to create loosely coupled classes
/// </summary>

class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student(new Logger1());
        Student student2 = new Student(new Logger2());
    }
}

public class Student
{
    public Student(Ilogger logger)
    {
        logger.WriteLog("New student created");
    }
}

public interface Ilogger
{
    void WriteLog(string text);
}

class Logger1 : Ilogger
{
    public void WriteLog(string text)
    {
        Console.WriteLine("{0} from logger1", text);
    }
}

class Logger2 : Ilogger
{
    public void WriteLog(string text)
    {
        Console.WriteLine("{0} from logger2", text);
    }
}