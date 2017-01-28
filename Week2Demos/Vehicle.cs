using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Demos
{
    public abstract class Vehicle
    {
        //public string name;

        public Vehicle()
        { }

        public Vehicle(string name)
        {
            this.Name = name;
        }

        public string Name { private get; set; }

        //public string DisplayName => Name;

        public virtual void Start()
        {
            Console.WriteLine("Default start behavior");
        }

        public void Start(bool hasKey)
        {
            if (hasKey)
            {
                Console.WriteLine("Starting");
                return;
            }

            Console.WriteLine("Go  away");
        }
    }
}
