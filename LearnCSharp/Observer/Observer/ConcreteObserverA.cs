using LearnCSharp.Observer.Subject;

namespace LearnCSharp.Observer.Observer;

class ConcreteObserverA : IObserver
{
    private ISubject Subject { get; }
    public ConcreteObserverA(ISubject subject)
    {
        Subject = subject;
        Subject.RegisterObserver(this);
    }

    public void Update()
    {
        if (((Subject.Subject)Subject).State < 3)
        {
            Console.WriteLine("ConcreteObserverA: Reacted to the event.");
        }
    }

    public void RemoveSubject()
    {
        Subject.RemoveObserver(this);
    }
}