using CogswellData;
using Dapper;
using CogswellServiceAPI.DbAccess;

namespace CogswellServiceAPI.Data
{
    public class IngredientData
    {

        public List<Ingredient> Ingredients = new();

        public void GetAllIngredients() => Ingredients = DbAccess.DbConnect.connection.Query<Ingredient>("SELECT * FROM Ingredients;").ToList();

    }
}
