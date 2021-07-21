using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoo.Interfaces
{
    interface IMature
    {
        int Age { get; set; }
        bool IsMature { get; set; }
        void Birthday()
        {
            Age++;
        }
        void Mate();
        void Die();

    }
}
