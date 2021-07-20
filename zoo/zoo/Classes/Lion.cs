using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoo.Classes
{
    class Lion : Feline
    {
        public override string tailLength { get; set; } = "medium";
        public override string size { get; set; } = "large";

        public override void Call()
        {
            Console.WriteLine("Lions roar!");
        }

        public override void Sleep()
        {
            Console.WriteLine("Lions sleep between 16 and 20 hours each day!");
        }
    }
}
