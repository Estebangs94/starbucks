using Domain.Common;

namespace Domain.Entities;

public class Item : BaseEntity
{
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public decimal Price { get; set; }
    public int PreparationTime { get; set; }
    public ICollection<ItemIngredients> ItemsIngredients { get; set; } = new List<ItemIngredients>();
    public ICollection<Order> ItemOrders { get; set; } = new List<Order>();
}