using Microsoft.AspNetCore.Mvc;

namespace CogswellServiceAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class Menu_ItemController : ControllerBase
{
    [HttpGet(Name = "GetMenu_Items")]
    public async Task<IResult> GetMenu_Items(IMenu_ItemData data)
    {
        try
        {
            return Results.Ok(await data.GetAllMenu_Items());
        }
        catch(Exception ex) {

            return Results.Problem(ex.Message);
        
        
        }

    }


}
