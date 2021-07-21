using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zoo.Interfaces;

namespace zoo.Classes
{
    class Kangaroo : Marsupials, IEat, IMature
    {
        public override string diet { get; set; } = "herbivore";
        public override int legs { get; set; } = 2;

        public override void Call()
        {
            Console.WriteLine("Kangaroos sound like something out of my nightmares. Look it up.");
        }

        public override void Sleep()
        {
            Console.WriteLine("Kangaroos sleep during the day, the internet won't tell me how much.");
        }
    }
}
