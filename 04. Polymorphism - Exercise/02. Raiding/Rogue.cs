using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Raiding
{
    public class Rogue : BaseHero
    {
        public Rogue(string name) : base(name)
        {
            Name = name;
            Power = 80;
        }

        public override void CastAbility()
        {
            Console.WriteLine($"{GetType().Name} - {Name} hit for {Power} damage");
        }
    }
}
