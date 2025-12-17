using System;
using Food_Related;
using Food_Related.FoodRecipe;
using InventorySystem;
using UnityEngine;
using UnityEngine.UI;

namespace Player
{
    public class PlayerMechanic : MonoBehaviour
    {
        [SerializeField] private Inventory inventory;
        [SerializeField] private Button button;
        

        private void Start()
        {
            
        }

        private void Update()
        {
            
        }

        private void Buying(Ingredients item)
        {
            inventory.AddItem(item);
        }

        private void Selling(int index)
        {
            inventory.RemoveItem(index);
        }

        private void Serving(Ingredients item, Recipe recipe)
        {
            
        }
    }
}
