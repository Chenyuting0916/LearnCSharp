using LearnCSharp.Observer.Subject;

namespace LearnCSharp.Observer.Observer;

public class ConcreteObserverB : IObserver
{
    public void Update(ISubject subject)
    {
        if (((Subject.Subject)subject).State is 0 or >= 2)
        {
            Console.WriteLine("ConcreteObserverB: Reacted to the event.");
        }
    }
}