namespace ShopCarAPI.Models;

public class ResultApi<TERROR>
{
	public TERROR? Error { get; set; }
	public string Message { get; set; } = string.Empty;
}
