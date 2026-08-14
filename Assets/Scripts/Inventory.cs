using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

// Class to represent an item in the inventory
public class InventoryItem
{
    public ItemData item;
    public int amount;

//Constructor for InventoryItem
    public InventoryItem(ItemData item, int amount)
    {
        this.item = item;
        this.amount = amount;
    }
}

public class Inventory : MonoBehaviour
{
//List of items in inventory called items
    public List<InventoryItem> items = new();
//Method to add item to items list when called with InventoryItem.AddItem(ItemData,int)
    public void AddItem(ItemData item, int amount)
    {
// Declares each InventoryItem in items as inventoryItem then checks if we have it
        foreach (InventoryItem inventoryItem in items)
        {
//If we have the item already, we add to the amount and return
            if (inventoryItem.item == item)
            {
                inventoryItem.amount += amount;
                return;
            }
        }
// If we dont have the item add it to the list itmes as a new InventoryItem
        items.Add(new InventoryItem(item, amount));
    }
}