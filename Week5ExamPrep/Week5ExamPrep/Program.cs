using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5ExamPrep
{
    class Program
    {
        class Animal { }
        class Frog : Animal { }
        static void Speak(object obj) { Console.WriteLine("In Speak(object)"); }
        static void Speak(Animal a) { Console.WriteLine("In Speak(Animal)"); }
        static void Speak(Frog f) { Console.WriteLine("In Speak(Frog)"); }

        static void Main(string[] args)
        {
            object f = new Frog();
            Speak(f);

            BaseLogger logger = new Logger();
            logger.Log("Log started");
            logger.Log("Base: Log continuing");
            ((Logger)logger).LogCompleted();
        }
    }

    public abstract class BaseLogger
    {
        public virtual void Log(string message)
        {
            Console.WriteLine("Base: " + message);
        }

        public void LogCompleted()
        {
            Console.WriteLine("Completed");
        }
    }

    public class Logger : BaseLogger
    {
        public override void Log(string message)
        {
            Console.WriteLine(message);
        }

        public new void LogCompleted()
        {
            Console.WriteLine("Finished");
        }
    }

}
