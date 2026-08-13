using UnityEngine;

[CreateAssetMenu(fileName = "ItemData", menuName = "Scriptable Objects/ItemData")]
public class ItemData : ScriptableObject
{
    public string itemName;
    public int itemID;
    public Sprite icon;
    public int value;
    public bool isEquippable;
    public bool isConsumable;
    public int strengthStat;
    public int defenseStat;
    public int dexterityStat;
    public int magicPowerStat;
    public int luckStat;
    public int energyStat;
}
