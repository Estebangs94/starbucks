using Application.Dtos;
using MediatR;

namespace Application.Queries;

/// <summary>
/// Gets all items
/// </summary>
public record GetItemsQuery : IRequest<IEnumerable<ItemDto>>;