using System;
using System.Collections.Generic;
using System.Text;

namespace Benchmark
{
    public class Printer
    {
        public async void Print()
        {
            try
            {
                Requestmaker.GetResponse().GetAwaiter().GetResult();
            }
            catch
            {
                Console.WriteLine("Shits fucked");
            }
            Console.WriteLine();
        }
    }
}
