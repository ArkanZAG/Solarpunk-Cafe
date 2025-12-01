using UnityEngine.Serialization;

namespace FoodRecipe
{
    [System.Serializable]
    public class Requirements
    {
        public InggredientRequire inggredientRequire;
        public int quantity = 0;
        
        public enum InggredientRequire
        {
            None,
            Banana,
            Cassava,
            Clams,
            PalmSugar,
            AnyProtein,
            AnyFat,
            AnySugar,
            AnyFiber,
            AnyCarbs,
            AnyFlour,
        }
    }
}