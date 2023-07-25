

using _04.WildFarm.Core;
using _04.WildFarm.Factories;
using _04.WildFarm.Factories.Interfaces;
using _04.WildFarm.IO;
using _04.WildFarm.IO.Interfaces;

IWriter writer = new ConsoleWriter();
IReader reader = new ConsoleReader();
IAnimalFactory animalFactory = new AnimalFactory();
IFoodFactory foodFactory = new FoodFactory();

Engine engine = new(writer, reader, foodFactory, animalFactory);
engine.Run();