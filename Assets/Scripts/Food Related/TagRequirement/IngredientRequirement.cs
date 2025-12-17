using System.Collections.Generic;

namespace Food_Related.TagRequirement
{
    public class IngredientRequirement : Requirement
    {
        public Ingredients ingredientRequire;
        
        public override bool IsAvailable(List<Ingredients> ingredient)
        {
            return ingredient.Contains(ingredientRequire);
        }
    }
}