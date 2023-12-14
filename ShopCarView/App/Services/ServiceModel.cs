using ShopCar.App.Models;

namespace ShopCar.App.Services;
public class ServiceModel : ServiceGen<ModelModelo>
{
	protected override string SelectAll { get; init; } = @"
		SELECT * FROM Modelos
	";

	protected override string SelectById { get; init; } = @"
		SELECT * FROM Modelos WHERE Codigo = @Codigo
	";

	protected string SelectByCodigo { get; init; } = @"
		SELECT * FROM Modelos WHERE Codigo = @Codigo
	";

	protected override string DeleteSql { get; init; } = @"
		DELETE FROM Modelos WHERE Id = @Id;
	";

	protected override string UpdateSql { get; init; } = @"
		UPDATE Modelos 
		SET Codigo = @Codigo, 
		   Nome = @Nome
		WHERE Id = @Id
	";

	protected override string InsertSql { get; init; } = @"
		INSERT INTO Modelos (Codigo, Nome)
		VALUES (@Codigo, @Nome)
	";

	public async Task<IEnumerable<ModelModelo>> GetByCodigo(string codigo)
		=> await GetAll(SelectByCodigo, new {
			Codigo = codigo
		});
}
