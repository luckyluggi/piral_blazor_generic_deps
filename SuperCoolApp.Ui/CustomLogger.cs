using System;
public class CustomLogger<T>
{
    public void Log()
    {
        Console.WriteLine(typeof(T).Name); 
    }
}