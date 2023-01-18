namespace LearnCSharp.Observer.Observer;

public class Caller
{
    public void Call()
    {
        var subject = new Subject.Subject();
        var observerA = new ConcreteObserverA(subject);
        var observerB = new ConcreteObserverB(subject);

        subject.SomeBusinessLogic();
        subject.SomeBusinessLogic();

        observerB.RemoveSubject();

        subject.SomeBusinessLogic();
    }
}