namespace LearnCSharp.Strategy.Fly;

public class FlyWithRocket : IFlyBehavior
{
    public string Fly()
    {
        return "Fly with Rocket";
    }
}