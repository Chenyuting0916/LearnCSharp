using LearnCSharp.Observer.Subject;

namespace LearnCSharp.Observer.Observer;

class ConcreteObserverA : IObserver
{
    public void Update(ISubject subject)
    {
        if (((Subject.Subject)subject).State < 3)
        {
            Console.WriteLine("ConcreteObserverA: Reacted to the event.");
        }
    }
}