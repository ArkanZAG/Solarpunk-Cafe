using System.Collections.Generic;
using UnityEngine;

namespace Food_Related.FoodRecipe
{
    [CreateAssetMenu(fileName = "Food Recipe", menuName = "Scriptable Objects/Food Recipe")]
    public class Recipe : ScriptableObject
    {
        public string recipeName;
        public List<Ingredients> requirementsList;
    }
}