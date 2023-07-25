

using _4.BorderControl;

List<Citizen> citizens = new List<Citizen>();
List<Robot> robots = new List<Robot>();

string input;
while ((input = Console.ReadLine()) != "End")
{
    string[] tokens = input.Split();

    if (tokens.Length == 3 )
    {
        Citizen citizen = new(tokens[0], int.Parse(tokens[1]), tokens[2]);
        citizens.Add(citizen);
    }
    else if (tokens.Length == 2 )
    {
        Robot robot = new(tokens[0], tokens[1]);
        robots.Add(robot);
    }
}

string endInput =  Console.ReadLine();

foreach (var robot in robots)
{
    if (robot.Id.EndsWith(endInput))
    {
        Console.WriteLine(robot.Id.TrimEnd());
    }
}

foreach (var citizen in citizens)
{
    if (citizen.Id.EndsWith(endInput))
    {
        Console.WriteLine(citizen.Id.TrimEnd());
    }
}