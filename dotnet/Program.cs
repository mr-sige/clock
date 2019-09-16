using System;
using System.Threading;
namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var today = DateTime.Today.ToString("yyyy.MM.");
                var time = DateTime.Now.ToString("HH: mm: ss");
                Console.Clear();
                Console.WriteLine("{0} {1}", today, time);
                Thread.Sleep(1000);
            }
        }
    }
}