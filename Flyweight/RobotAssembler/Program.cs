using RobotAssembler;

var factory = new RobotPartFactory();
var robotA = new Robot(factory);

robotA.AddPart(1, "Arm", "Steel", "Medium");
robotA.AddPart(2, "Leg", "Steel", "Large");
robotA.AddPart(3, "Head", "Aluminium", "Small");

var robotB = new Robot(factory);
robotB.AddPart(1, "Arm", "Steel", "Medium"); // reused flyweight
robotB.AddPart(2, "Leg", "Steel", "Large");  // reused flyweight

Console.WriteLine("Robot A Parts:");
robotA.DisplayParts();

Console.WriteLine("\nRobot B Parts:");
robotB.DisplayParts();

factory.PrintCachedTypes();