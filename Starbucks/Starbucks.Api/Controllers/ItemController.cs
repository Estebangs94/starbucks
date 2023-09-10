using Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Starbucks.Api.Controllers;

[ApiController]
[Route("api/items")]
public class ItemController : ControllerBase
{
    private readonly ISender _sender;

    public ItemController(ISender sender)
    {
        _sender = sender;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var result = await _sender.Send(new GetItemsQuery());

        return Ok(result);
    }
}