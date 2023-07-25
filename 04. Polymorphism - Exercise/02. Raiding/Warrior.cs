using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Raiding
{
    public class Warrior : BaseHero
    {
        public Warrior(string name) : base(name)
        {
            Name = name;
            Power = 100;
        }

        public override void CastAbility()
        {
            Console.WriteLine($"{GetType().Name} - {Name} hit for {Power} damage");
        }
    }
}
