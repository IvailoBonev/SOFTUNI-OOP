using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Raiding
{
    public class Druid : BaseHero
    {
        public Druid(string name) : base(name)
        {
            Name = name;
            Power = 80;
        }

        public override void CastAbility()
        {
            Console.WriteLine($"{GetType().Name} - {Name} healed for {Power}");
        }
    }
}
