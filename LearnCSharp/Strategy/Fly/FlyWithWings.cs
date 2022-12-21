namespace LearnCSharp.Strategy.Fly;

public class FlyWithWings : IFlyBehavior
{
    public string Fly()
    {
        Console.WriteLine("Fly with wings");
        return "Fly with wings";
    }
}