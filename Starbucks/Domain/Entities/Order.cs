using Domain.Common;

namespace Domain.Entities;

public class Order : BaseEntity
{
    public DateTimeOffset OrderDate { get; set; }
    /// <summary>
    /// Taxes that apply to this order based on the location of the store
    /// </summary>
    public decimal Taxes { get; set; }
     /// <summary>
    /// Sum of all the items in the order
    /// </summary>
    public decimal SubTotal { get; set; }
     /// <summary>
    /// Total of the order including taxes
    /// </summary>
    public decimal Total { get; set; }
    public IList<Item> Items { get; set; } = new List<Item>();
}