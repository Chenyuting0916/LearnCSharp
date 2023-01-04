using LearnCSharp.Observer.Observer;

namespace LearnCSharp.Observer.Subject;

public interface ISubject
{
    void RegisterObserver(IObserver observer);

    void RemoveObserver(IObserver observer);

    void Notify();
}