using System;
using System.Diagnostics;

namespace Utility;

public static class TimeCalculator
{
    public static void Calculate(Action func,string Method)
    {
        
        var stopwatch = new Stopwatch();
        stopwatch.Start(); 
        func();
        stopwatch.Stop();
        var timeSpan = stopwatch.Elapsed;
        string elapsedTime = String.Format("{0:00}:{1:00}:{2:0000}",timeSpan.Seconds,timeSpan.Milliseconds,timeSpan.Microseconds);
        Console.WriteLine($"{Method} runtime: {elapsedTime}");
    }
}