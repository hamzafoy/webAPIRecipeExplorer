using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPIRecipes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        readonly string[] meals = { "Mujadarah", "Chicken Tikka", "Fuul Medammas", "Lamb Biryani", "Nihari", "Mansaaf", "Kofta Kebab" };

        [HttpGet]
        public ActionResult GetMeals()
        {
            if (meals.Any())
            {
                return Ok(meals);
            }
            return NotFound();
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
        public ActionResult CreateNewMeals()
        {
            return NotFound();
        }
    }
}
