

using _3.Raiding;

int n = int.Parse(Console.ReadLine());
List<BaseHero> raid = new();

for (int i = 0; i < n; i++)
{
    string name = Console.ReadLine();
    string type = Console.ReadLine();

    BaseHero hero;

    switch (type)
    {
        case "Druid":
            hero = new Druid(name);
            break;
        case "Paladin":
            hero = new Paladin(name);
            break;
        case "Rogue":
            hero = new Rogue(name);
            break;
        case "Warrior":
            hero = new Warrior(name);
            break;
        default:
            Console.WriteLine("Invalid hero!");
            i--;
            continue;
    }

    raid.Add(hero);
}

int bossPower = int.Parse(Console.ReadLine());
int sumPower = 0;

foreach (BaseHero hero in raid)
{
    hero.CastAbility();
    sumPower += hero.Power;
}

if (sumPower >= bossPower)
{
    Console.WriteLine("Victory!");
}
else
{
    Console.WriteLine("Defeat...");
}