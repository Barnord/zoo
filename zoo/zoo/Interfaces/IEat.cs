using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoo.Interfaces
{
    interface IEat
    {
        bool Hungry { get; set; }
        bool HasFood { get; set; }
        bool Bloated { get; set; }
        void FindFood()
        {
            if (HasFood == false)
            {
                HasFood = true;
            }
        }
        void EatFood()
        {
            if (Hungry == true && Bloated == false)
            {
                Hungry = false;
            }
            else
            {
                Bloated = true;
            }
        }
        void ProduceWaste()
        {
            if (Bloated == true)
            {
                Hungry = false;
                Bloated = false;
            }
            else
            {
                Hungry = true;
            }
        }

    }
}
