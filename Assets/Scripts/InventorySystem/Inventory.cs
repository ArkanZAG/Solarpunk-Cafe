using System.Collections.Generic;
using Food_Related;
using UnityEngine;

namespace InventorySystem
{
    public class Inventory : MonoBehaviour
    {
        [SerializeField] private List<Ingredients> ingredients;

        public List<Ingredients> Ingredients => ingredients;

        public void AddItem(Ingredients item)
        {
            ingredients.Add(item);
        }

        public void RemoveItem(Ingredients item)
        {
            ingredients.Remove(item);
        }
    }
}
