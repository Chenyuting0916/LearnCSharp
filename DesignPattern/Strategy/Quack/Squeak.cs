namespace LearnCSharp.Strategy.Quack;

public class Squeak : IQuackBehavior
{
    public string Quark()
    {
        Console.WriteLine("Squeak");
        return "Squeak";
    }
}