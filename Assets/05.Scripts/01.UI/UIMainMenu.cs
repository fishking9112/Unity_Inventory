using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// MainMenu 관리 스크립트 입니다.
/// </summary>

public class UIMainMenu : MonoBehaviour
{
    public TextMeshProUGUI txtID;
    public TextMeshProUGUI txtLv;

    public TextMeshProUGUI txtExp;
    public Image imgExp;

    public TextMeshProUGUI txtGold;

    public Button btnStatus;
    public Button btnInventory;

    void Start()
    {
        btnStatus.onClick.AddListener(UIManager.Instance.OpenStatusCanvas);
        btnInventory.onClick.AddListener(UIManager.Instance.OpenInventoryCanvas);
        UpdateUI();
    }

    void UpdateUI()
    {
        txtID.text = GameManager.Instance.player.controller.id;
        txtLv.text = GameManager.Instance.player.controller.level.ToString();
        //경험치 Image Filed 채워주기
        float fill , exp , maxExp;
        exp = GameManager.Instance.player.controller.exp;
        maxExp = GameManager.Instance.player.controller.maxExp;
        fill = exp / maxExp;
        imgExp.fillAmount = fill;

        txtExp.text = exp.ToString() + " / " + maxExp.ToString();


        txtGold.text = GameManager.Instance.player.controller.gold.ToString();
    }

}
