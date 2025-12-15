using Food_Related.Food_Tags;
using UnityEngine;

namespace Food_Related
{
    [CreateAssetMenu(fileName = "Nutrition", menuName = "Scriptable Objects/Ingredients")]
    public class Ingredients : ScriptableObject
    {
        public string ingredientName;
        public Sprite ingredientImage;
        public Origin origin;
        public Source source;
        public CulinaryRole[] culinaryRoles;
        public Nutrition[] nutritions;
    }
}