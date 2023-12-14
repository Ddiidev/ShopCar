using Dapper;

namespace ShopCar.App.Services;
public abstract class ServiceGen<T>
{
	protected abstract string SelectAll { get; init; }
	protected abstract string SelectById { get; init; }
	protected abstract string DeleteSql { get; init; }
	protected abstract string UpdateSql { get; init; }
	protected abstract string InsertSql { get; init; }

	public async Task<IEnumerable<T>> GetAll()
	{
		using var serviceDb = new ServiceDb();

		return await serviceDb.Connection.QueryAsync<T>(SelectAll);
	}

	protected async Task<IEnumerable<T>> GetById()
	{
		using var serviceDb = new ServiceDb();

		return await serviceDb.Connection.QueryAsync<T>(SelectById);
	}

	protected async Task<IEnumerable<T>> GetAll<K>(string select, K param)
	{
		using var serviceDb = new ServiceDb();

		return await serviceDb.Connection.QueryAsync<T>(select, param);
	}

	public async Task<int> Delete(T model)
	{
		using var serviceDb = new ServiceDb();

		return await serviceDb.Connection.ExecuteAsync(DeleteSql, model);
	}

	public async Task<int> Update(T model)
	{
		using var serviceDb = new ServiceDb();

		return await serviceDb.Connection.ExecuteAsync(UpdateSql, model);
	}

	public async Task<int> Add(T model)
	{
		using var serviceDb = new ServiceDb();


		return await serviceDb.Connection.ExecuteAsync(InsertSql, model);
	}
}
