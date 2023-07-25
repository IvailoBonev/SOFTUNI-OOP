

using _4.BorderControl;

List<Citizen> citizens = new List<Citizen>();
List<Rebel> rebels = new List<Rebel>();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] inputTokens = Console.ReadLine()
        .Split(' ', StringSplitOptions.RemoveEmptyEntries);

    switch (inputTokens.Length)
    {
        case 4:
            Citizen citizen = new(inputTokens[0], int.Parse(inputTokens[1]), inputTokens[2], inputTokens[3]);
            citizens.Add(citizen);
            break;
        case 3:
            Rebel rebel = new(inputTokens[0], int.Parse(inputTokens[1]), inputTokens[2]);
            rebels.Add(rebel);
            break;
    }
}

string input;
int totalFood = 0;

while ((input = Console.ReadLine()) != "End")
{
    if (citizens.FirstOrDefault(x => x.Name == input) == null 
        && rebels.FirstOrDefault(x => x.Name == input) == null)
    {
        continue;
    }
    else if (citizens.FirstOrDefault(x => x.Name == input) == null)
    {
        IBuyer buyer = rebels.FirstOrDefault(x => x.Name == input);

        buyer.BuyFood();
        totalFood += 5;
    }
    else
    {
        IBuyer buyer = citizens.FirstOrDefault(x => x.Name == input);

        buyer.BuyFood();
        totalFood += 10;
    }
}

Console.WriteLine(totalFood);