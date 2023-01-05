using LearnCSharp.Observer.Subject;

namespace LearnCSharp.Observer.Observer;

public interface IObserver
{
    void Update();
    void RemoveSubject();
}