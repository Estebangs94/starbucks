using Domain.Common;

namespace Domain.Entities;

public class ItemIngredients : BaseEntity
{
    public int ItemId { get; set; }
    public Item Item { get; set; } = default!;
    public int IngredientId { get; set; }
    public Ingredient Ingredient { get; set; } = default!;
    /// <summary>
    /// How much of the ingredient is needed for the item
    /// </summary>
    public decimal IngredientQuantity { get; set; }
}