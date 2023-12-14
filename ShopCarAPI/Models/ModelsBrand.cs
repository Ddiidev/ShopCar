namespace ShopCarAPI.Models;

public class ModelsBrand : ResultApi<string>
{
	public List<ExtModelsBrand>? Modelos { get; set; }
}

public class ExtModelsBrand
{
	public string? Codigo { get; set; }
	public string? Nome { get; set; }
}