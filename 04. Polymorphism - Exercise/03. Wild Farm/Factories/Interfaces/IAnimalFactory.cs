using _04.WildFarm.Models.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.WildFarm.Factories.Interfaces
{
    public interface IAnimalFactory
    {
        public Animal CreateAnimal(string[] animalTokens);
    }
}
