using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    public TextMeshProUGUI txtCode;
    public TextMeshProUGUI txtFocus;
    public TextMeshProUGUI txtHp;
    public TextMeshProUGUI txtCreativity;

    public Button btnClose;
    void Start()
    {
        btnClose.onClick.AddListener(UIManager.Instance.OpenMainMenuCanvas);
        UpdateUI();
    }

    public void UpdateUI()
    {
        txtCode.text = GameManager.Instance.player.controller.Code.ToString();
        txtFocus.text = GameManager.Instance.player.controller.Focus.ToString();
        txtHp.text = GameManager.Instance.player.controller.Hp.ToString();
        txtCreativity.text = GameManager.Instance.player.controller.Creativity.ToString();
    }

}
