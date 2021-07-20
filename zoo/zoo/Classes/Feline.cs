using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoo.Classes
{
    public abstract class Feline : Mammals
    {
        public abstract string tailLength { get; set; }
        public virtual string diet { get; set; } = "carnivorous";
        public abstract string size { get; set; };

    }
}
