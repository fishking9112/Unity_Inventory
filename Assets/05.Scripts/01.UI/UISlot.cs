using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    public UIInventory inventory;
    public Image icon;
    public int index;

    public bool isEquip = false;

    [SerializeField] private string itemName;

    public ItemData itemData { get; private set; }

    public void SetItem(ItemData itemData)
    {
        this.itemData = itemData;
        this.itemName = itemData.itemName;
        this.icon.sprite = itemData.icon;

        if(itemData.type == ItemType.Equipable)
        {
            //혹시 모르니까 한번 더 체크
            isEquip = false;
        }
    }

    public void UpdateUI()
    {
        //icon.sprite = itemData.icon;
        icon.gameObject.SetActive(true);
    }

}
