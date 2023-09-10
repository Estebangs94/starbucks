using Domain.Common;
using Domain.Enums;

namespace Domain.Entities;

public class Ingredient : BaseEntity
{
    public string Name { get; set; } = null!;
    public int Stock { get; set; }
    public UnitType Unit { get; set; }
}