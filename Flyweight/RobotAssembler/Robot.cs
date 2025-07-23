namespace RobotAssembler;

/// <summary>
/// Robot - Client Class
/// </summary>
public class Robot
{
    private readonly List<RobotPart> _parts = new();
    private readonly RobotPartFactory _factory;

    public Robot(RobotPartFactory factory)
    {
        _factory = factory;
    }

    public void AddPart(int slotNumber, string name, string material, string size)
    {
        var type = _factory.GetPartType(name, material, size);
        _parts.Add(new RobotPart(slotNumber, type));
    }

    public void DisplayParts()
    {
        foreach (var part in _parts)
        {
            part.Render();
        }
    }
}
