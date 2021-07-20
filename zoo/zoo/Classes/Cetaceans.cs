using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoo.Classes
{
    public abstract class Cetaceans : Mammals
    {
        public override int legs { get; set; } = 0;
        public virtual bool aquatic { get; set; } = true;
        public virtual string diet { get; set; } = "carnivorous";
    }
    }
}
