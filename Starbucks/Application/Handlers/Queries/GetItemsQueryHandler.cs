using Application.Dtos;
using Application.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Handlers.Queries;

public class GetItemsQueryHandler : IRequestHandler<GetItemsQuery, IEnumerable<ItemDto>>
{
    private readonly IStarbucksDbContext _context;

    public GetItemsQueryHandler(IStarbucksDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<ItemDto>> Handle(GetItemsQuery request, CancellationToken cancellationToken)
    {
        var items = await _context.Items
            .Include(x => x.Ingredients)
                .ThenInclude(y => y.Ingredient)
            .ToListAsync(cancellationToken);

        return items.Select(x => ItemDto.FromEntity(x));
    }
}