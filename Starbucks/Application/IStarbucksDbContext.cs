using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application;

public interface IStarbucksDbContext
{
    public DbSet<Item> Items { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Ingredient> Ingredients { get; set; }
    public DbSet<ItemIngredients> ItemsIngredients { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}