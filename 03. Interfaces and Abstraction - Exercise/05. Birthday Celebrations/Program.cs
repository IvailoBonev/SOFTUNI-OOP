

using _4.BorderControl;

List<Citizen> citizens = new List<Citizen>();
List<Robot> robots = new List<Robot>();
List<Pet> pets = new List<Pet>();

string input;
while ((input = Console.ReadLine()) != "End")
{
    string[] tokens = input.Split();

    switch (tokens[0])
    {
        case "Citizen":
            Citizen citizen = new(tokens[1], int.Parse(tokens[2]), tokens[3], tokens[4]);
            citizens.Add(citizen);
            break;
        case "Robot":
            Robot robot = new(tokens[1], tokens[2]);
            robots.Add(robot);
            break;
        case "Pet":
            Pet pet = new(tokens[1], tokens[2]);
            pets.Add(pet);
            break;
    }
}

string endInput =  Console.ReadLine();

foreach (var citizen in citizens)
{
    if (citizen.BirthDate.EndsWith(endInput))
    {
        Console.WriteLine(citizen.BirthDate.TrimEnd());
    }
}

foreach (var pet in pets)
{
    if (pet.BirthDate.EndsWith(endInput))
    {
        Console.WriteLine(pet.BirthDate.TrimEnd());
    }
}