
namespace CogswellServiceAPI.Data;

public interface IRecipeData
{
    Task DeleteRecipe(int id);
    Task<IEnumerable<Recipe>> GetAllRecipes();
    Task<Recipe?> GetRecipe(int id);
    Task InsertRecipe(Recipe recipe);
    Task UpdateRecipe(Recipe recipe);
}