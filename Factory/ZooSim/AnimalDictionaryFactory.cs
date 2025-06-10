namespace ZooSim;

public class AnimalDictionaryFactory
{
    private readonly Dictionary<string, Func<IAnimal>> _animalMap = new()
    {
        { "dog", () => new Dog() },
        { "cat", () => new Cat() },
        { "parrot", () => new Parrot() }
    };

    public IAnimal CreateAnimal(string animalType)
    {
        if (_animalMap.TryGetValue(animalType.ToLower(), out var animalMap))
        {
            return animalMap();
        }

        throw new ArgumentException($"Animal type '{animalType}' is not supported.");
    }
}
