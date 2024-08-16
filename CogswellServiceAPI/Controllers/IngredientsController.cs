using Microsoft.AspNetCore.Mvc;

namespace CogswellServiceAPI.Controllers;

[Route("[controller]")]
[ApiController]

public class IngredientsController : ControllerBase
{

    [HttpGet(Name = "GetIngredients")]


    public async Task<IResult> GetIngredients(IIngredientData data)
    {
        try
        {

            return Results.Ok(await data.GetAllIngredients());
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    [HttpGet("{id:int}")]

    public async Task<IResult> GetIngredient(int id, IIngredientData data)
    {
        try
        {
            var results = await data.GetIngredient(id);
            if (results == null) { return Results.NotFound(); }
            return Results.Ok(results);
        }

        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    [HttpPost(Name = "AddIngredient")]
    public async Task<IResult> InsertIngredient(Ingredient ingredient, IIngredientData data)
    {
        try
        {
            await data.InsertIngredient(ingredient);
            return Results.Ok();
        }

        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    [HttpPut(Name = "UpdateIngredient")]
    public async Task<IResult> UpdateIngredient(Ingredient ingredient, IIngredientData data)
    {
        try
        {
            await data.UpdateIngredient(ingredient);
            return Results.Ok();
        }

        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    [HttpDelete(Name = "DeleteIngredient/{id}")]
    public async Task<IResult> DeleteIngredient(int id, IIngredientData data)
    {
        try
        {
            await data.DeleteIngredient(id);
            return Results.Ok();
        }

        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
}
