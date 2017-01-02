using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPillars
{
    class Program
    {
        static void Main(string[] args)
        {
            Giraffe g = new Giraffe();
            g.NumberOfLegs = 4;
            g.Speak();
            Console.WriteLine(g.NumberOfLegs);

            Animal a = GetAnimalFromBarn();
            a.Speak();
        }

        static Animal GetAnimalFromBarn()
        {
            return new Giraffe();
        }
    }
}
