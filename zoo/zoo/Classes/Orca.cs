using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zoo.Interfaces;

namespace zoo.Classes
{
    public class Orca : Cetaceans, IEat, IMature
    {
        public override void Call()
        {
            Console.WriteLine("OOOOOOOooooooooooOOOOOOOOOOoooooooooo I\'m an orca.");
        }
        public override void Sleep()
        {
            Console.WriteLine("Orca's sleep 1-6 hours every day!");
        }
        public override void Eat()
        {
            base.Eat();
            Console.Write("fish, squid, seals, sea birds, and any other kind of meat it can get into its mouth!");
        }
    }
}
