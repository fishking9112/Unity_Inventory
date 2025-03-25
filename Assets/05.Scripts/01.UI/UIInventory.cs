using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    public Button btnClose;

    public UISlot prefab_UISlot;
    public Transform slotPannel;
    public List<UISlot> uiSlot_List;

    [SerializeField] private int inventorySize = 30;

    public TextMeshProUGUI txtSlotCount;

    private void Awake()
    {
        InitInventory();
    }

    void Start()
    {
        btnClose.onClick.AddListener(UIManager.Instance.OpenMainMenuCanvas);
    }

    private void InitInventory()
    {
        for(int i = 0; i < inventorySize; i++)
        {
            var Slot = Instantiate(prefab_UISlot, slotPannel);
            Slot.index = i;
            Slot.inventory = this;
            uiSlot_List.Add(Slot);
        }
    }

    public void UpdateUI()
    {
        int fullSlotCount = 0;

        for(int i = 0; i < uiSlot_List.Count; i++)
        {
            //아이템이 있으면 fullSlotCount 를 올려주자
            if (uiSlot_List[i] != null)
            {
                fullSlotCount++;
                uiSlot_List[i].UpdateUI();
            }

            //수정 필요 ?
            //아이템 앞으로 땡겨주기
            
        }

        txtSlotCount.text = fullSlotCount.ToString() + " / " + inventorySize.ToString();
    }

    public void AddItem(ItemData itemData)
    {
        UISlot emptySlot = GetEmptySlot();

        if(emptySlot != null)
        {
            emptySlot.SetItem(itemData);
            UpdateUI();
        }
        else
        {
            // 수정 필요
            // 인벤토리 꽉참 예외처리
            // 팝업창을 띄워야하나 ??
            // 제출 후 튜터님한테 물어보고 추가보완 합시다.
        }
    }

    private UISlot GetEmptySlot()
    {

        for(int i = 0; i < inventorySize; i++)
        {
            if (uiSlot_List[i].itemData == null)
            {
                return uiSlot_List[i];
            }
        }

        return null;
    }

}
