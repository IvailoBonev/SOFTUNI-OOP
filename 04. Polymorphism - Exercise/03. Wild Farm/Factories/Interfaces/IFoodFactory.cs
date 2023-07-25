using _04.WildFarm.Models.Foods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.WildFarm.Factories.Interfaces
{
    public interface IFoodFactory
    {
        public Food CreateFood(string type, int quantity);
    }
}
