using System.Runtime.CompilerServices;

namespace CogswellServiceAPI.Data;

public class RecipeData : IRecipeData
{
    private readonly IDbConnect _db;

    public RecipeData(IDbConnect db)
    {
        _db = db;
    }

    public Task<IEnumerable<Recipe>> GetAllRecipes() =>
        _db.LoadData<Recipe, dynamic>(storedProcedure: "dbo.spRecipes_GetAll", new { });

    public async Task<Recipe?> GetRecipe(int id)
    {
        var results = await _db.LoadData<Recipe, dynamic>(
            storedProcedure: "dbo.spRecipes_Get",
            new { Id = id });
        return results.FirstOrDefault();
    }

    public Task InsertRecipe(Recipe recipe) =>
    _db.SaveData(storedProcedure: "dbo.spRecipes_Insert",
        new
        {
            recipe.Id,
            recipe.Ingredient1,
            recipe.Ingredient2,
            recipe.Ingredient3,
            recipe.Ingredient4,
            recipe.Ingredient5,
            recipe.Ingredient6,
            recipe.Ingredient7,
            recipe.Ingredient8,
            recipe.Ingredient9,
            recipe.Ingredient10

        });


    public Task UpdateRecipe(Recipe recipe) =>
           _db.SaveData(storedProcedure: "dbo.spRecipes_Update", new { recipe });

    public Task DeleteRecipe(int id) =>
           _db.SaveData(storedProcedure: "dbo.spRecipes_Delete", new { Id = id });



}
