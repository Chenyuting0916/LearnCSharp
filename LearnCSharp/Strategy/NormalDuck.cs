using LearnCSharp.Strategy.Fly;
using LearnCSharp.Strategy.Quack;

namespace LearnCSharp.Strategy;

public class NormalDuck : Duck
{
    public NormalDuck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior) : base(flyBehavior, quackBehavior)
    {
    }
}