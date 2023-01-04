using LearnCSharp.Observer.Observer;
using LearnCSharp.Observer.Subject;



var subject = new Subject();
var observerA = new ConcreteObserverA();
subject.RegisterObserver(observerA);

var observerB = new ConcreteObserverB();
subject.RegisterObserver(observerB);

subject.SomeBusinessLogic();
subject.SomeBusinessLogic();

subject.RemoveObserver(observerB);

subject.SomeBusinessLogic();