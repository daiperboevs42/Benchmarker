using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Benchmark
{
    public class Printer
    {
        public async void Print()
        {
            try
            {
                Console.WriteLine("Press C for CANCEL, if you dare!");
                Console.WriteLine("Write a number of calls you want to make!");
                int numberCount = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < numberCount; i++)
                    Requestmaker.GetResponse().GetAwaiter().GetResult();
            }
            catch
            {
                Console.WriteLine("Shits fucked");
            }
            var key = Console.ReadKey();
            var cancellationTokenSource = new CancellationTokenSource();
            if ( key.Key == ConsoleKey.C)
            {
                // Cancel the task upon click
                cancellationTokenSource.Cancel();
                System.Console.WriteLine("Number of times called: {0}", Requestmaker.numberOfinvokes);
            }
          


        }
    }
}
