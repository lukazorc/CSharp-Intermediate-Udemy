using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new StopWatch();
            Debug.WriteLine("Enter 1 to start stopwatch, 2 to stop stopwatch");
            Debug.WriteLine("Enter your choice");

            while (true)
            {
                var userInput = Console.ReadLine();


                int input;
                if (!int.TryParse(userInput, out input)) continue;
                switch (input)
                {
                    case 1:
                        stopWatch.Start();
                        break;
                    case 2:
                        var a = stopWatch.Stop();
                        Debug.WriteLine(a);
                        break;
                    default:
                        Debug.WriteLine("Invalid input!!");
                        break;
                }
            }

        }
    }
}
