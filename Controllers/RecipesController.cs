using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIRecipes.Models;

namespace WebAPIRecipes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        Database db = new Database();

        readonly Recipe[] meals =
        {
            new Recipe() { Name = "Falafel", Description = "Fried Chickpea mounds", Cuisines = new string[]{ "Arab", "Middle Eastern" } },
            new Recipe() { Name = "Mujadarah"},
            new Recipe() { Name = "Mansaaf"},
            new Recipe() { Name = "Nihari"},
            new Recipe() { Name = "Ghosht Biryani"},
            new Recipe() { Name = "Fattoush"},
            new Recipe() { Name = "Chana ke Halwa"},
            new Recipe() { Name = "Fuul Medammas"},
            new Recipe() { Name = "Kuku Sabzi"}
        };

        [HttpGet]
        public ActionResult GetMeals()
        {
            //if (meals.Any())
            //{
            //    return Ok(meals);
            //}
            //return NotFound();
            db.RecipesRead();
            return Ok();
        }

        [HttpGet("/NumberOfRecipes")]
        public ActionResult GetSelectNumberOfMeals([FromQuery] int count)
        {
            if (meals.Any())
            {
                return Ok(meals.Take(count));
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult CreateNewMeals([FromBody] Recipe newRecipe)
        {
            db.RecipeCreate(newRecipe);
            return Created("", newRecipe);
        }
    }
}
