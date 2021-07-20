using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoo.Classes
{
   public abstract class Marsupials : Mammals
    {
        public virtual bool havePouches { get; set; } = true;
        public virtual string tailLength { get; set; } = "long";
        public abstract string diet { get; set; }
    }
}
