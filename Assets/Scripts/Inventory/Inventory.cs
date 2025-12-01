using System.Collections.Generic;
using Ingredient;
using UnityEngine;

namespace Inventory
{
    public class Inventory : MonoBehaviour
    {
        [SerializeField] private List<Ingredients> ingredients;

        public List<Ingredients> Ingredients => ingredients;

        public void AddItem(Ingredients item)
        {
            ingredients.Add(item);
        }

        public void RemoveItem()
        {
            
        }
    }
}
