using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace CogswellServiceAPI.Controllers;

[Route("[controller]")]
[ApiController]

public class Menu_ItemController : ControllerBase
{


    [HttpGet(Name = "GetMenu_Items")]

    public async Task<IResult> GetMenu_Items(IMenu_ItemData data)
    {
        try
        {
            return Results.Ok(await data.GetAllMenu_Items());
        }
        catch (Exception ex)
        {

            return Results.Problem(ex.Message);

        }

    }

    [HttpGet("{id:int}")]

    public async Task<IResult> GetMenu_Item(int id, IMenu_ItemData data)
    {
        try
        {
            var results = await data.GetMenu_Item(id);
            if (results == null) { return Results.NotFound(); }
            return Results.Ok(results);
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);

        }
    }

    [HttpPost(Name = "AddMenu_Item")]
    public async Task<IResult> InsertMenu_Item(Menu_Item menu_Item, IMenu_ItemData data)
    {
        try
        {
            await data.InsertMenu_Item(menu_Item);
            return Results.Ok();
        }

        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    [HttpPut(Name = "UpdateMenu_Item")]
    public async Task<IResult> UpdateMenu_Item(Menu_Item menu_Item, IMenu_ItemData data)
    {
        try
        {
            await data.UpdateMenu_Item(menu_Item);
            return Results.Ok();
        }

        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    [HttpDelete(Name = "DeleteMenu_Item/{id}")]
    public async Task<IResult> DeleteMenu_Item(int id, IMenu_ItemData data)
    {
        try
        {
            await data.DeleteMenu_Item(id);
            return Results.Ok();
        }

        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }


}
