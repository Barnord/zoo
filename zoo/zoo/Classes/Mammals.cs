using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoo.Classes
{
    public abstract class Mammals
    {
        public virtual bool airBreathing { get; set; } = true;
        public virtual bool liveBirth { get; set; } = true;
        public abstract int legs { get; set; }

        public abstract void Sleep();
        public abstract void Call();
        public virtual void Eat()
        {
            Console.Write("This critter eats ");
        }
    }
}
