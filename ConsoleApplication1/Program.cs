extern alias ex;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    using static ex::EnumerableEx;

    class Program
    {
        static void Main(string[] args)
        {
            //ex::EnumerableEx.ZipFull("", "", (a, b) => a + b);

            var arr = new[] { "233" }.Hide();

            //arr = arr.ZipFull(arr, (a, b) => a + b).ToArray();

            Console.WriteLine(args.SequenceEqual(arr));
            Console.WriteLine(arr.SequenceEqual(arr));
            Console.WriteLine(arr.SequenceEqual(args));

            EnumerableEx.Do(args, _ => { });

            //Enumerable.Zip()

            //args.Zip(args, (a, b) => 0);
        }
    }
}
