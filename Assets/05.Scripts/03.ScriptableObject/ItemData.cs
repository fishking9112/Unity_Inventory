using UnityEngine;

public enum ItemType
{
    Equipable,
    Consumable
}


[CreateAssetMenu(fileName = "Item", menuName = "New Item")]

public class ItemData : ScriptableObject
{
    [Header("Info")]
    public Sprite icon;
    public string itemName;
    public ItemType type;
    

    [Header("Bouns Status")]
    public int Code;
    public int Fouce;
    public int Hp;
    public int Creativity;
}
