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
                for (int i = 0; i < 5; i++)
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
                // Cancel the task 
                cancellationTokenSource.Cancel();
                System.Console.WriteLine("Number of times called: {0}", ++Requestmaker.numberOfinvokes);
            }

            

        }
    }
}
