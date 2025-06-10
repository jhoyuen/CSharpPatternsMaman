namespace ZooSim;

public class AnimalSwitchFactory
{
    public static IAnimal CreateAnimal(string animalType)
    {
        return animalType.ToLower() switch
        {
            "dog" => new Dog(),
            "cat" => new Cat(),
            "parrot" => new Parrot(),
            _ => throw new ArgumentException($"Animal type '{animalType}' is not supported.")
        };
    }
}
