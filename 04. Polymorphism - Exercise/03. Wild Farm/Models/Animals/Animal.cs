using _04.WildFarm.Models.Foods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.WildFarm.Models.Animals
{
    public abstract class Animal
    {
        protected Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public string Name { get; private set; }
        public double Weight { get; private set; }
        public int FoodEaten { get; set; }

        protected abstract double WeightMultiplier { get; }

        protected abstract IReadOnlyCollection<Type> PreferredFoodTypes { get; }
        public abstract string ProduceSound();

        public void Eat(Food food)
        {
            if (!PreferredFoodTypes.Any(pf => food.GetType().Name == pf.Name))
            {
                throw new ArgumentException($"{GetType().Name} does not eat {food.GetType().Name}!");
            }

            Weight += food.Quantity * WeightMultiplier;

            FoodEaten += food.Quantity;
        }

        public override string ToString()
        => $"{GetType().Name} [{Name}, ";
    }
}
