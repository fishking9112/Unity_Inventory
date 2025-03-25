using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// GameManager 입니다.
/// </summary>
public class GameManager : MonoSingleton<GameManager>
{
    public Player player;
    //public UIManager uiManager;
    public List<ItemData> itemDataList;

    protected override void Awake()
    {
        base.Awake();
    }

    private void Start()
    {
        // 기본 아이템 셋팅
        for(int i = 0; i < itemDataList.Count; i++)
        {
            UIManager.Instance.inventory.AddItem(itemDataList[i]);
        }
        // 기본 아이템 넣으려고 임시로 넣었는데 ..
        // Inventory를 UI 에서 가지고 있어야 하는지 , Player랑 연결을 해놔야 하는지 .. ?!
    }

}
