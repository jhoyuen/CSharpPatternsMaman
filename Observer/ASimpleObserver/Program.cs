using ASimpleObserver;

var subject = new Subject();
var observerA = new ConcreteObserver("ObserverA");
var observerB = new ConcreteObserver("ObserverB");

subject.Attach(observerA);
subject.Attach(observerB);

subject.Notify("First message");
subject.Detach(observerA);

subject.Notify("Second message");
subject.Detach(observerB);

Console.Read();
