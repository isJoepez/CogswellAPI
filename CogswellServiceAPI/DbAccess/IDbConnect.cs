
namespace CogswellServiceAPI.DbAccess;

public interface IDbConnect
{
    Task<IEnumerable<T>> LoadData<T, U>(string storedProcedure, U parameters, string connectionId = "default");
    Task SaveData<T>(string storedProcedure, T parameters, string connectionId = "default");
}