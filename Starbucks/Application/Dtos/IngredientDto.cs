
using Domain.Entities;
using Domain.Enums;

public class IngredientsDto
{
    public string Name { get; set; } = default!;
    public decimal Quantity { get; set; }
    public string UnitType { get; set; } = default!;

    public static IngredientsDto FromEntity(ItemIngredients ingredient) => new IngredientsDto
    {
        Name = ingredient.Ingredient.Name,
        Quantity = ingredient.IngredientQuantity,
        UnitType = ingredient.Ingredient.Unit.ToString()
    };
}