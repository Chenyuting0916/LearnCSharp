using FluentAssertions;
using LearnCSharp.Strategy;
using LearnCSharp.Strategy.Ducks;
using LearnCSharp.Strategy.Fly;
using LearnCSharp.Strategy.Quack;
using NUnit.Framework;

namespace LearnCSharpTest;

public class StrategyPracticeTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void NormalDuck_Should_Quack_And_FlyWithWings()
    {
        var normalDuck = new NormalDuck(new FlyWithWings(), new Quack());
        normalDuck.Fly().Should().Be("Fly with wings");
        normalDuck.Quack().Should().Be("quack");
    }
    
    [Test]
    public void RocketDuck_Should_Squeak_And_FlyWithRockets()
    {
        var rocketDuck = new RocketDuck(new FlyWithRocket(), new Squeak());
        rocketDuck.Fly().Should().Be("Fly with Rocket");
        rocketDuck.Quack().Should().Be("Squeak");
    }
}