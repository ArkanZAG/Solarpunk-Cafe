using Food_Related;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace InventorySystem
{
    public class InventoryViewElement : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI itemName;
        [SerializeField] private TextMeshProUGUI itemQuantity;
        [SerializeField] private Image itemImage;

        private Ingredients currentIngredient;
        
        public void Show(Ingredients item)
        {
            currentIngredient = item;
            itemName.text = item.ingredientName;
            itemImage.sprite = item.ingredientImage;
        }
    }
}