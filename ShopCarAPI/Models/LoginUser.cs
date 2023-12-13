namespace ShopCarAPI.Models;

public class LoginUser : ResultApi<bool>
{
    public ExtLoginUser? User { get; set; }
}


public class ExtLoginUser
{
	public string? User { get; set; }
	public string? Password { get; set; }
}