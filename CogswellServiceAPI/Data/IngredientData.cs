using CogswellData;
using Dapper;
using CogswellServiceAPI.DbAccess;

namespace CogswellServiceAPI.Data
{
    public class IngredientData
    {

        public List<Ingredient> AllIngredients = new();

        public void GetAllIngredients() => AllIngredients = DbAccess.DbConnect.Connection.Query<Ingredient>("SELECT * FROM Ingredients;").ToList();

    }
}
