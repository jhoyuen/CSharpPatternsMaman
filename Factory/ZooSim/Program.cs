using ZooSim;

Console.WriteLine("Zoo Dictionary Factory pattern (respects OCP / SRP, future-proofing)");
Console.WriteLine("---");

var factory = new AnimalDictionaryFactory();
IAnimal animal1 = factory.CreateAnimal("Dog");
animal1.Speak(); // Woof!
IAnimal animal2 = factory.CreateAnimal("Parrot");
animal2.Speak(); // Squawk!
IAnimal animal3 = factory.CreateAnimal("Cat");
animal3.Speak(); // Meow!
Console.WriteLine("");
Console.WriteLine("Zoo Switch Factory pattern (for simple cases, where you don't expect changes in future. Consider enums / constants");
Console.WriteLine("---");
IAnimal animal4 = AnimalSwitchFactory.CreateAnimal("Dog");
animal4.Speak(); // Woof!
IAnimal animal5 = AnimalSwitchFactory.CreateAnimal("Parrot");
animal5.Speak(); // Squawk!
IAnimal animal6 = AnimalSwitchFactory.CreateAnimal("Cat");
animal6.Speak(); // Meow!