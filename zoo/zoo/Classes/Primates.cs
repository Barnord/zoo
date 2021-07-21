using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zoo.Interfaces;

namespace zoo.Classes
{
    public abstract class Primates : Mammals
    {
        public virtual bool opposableThumbs { get; set; } = true;
        public virtual string diet { get; set; } = "omnivores";
        public abstract bool hasTail { get; set; }
        public override int legs { get; set; } = 2;
    }
}
