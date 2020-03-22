using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresPreYPost
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = ++a;
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine();
            int c = 3;
            int d = c++;
            Console.WriteLine($"c = {c}");
            Console.WriteLine($"d = {d}");
        }
    }
}
