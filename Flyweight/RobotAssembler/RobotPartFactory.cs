namespace RobotAssembler;

/// <summary>
/// RobotPartFactory - Flyweight Factory using HashSet
/// </summary>
public class RobotPartFactory
{
    private readonly HashSet<RobotPartType> _partTypes = new();

    public RobotPartType GetPartType(string name, string material, string size)
    {
        var tempPart = new RobotPartType(name, material, size);

        if (_partTypes.TryGetValue(tempPart, out var existingPart))
        {
            return existingPart;
        }

        _partTypes.Add(tempPart);
        return tempPart;
    }

    public void PrintCachedTypes()
    {
        Console.WriteLine($"\n[Cached Robot Part Types: {_partTypes.Count}]");
        foreach (var part in _partTypes)
            Console.WriteLine($"- {part.Name}, {part.Material}, {part.Size}");
    }
}
