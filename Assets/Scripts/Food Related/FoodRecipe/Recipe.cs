using System.Collections.Generic;
using Food_Related.Food_Tags;
using Food_Related.TagRequirement;
using UnityEngine;

namespace Food_Related.FoodRecipe
{
    [CreateAssetMenu(fileName = "Food Recipe", menuName = "Scriptable Objects/Food Recipe")]
    public class Recipe : ScriptableObject
    {
        public string recipeName;

        public Ingredients ingredientRequire;
        public CulinaryRole[] culinaryRoleRequire;
        public Nutrition[] nutritionRequire;
    }
}