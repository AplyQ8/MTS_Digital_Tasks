﻿using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


class Program
{
    private static int lineCount = 0;
    private static StringBuilder output = new StringBuilder();

    public static void Main()
    {
        Process process = new Process();
        process.StartInfo.FileName = "ipconfig.exe";
        //process.StartInfo.UseShellExecute = false;
        //process.StartInfo.RedirectStandardOutput = true;
        process.OutputDataReceived += new DataReceivedEventHandler((sender, e) =>
        {
            // Prepend line numbers to each line of the output.
            if (!String.IsNullOrEmpty(e.Data))
            {
                lineCount++;
                output.Append("\n[" + lineCount + "]: " + e.Data);
            }
        });

        
        process.Start();

        // Asynchronously read the standard output of the spawned process.
        // This raises OutputDataReceived events for each line of output.
        process.BeginOutputReadLine();
        process.WaitForExit();

        // Write the redirected output to this application's window.
        Console.WriteLine(output);

        process.WaitForExit();
        process.Close();

        Console.WriteLine("\nPress any key to exit.");
        Console.ReadLine();
    }
}