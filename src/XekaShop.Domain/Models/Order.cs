namespace XekaShop.Domain.Models;

public class Order
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = string.Empty;
}
