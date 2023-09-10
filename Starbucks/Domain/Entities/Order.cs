using Domain.Common;

namespace Domain.Entities;

public class Order : BaseEntity
{
    public string CustomerName { get; set; } = default!;
    public string CustomerAddress { get; set; } = default!;
    public string CustomerEmail { get; set; } = default!;
    public string CustomerPhoneNumber { get; set; } = default!;
    public ICollection<Item> OrderItems { get; set; } = new List<Item>();
}