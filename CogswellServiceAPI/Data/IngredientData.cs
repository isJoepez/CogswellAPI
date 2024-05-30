using CogswellData;
using Dapper;
using CogswellServiceAPI.DbAccess;

namespace CogswellServiceAPI.Data
{
    public class IngredientData : IIngredientData
    {
        private readonly IDbConnect _db;

        public IngredientData(IDbConnect db)
        {
            _db = db;
        }

        public Task<IEnumerable<Ingredient>> GetAllIngredients() =>
            _db.LoadData<Ingredient, dynamic>(storedProcedure: "dbo.spIngredient_GetAll", new { });

        public async Task<Ingredient?> GetIngredient(int id)
        {
            var results = await _db.LoadData<Ingredient, dynamic>(
                storedProcedure: "dbo.spIngredient_Get",
                new { Id = id });
            return results.FirstOrDefault();


        }

        public Task InsertIngredient(Ingredient ingredient) =>
             _db.SaveData(storedProcedure: "dbo.spIngredient_Insert",
                 new
                 {
                     ingredient.Name,
                     ingredient.Quantity,
                     ingredient.UoM,
                     ingredient.UnitCost,
                     ingredient.Category,
                     ingredient.CreatedBy,
                     ingredient.CreatedDate,
                     ingredient.UpdatedBy,
                     ingredient.UpdatedDate
                 });

        public Task UpdateIngredient(Ingredient ingredient) =>
            _db.SaveData(storedProcedure: "dbo.spIngredient_Update", new { ingredient });


        public Task DeleteIngredient(int id) =>
            _db.SaveData(storedProcedure: "dbo.spIngredient_Delete", new { Id = id });



    }
}
