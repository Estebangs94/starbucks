using System.Reflection;
using Application;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class StarbucksDbContext : DbContext, IStarbucksDbContext
{
    public StarbucksDbContext(DbContextOptions<StarbucksDbContext> options) : base(options) 
    {
    }

    public DbSet<Item> Items { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Ingredient> Ingredients { get; set; }
    public DbSet<ItemIngredients> ItemsIngredients { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        base.OnModelCreating(builder);
    }
}