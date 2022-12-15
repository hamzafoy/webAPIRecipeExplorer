using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPIRecipes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetMeals()
        {
            string[] meals = { "Mujadarah", "Chicken Tikka", "Fuul Medammas", "Lamb Biryani", "Nihari", "Mansaaf", "Kofta Kebab" };
            
            if (meals.Any())
            {
                return Ok(meals);
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
