namespace XekaShop.Domain.Models;

public class User
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = String.Empty;
    public string Email { get; set; } = String.Empty;

    public List<Order> Orders { get; set; } = new();

}
