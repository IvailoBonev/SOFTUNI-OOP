using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Raiding
{
    public abstract class BaseHero
    {
        public BaseHero(string name)
        {
            Name = name;
        }
        public string Name { get; protected set; }
        public int Power { get; protected set; }

        public abstract void CastAbility();
    }
}
