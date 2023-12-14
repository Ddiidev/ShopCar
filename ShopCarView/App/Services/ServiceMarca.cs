using ShopCar.App.Models;

namespace ShopCar.App.Services;
public class ServiceMarca : ServiceGen<ModelMarca>
{
	protected override string SelectAll { get; init; } = @"
		SELECT * FROM Marca
	";

	protected override string SelectById { get; init; } = @"
		SELECT * FROM Marcas WHERE Codigo = @Codigo
	";

	protected string SelectByCodigo { get; init; } = @"
		SELECT * FROM Marcas WHERE Codigo = @Codigo
	";

	protected override string DeleteSql { get; init; } = @"
		DELETE FROM Marcas WHERE Id = @Id;
	";

	protected override string UpdateSql { get; init; } = @"
		UPDATE Marcas 
		SET Codigo = @Codigo, 
		   Nome = @Nome
		WHERE Id = @Id
	";

	protected override string InsertSql { get; init; } = @"
		INSERT INTO Marcas (Codigo, Nome)
		VALUES (@Codigo, @Nome)
	";

	public async Task<IEnumerable<ModelMarca>> GetByCodigo(string codigo)
		=> await GetAll(SelectByCodigo, new {
			Codigo = codigo
		});
}
