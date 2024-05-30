using CogswellData;

namespace CogswellServiceAPI.Data;
public interface IIngredientData
{
    Task DeleteIngredient(int id);
    Task<IEnumerable<Ingredient>> GetAllIngredients();
    Task<Ingredient?> GetIngredient(int id);
    Task InsertIngredient(Ingredient ingredient);
    Task UpdateIngredient(Ingredient ingredient);
}