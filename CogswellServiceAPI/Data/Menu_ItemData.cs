namespace CogswellServiceAPI.Data;

public class Menu_ItemData : IMenu_ItemData
{
    private readonly IDbConnect _db;
    public Menu_ItemData(IDbConnect db)
    {
        _db = db;
    }

    public Task<IEnumerable<Menu_Item>> GetAllMenu_Items() =>
        _db.LoadData<Menu_Item, dynamic>(storedProcedure: "dbo.spMenuItem_GetAll", new { });

    public async Task<Menu_Item?> GetMenu_Item(int id)
    {
        var results = await _db.LoadData<Menu_Item, dynamic>(
            storedProcedure: "dbo.spMenuItem_Get",
            new { Id = id });
        return results.FirstOrDefault();
    }

    public Task InsertMenu_Item(Menu_Item menu_Item) =>
     _db.SaveData(storedProcedure: "dbo.spMenuItem_Insert",
         new
         {
             menu_Item.Name,
             menu_Item.TotalCost,
             menu_Item.CreatedBy,
             menu_Item.CreatedDate,
             menu_Item.UpdatedBy,
             menu_Item.UpdatedDate

         });

    public Task UpdateMenu_Item(Menu_Item menu_Item) =>
            _db.SaveData(storedProcedure: "dbo.spMenuItem_Update", new { menu_Item });

    public Task DeleteMenu_Item(int id) =>
            _db.SaveData(storedProcedure: "dbo.spMenuItem_Delete", new { Id = id });











}
