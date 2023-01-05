using LearnCSharp.Observer.Observer;
using LearnCSharp.Observer.Subject;



var subject = new Subject();
var observerA = new ConcreteObserverA(subject);
var observerB = new ConcreteObserverB(subject);

subject.SomeBusinessLogic();
subject.SomeBusinessLogic();

observerB.RemoveSubject();

subject.SomeBusinessLogic();