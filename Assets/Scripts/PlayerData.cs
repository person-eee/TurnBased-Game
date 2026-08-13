using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Scriptable Objects/PlayerData")]
public class PlayerData : ScriptableObject
{
    public string playerName;
    public int healthPoints;
    public int experiencePoints;
    public int level;
    public int gold;
    public int strength;
    public int defense;
    public int dexterity;
    public int magicPower;
    public int luck;
    public int energy;
}
