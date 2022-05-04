using System;

namespace Benchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            new Requestmaker();
            printer.Print();
        }
    }
}
