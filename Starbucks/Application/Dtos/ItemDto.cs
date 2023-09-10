using Domain.Entities;

namespace Application.Dtos;

public class ItemDto
{
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public decimal Price { get; set; }
    public int PreparationTime { get; set; }
    public IList<IngredientsDto> Ingredients { get; set; } = new List<IngredientsDto>();

    public static ItemDto FromEntity(Item item) => new ItemDto
    {
        Name = item.Name,
        Description = item.Description,
        Price = item.Price,
        PreparationTime = item.PreparationTime,
        Ingredients = item.Ingredients.Select(x => IngredientsDto.FromEntity(x)).ToList()
    };
}