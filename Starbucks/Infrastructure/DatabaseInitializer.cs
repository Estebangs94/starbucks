using Domain.Entities;
using Domain.Enums;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Infrastructure;

public static class InitializerExtensions
{
    /// <summary>
    /// Applies migrations to the database and seeds it with initial data.
    /// Will also try to create the database if it doesn't exist.
    /// </summary>
    /// <param name="app"></param>
    public static async Task InitializeDatabaseAsync(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();

        var initializer = scope.ServiceProvider.GetRequiredService<StarbucksDbContextInitializer>();

        await initializer.InitializeAsync();

        await initializer.SeedAsync();
    }
}

public class StarbucksDbContextInitializer
{
    private readonly ILogger<StarbucksDbContextInitializer> _logger;
    private readonly StarbucksDbContext _context;

    public StarbucksDbContextInitializer(ILogger<StarbucksDbContextInitializer> logger, StarbucksDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public async Task InitializeAsync()
    {
        try
        {
            await _context.Database.MigrateAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while initializing the database.");
            throw;
        }
    }

    public async Task SeedAsync()
    {
        try
        {
            await TrySeedAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while seeding the database.");
            throw;
        }
    }

    public async Task TrySeedAsync()
    {
        if (!_context.Items.Any())
        {
            _context.Items.Add(new Item
            {
                Name = "Cappuccino",
                Description = "Espresso shots topped with hot milk foam",
                Price = 3.99m,
                PreparationTime = 5,
                Ingredients = new List<ItemIngredients>
                {
                    new()
                    {
                        Ingredient = new Ingredient
                        {
                            Name = "Espresso",
                            Stock = 100000,
                            Unit = UnitType.Milliliters
                        },
                        IngredientQuantity = 200
                    },
                    new()
                    {
                        Ingredient = new Ingredient
                        {
                            Name = "Milk",
                            Stock = 100000,
                            Unit = UnitType.Milliliters
                        },
                        IngredientQuantity = 200
                    }
                }
            });

            _context.Items.Add(new Item
            {
                Name = "Latte",
                Description = "Espresso shots topped with steamed milk",
                Price = 2.99m,
                PreparationTime = 3,
                Ingredients = new List<ItemIngredients>
                {
                    new()
                    {
                        Ingredient = new Ingredient
                        {
                            Name = "Espresso",
                            Stock = 100000,
                            Unit = UnitType.Milliliters
                        },
                        IngredientQuantity = 100
                    },
                    new()
                    {
                        Ingredient = new Ingredient
                        {
                            Name = "Milk",
                            Stock = 100000,
                            Unit = UnitType.Milliliters
                        },
                        IngredientQuantity = 200
                    }
                }
            });

            _context.Items.Add(new Item
            {
                Name = "Strawberry Frappuccino",
                Description = "Strawberry juice, milk, and ice blended together",
                Price = 4.99m,
                PreparationTime = 10,
                Ingredients = new List<ItemIngredients>
                {
                    new()
                    {
                        Ingredient = new Ingredient
                        {
                            Name = "Strawberry Juice",
                            Stock = 100000,
                            Unit = UnitType.Milliliters
                        },
                        IngredientQuantity = 200
                    },
                    new()
                    {
                        Ingredient = new Ingredient
                        {
                            Name = "Milk",
                            Stock = 100000,
                            Unit = UnitType.Milliliters
                        },
                        IngredientQuantity = 200
                    },
                    new()
                    {
                        Ingredient = new Ingredient
                        {
                            Name = "Ice",
                            Stock = 100000,
                            Unit = UnitType.Milliliters
                        },
                        IngredientQuantity = 200
                    }
                }
            });

            await _context.SaveChangesAsync();
        }
    }
}