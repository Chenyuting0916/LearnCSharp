using LearnCSharp.Observer.Subject;

namespace LearnCSharp.Observer.Observer;

public class ConcreteObserverB : IObserver
{
    private ISubject Subject { get; }
    public ConcreteObserverB(ISubject subject)
    {
        Subject = subject;
        Subject.RegisterObserver(this);
    }
    
    public void Update()
    {
        if (((Subject.Subject)Subject).State is 0 or >= 2)
        {
            Console.WriteLine("ConcreteObserverB: Reacted to the event.");
        }
    }

    public void RemoveSubject()
    {
        Subject.RegisterObserver(this);
    }
}