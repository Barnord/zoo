using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zoo.Interfaces;

namespace zoo.Classes
{
    public class Gorilla : Primates, IEat, IMature
    {
        public override bool hasTail { get; set; }
        public override void Eat()
        {
            base.Eat();
            Console.Write("mainly stems, bamboo shoots, and fruits, however some will also eat snails, bugs, and grubs!");
        }
        public override void Sleep()
        {
            Console.WriteLine("Gorillas sleep about 12 hours each night.");
        }
        public override void Call()
        {
            Console.WriteLine("Gorilla's have 25 distinct vocalizations that we recognize, including grunts, barks, screams and roars.");
        }
    }
}
