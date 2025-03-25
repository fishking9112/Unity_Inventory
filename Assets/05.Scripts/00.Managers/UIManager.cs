using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// UI Manager Canvars 전부 관리해보자 .. !
/// </summary>

public class UIManager : MonoSingleton<UIManager>
{
    [SerializeField]
    public Canvas uiMain_Canvas;
    [SerializeField]
    public GameObject mainButtons;
    [SerializeField]
    public Canvas uiStatus_Canvas;
    [SerializeField]
    public Canvas uiInventory_Canvas;

    public UIInventory inventory;

    private void Start()
    {
        uiMain_Canvas.gameObject.SetActive(true);
        uiStatus_Canvas.gameObject.SetActive(false);
        uiInventory_Canvas.gameObject.SetActive(false);

        ////////////
        inventory = GetComponent<UIInventory>();
    }

    public void OpenMainMenuCanvas()
    {
        mainButtons.gameObject.SetActive(true);

        //Status 만 켜주세요
        uiStatus_Canvas.gameObject.SetActive(false);

        //혹시 모르니 Inven 꺼주기
        uiInventory_Canvas.gameObject.SetActive(false);
    }

    public void OpenStatusCanvas()
    {
        //Main 버튼만 사라지게 하자
        mainButtons.gameObject.SetActive(false);

        //Status 만 켜주세요
        uiStatus_Canvas.gameObject.SetActive(true);
        uiStatus_Canvas.gameObject.GetComponent<UIStatus>().UpdateUI();

        //혹시 모르니 Inven 꺼주기
        uiInventory_Canvas.gameObject.SetActive(false);
    }

    public void OpenInventoryCanvas()
    {
        //Main 버튼만 사라지게 하자
        mainButtons.gameObject.SetActive(false);

        uiStatus_Canvas.gameObject.SetActive(false);

        uiInventory_Canvas.gameObject.SetActive(true);
        uiInventory_Canvas.gameObject.GetComponent<UIInventory>().UpdateUI();
    }
}
