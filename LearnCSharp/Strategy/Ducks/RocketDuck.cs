using LearnCSharp.Strategy.Fly;
using LearnCSharp.Strategy.Quack;

namespace LearnCSharp.Strategy.Ducks;

public class RocketDuck : Duck
{
    public RocketDuck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior) : base(flyBehavior, quackBehavior)
    {
    }
}