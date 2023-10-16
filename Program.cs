using lab4;

class Program
{
    static void Main()
    {
        Ecosystem ecosystem = new Ecosystem();

        ecosystem.AddOrganism(new Animal(100, 5, 2, "Лев", 50));
        ecosystem.AddOrganism(new Animal(80, 8, 1, "Зебра", 60));
        ecosystem.AddOrganism(new Plant(50, 1, 0.5, "Дерево"));
        ecosystem.AddOrganism(new Microorganism(10, 1, 0.01, "Бактерія"));

        ecosystem.SimulateEcosystem();

        Console.ReadLine();
    }
}