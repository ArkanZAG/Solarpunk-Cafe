using Food_Related;
using TMPro;
using UnityEngine;

namespace InventorySystem
{
    public class InventoryViewElement
    {
        [SerializeField] private TextMeshProUGUI itemName;
        [SerializeField] private TextMeshProUGUI itemQuantity;
        [SerializeField] private Sprite itemSprite;

        private Ingredients currentIngredient;
        
        public void Show(Ingredients item)
        {
            currentIngredient = item;
            itemName.text = item.ingredientName;
            itemSprite = item.ingredientImage;
        }
    }
}