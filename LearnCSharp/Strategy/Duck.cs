using LearnCSharp.Strategy.Fly;
using LearnCSharp.Strategy.Quack;

namespace LearnCSharp.Strategy;

public class Duck
{
    protected Duck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
    {
        FlyBehavior = flyBehavior;
        QuackBehavior = quackBehavior;
    }

    private IFlyBehavior FlyBehavior { get; }
    private IQuackBehavior QuackBehavior { get; }

    public string Fly()
    {
        return FlyBehavior.Fly();
    }
    
    public string Quack()
    {
        return QuackBehavior.Quark();
    }
}