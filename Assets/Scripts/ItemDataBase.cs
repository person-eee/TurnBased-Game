using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemDataBase", menuName = "Scriptable Objects/ItemDataBase")]
public class ItemDataBase : ScriptableObject
{
    public List<ItemData> items = new();

    public ItemData GetItem(int id)
    {
        foreach (ItemData item in items)
        {
            if (item.itemID == id)
                return item;
        }

        return null;
    }
}
