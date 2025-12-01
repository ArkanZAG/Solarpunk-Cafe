using UnityEngine;

namespace Ingredient
{
    [CreateAssetMenu(fileName = "Ingredients", menuName = "Scriptable Objects/Ingredients")]
    public class Ingredients : ScriptableObject
    {
        public string foodName;
        public Sprite foodIcon;
        public Based foodBased;
        public Type foodType;
        public Taste foodTaste;
        
        
        public enum Based
        {
            AnimalBased,
            PlantBased,
        }

        public enum Type
        {
            Protein,
            Fat,
            Sugar,
            Fiber,
            Carbs,
        }

        public enum Taste
        {
            Sweet,
            Salty,
            Umami,
            Bitter,
        }


    }
}
