using System.Collections.Generic;
using UnityEngine;

namespace FoodRecipe
{
    [CreateAssetMenu(fileName = "Food Recipe", menuName = "Scriptable Objects/Food Recipe")]
    public class Recipe : ScriptableObject
    {
        public List<Requirements> requirementsList;
    }
}