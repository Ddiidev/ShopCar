namespace ShopCarAPI.Models;

public class Brand : ResultApi<bool>
{
    public string? Codigo { get; set; }
    public string? Nome { get; set; }
}
