namespace ShopCarAPI.Exceptions;
internal class MarcaException : Exception
{
	public MarcaException()
	{
	}

	public MarcaException(string message)
		: base(message)
	{
	}

	public MarcaException(string message, Exception inner)
		: base(message, inner)
	{
	}
}
