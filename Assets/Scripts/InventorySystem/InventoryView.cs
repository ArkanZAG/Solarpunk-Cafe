using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace InventorySystem
{
    public class InventoryView : MonoBehaviour
    {
        [SerializeField] private Button openInventoryButton;
        [SerializeField] private Button closeInventoryButton;

        [SerializeField] private GameObject inventoryPanel;
        [SerializeField] private GameObject inventoryElement;
        [SerializeField] private GameObject elementParent;

        [SerializeField] private Inventory playerInventory;

        [SerializeField] private List<GameObject> spawnedElements = new();

        private void Start()
        {
            openInventoryButton.onClick.AddListener(OpenInventory);
            closeInventoryButton.onClick.AddListener(CloseInventory);
        }

        private void Update()
        {
            
        }

        private void OpenInventory()
        {
            inventoryElement.SetActive(true);
        }
        
        private void CloseInventory()
        {
            inventoryElement.SetActive(false);
        }

        private void DisplayInventory()
        {
            for (var i = 0; i < playerInventory.Ingredients.Count; i++)
            {
                var obj = Instantiate(inventoryElement, elementParent.transform, false);
                var inventoryViewElement = obj.GetComponent<InventoryViewElement>();
                inventoryViewElement.Show(playerInventory.Ingredients[i]);
                spawnedElements.Add(obj);
            }
        }
    }
}