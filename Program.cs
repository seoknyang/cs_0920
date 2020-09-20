using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            Console.Write("더하기:");
            Console.WriteLine(a+b);
            Console.Write("빼기:");
            Console.WriteLine(a - b);
            Console.Write("곱하기:");
            Console.WriteLine(a * b);
            Console.Write("나누기");
            Console.WriteLine(a / (float)b);
        }

    }
}
