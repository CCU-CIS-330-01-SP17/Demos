using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        delegate bool HypothesisTester(Hypothesis h);

        static void Main(string[] args)
        {
            RunTest(VolcanoScienceProject);
        }

        static bool VolcanoScienceProject(Hypothesis h)
        {
            return false;
        }

        static bool RunTest(HypothesisTester tester)
        {
            tester(new Hypothesis());
            return true;
        }
    }
}
