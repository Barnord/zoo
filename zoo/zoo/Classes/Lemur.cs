using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoo.Classes
{
    class Lemur : Primates
    {
        public override bool hasTail { get; set; } = true;

        public override void Call()
        {
            Console.WriteLine("Lemur's like to hoot and howl and stuff.");
        }

        public override void Sleep()
        {
            Console.WriteLine("Lemur's sleep half the night alone, and half the night in groups. Or something.");
        }
    }
}
