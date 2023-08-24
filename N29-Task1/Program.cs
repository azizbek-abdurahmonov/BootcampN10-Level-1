using System.Diagnostics;

class Program
{
    static void Main()
    {
        var watch = Stopwatch.StartNew();
        
        // Test without Thread
        // DoWork();
        // DoWork();
        
        //New method
        var t1 = new Thread(DoWork);
        var t2 = new Thread(DoWork);
        
        t1.Start();
        t2.Start();
        
        Console.WriteLine(t2.Priority);

        t1.Join();
        t2.Join();
        
        
        watch.Stop();

        Console.WriteLine($"Take {watch.Elapsed.Seconds} seconds");

    }

    static void DoWork()
    {
        Console.WriteLine("Do working");
        Thread.Sleep(1000);
        Console.WriteLine("Working end\n");
    }
}
