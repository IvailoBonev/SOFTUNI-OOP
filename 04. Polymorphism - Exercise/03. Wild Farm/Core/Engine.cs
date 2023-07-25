using _04.WildFarm.Core.Interfaces;
using _04.WildFarm.Factories.Interfaces;
using _04.WildFarm.IO.Interfaces;
using _04.WildFarm.Models.Animals;
using _04.WildFarm.Models.Foods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.WildFarm.Core
{
    public class Engine : IEngine
    {
        IWriter writer;
        IReader reader;
        IAnimalFactory animalFactory;
        IFoodFactory foodFactory;

        private List<Animal> animals;

        public Engine(IWriter writer, IReader reader, IFoodFactory foodFactory, IAnimalFactory animalFactory)
        {
            this.writer = writer;
            this.reader = reader;
            this.foodFactory = foodFactory;
            this.animalFactory = animalFactory;

            animals = new();
        }

        public void Run()
        {
            string input;
            while ((input = reader.ReadLine()) != "End")
            {
                string[] animalTokens = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string[] foodTokens = reader.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Animal animal = animalFactory.CreateAnimal(animalTokens);
                Food food = foodFactory.CreateFood(foodTokens[0], int.Parse(foodTokens[1]));


                writer.WriteLine(animal.ProduceSound());

                try
                {
                    animal.Eat(food);
                }
                catch (ArgumentException ex)
                {
                    writer.WriteLine(ex.Message);
                }

                animals.Add(animal);
            }

            foreach (Animal animal in animals)
            {
                writer.WriteLine(animal);
            }
        }
    }
}
