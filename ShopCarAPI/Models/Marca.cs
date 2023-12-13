namespace ShopCarAPI.Models;

public class Marca : ResultApi<bool>
{
    public string? Codigo { get; set; }
    public string? Nome { get; set; }
}
