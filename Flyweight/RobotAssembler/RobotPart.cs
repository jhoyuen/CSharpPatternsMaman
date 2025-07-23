using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotAssembler;

/// <summary>
/// RobotPart - Extrinsic Data (Stateful)
/// </summary>
public class RobotPart
{
    private readonly int _slotNumber;
    private readonly RobotPartType _partType;

    public RobotPart(int slotNumber, RobotPartType partType)
    {
        _slotNumber = slotNumber;
        _partType = partType;
    }

    public void Render()
    {
        _partType.Display($"Slot {_slotNumber}");
    }
}