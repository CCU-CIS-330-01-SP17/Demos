using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterKeywords
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 2;
            //int result;

            Console.WriteLine(value);
            Square(value);
            Console.WriteLine(value);

            //Console.WriteLine(result);
        }

        static void Square(int x)
        {
            x *= x;
        }

        static void Square(int x, out int y)
        {
            y = x * x;
        }
    }
}
