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
            Console.WriteLine("Inizializamos a = 3, b = ++a");
            int a = 3;
            int b = ++a;
            Console.WriteLine("Resultado:");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine();

            Console.WriteLine("Inizializamos c = 3, d = c++");
            int c = 3;
            int d = c++;
            Console.WriteLine("Resultado:");
            Console.WriteLine($"c = {c}");
            Console.WriteLine($"d = {d}");
        }
    }
}
