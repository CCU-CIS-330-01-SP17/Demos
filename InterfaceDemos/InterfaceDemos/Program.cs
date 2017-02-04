using Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Bee();

            DoSomething(a);
        }

        public static void DoSomething(Animal x)
        {
            Ostrich y = x as Ostrich;
            if (y != null)
                y.Sprint();
        }
    }
}
