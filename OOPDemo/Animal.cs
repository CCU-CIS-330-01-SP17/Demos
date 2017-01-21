using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo
{
    class Animal
    {
        private int height;

        public int Height
        {
            get
            {
                return height;
            }
        }

        public virtual void Eat()
        {
            Console.WriteLine("Yum yum!");
        }
    }
}
