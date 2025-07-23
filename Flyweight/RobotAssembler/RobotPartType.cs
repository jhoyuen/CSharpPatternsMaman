namespace RobotAssembler;

/// <summary>
/// RobotPartType - Flyweight (Shared Intrinsic Data)
/// </summary>
public class RobotPartType : IEquatable<RobotPartType>
{
    public string Name { get; }
    public string Material { get; }
    public string Size { get; }

    public RobotPartType(string name, string material, string size)
    {
        Name = name;
        Material = material;
        Size = size;
    }

    public void Display(string slotInfo)
    {
        Console.WriteLine($"Part: {Name} | Material: {Material} | Size: {Size} | Slot: {slotInfo}");
    }

    public bool Equals(RobotPartType? other)
    {
        if (other is null) return false;
        return Name == other.Name && Material == other.Material && Size == other.Size;
    }

    public override bool Equals(object? obj) => Equals(obj as RobotPartType);

    public override int GetHashCode() => HashCode.Combine(Name, Material, Size);
}