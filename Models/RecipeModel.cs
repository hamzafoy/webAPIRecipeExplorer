namespace WebAPIRecipes.Models
{
    public class Recipe
    {
        public string Name { get; init; }
        public string Description { get; init; }
        public string[] Cuisines { get; init; }
        public string[] Instructions { get; init; }
        public string[] Ingredients { get; init; }
        public DateTime CreateDate { get; init; }

    }
}
