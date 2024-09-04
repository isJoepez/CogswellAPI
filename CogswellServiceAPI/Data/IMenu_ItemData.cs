using CogswellData;


namespace CogswellServiceAPI.Data;

public interface IMenu_ItemData
{
    Task DeleteMenu_Item(int id);
    Task<IEnumerable<Menu_Item>> GetAllMenu_Items();
    Task<Menu_Item?> GetMenu_Item(int id);
    Task InsertMenu_Item(Menu_Item menu_Item);
    Task UpdateMenu_Item(Menu_Item menu_Item);
}