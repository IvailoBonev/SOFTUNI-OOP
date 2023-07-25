using _04.WildFarm.Models.Foods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.WildFarm.Models.Animals.Mammals.Feline
{
    public class Tiger : Feline
    {
        private const double TigerWeightMultiplier = 1.0;

        public Tiger(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        protected override double WeightMultiplier 
            => TigerWeightMultiplier;

        protected override IReadOnlyCollection<Type> PreferredFoodTypes 
            => new HashSet<Type>() { typeof(Meat) };

        public override string ProduceSound()
            => "ROAR!!!";
    }
}
