using Domain.Common;

namespace Domain.Entities;

/// <summary>
/// Is what you order at Starbucks. It can be a drink or a food item
/// </summary>
public class Item : BaseEntity
{
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public decimal Price { get; set; }
    public int PreparationTime { get; set; }
    public IList<ItemIngredients> Ingredients { get; set; } = new List<ItemIngredients>();
    public IList<Order> Orders { get; set; } = new List<Order>();
}