namespace LearnCSharp.Strategy.Quack;

public class Quack : IQuackBehavior
{
    public string Quark()
    {
        Console.WriteLine("quack");
        return "quack";
    }
}