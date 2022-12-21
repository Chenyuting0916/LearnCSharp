namespace LearnCSharp.Strategy.Fly;

public class CanNotFly : IFlyBehavior
{
    public string Fly()
    {
        Console.WriteLine("Can't fly");
        return "Can't fly";
    }
}