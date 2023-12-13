namespace ShopCarAPI.Models;

public class UserLogged : ResultApi<bool>
{
	public User? User { get; set; }
}

public class User
{
	public int Id { get; set; }
	public string? Name { get; set; }
	public string? Token { get; set; }
}
