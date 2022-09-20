using System;
using System.Diagnostics;
using System.Net.Mime;
using System.Runtime.CompilerServices;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            FailProcess();
        }
        catch
        {
        }

        Console.WriteLine("Failed to fail Process!");
        Console.ReadKey();
    }
    static void FailProcess()
    {
        Process.GetCurrentProcess().Kill(); // 1 вариант
        Environment.Exit(0); // 2 вариант
        Environment.FailFast(""); // 3 вариант
        
        
    }
}