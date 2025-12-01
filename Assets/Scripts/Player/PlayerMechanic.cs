using Ingredient;
using FoodRecipe;
using UnityEngine;

namespace Player
{
    public class PlayerMechanic : MonoBehaviour
    {
        [SerializeField] private Inventory.Inventory playerInv;
        private Recipe CK;
        
        private Recipe Cooking(Inventory.Inventory inventory, Ingredients ingredient)
        {
            return CK;
        }

        private void Buying(Ingredients ingredients)
        {
            playerInv.AddItem(ingredients);
        }

        private void Selling()
        {
            
        }
    }
}
