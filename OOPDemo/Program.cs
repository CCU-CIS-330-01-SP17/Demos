using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Animal();
            //a.Height = 23;

            Console.WriteLine(a.Height);

            Animal d = new Dog();
            d.Eat();
        }
    }
}
