using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public string id;
    public int level;
    public int exp;
    public int maxExp;
    public int gold;

    //코딩실력
    public int Code;
    //집중력
    public int Focus;
    //체력
    public int Hp;
    //창의력
    public float Creativity;

    //public PlayerController(string ID, int Lv, int Exp, int MaxExp, int Gold, int Code, int Focus, int Hp, float Creativity)
    //{
    //    //생성자에 이렇게 때려박는게 맞나..
    //    //리팩토링 하게 된다면 Load 기능을 만들고 , 디폴트값을 둔 뒤 , 로드 하는 방식으로 !
    //    //근데 그럼 발제 있는 private set; 을 못하는데 ... ?

    //    this.id = ID;
    //    this.level = Lv;
    //    this.exp = Exp;
    //    this.maxExp = MaxExp;
    //    this.gold = Gold;
    //    this.Code = Code;
    //    this.Focus = Focus;
    //    this.Hp = Hp;
    //    this.Creativity = Creativity;
    //}
}
