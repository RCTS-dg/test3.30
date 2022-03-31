using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BluePoint : MonoBehaviour
{
    public Text BattackValue;
    public Text BdefendValue;
    public Text BhpValue;
    public Text BTotalPointValue;
    public int BPointValue = 5;

    void PointChange()
    {
        int x = BPointValue - int.Parse(BattackValue.text) - int.Parse(BdefendValue.text) - int.Parse(BhpValue.text);
        BTotalPointValue.text = x.ToString();
    }
    public void AttackAdd()
    {
        int x = int.Parse(BattackValue.text);
        x++;
        BattackValue.text = x.ToString();
        TotalValue.BAttackValue = x;
        PointChange();
    }

    public void AttackMinus()
    {
        int x = int.Parse(BattackValue.text);
        x--;
        if (x < 0)
        {
            x = 0;
        }
        BattackValue.text = x.ToString();
        TotalValue.BAttackValue = x;
        PointChange();
    }

    public void DefendAdd()
    {
        int x = int.Parse(BdefendValue.text);
        x++;
        BdefendValue.text = x.ToString();
        TotalValue.BdefendValue = x;
        PointChange();
    }

    public void DefendMinus()
    {
        int x = int.Parse(BdefendValue.text);
        x--;
        if (x < 0)
        {
            x = 0;
        }
        BdefendValue.text = x.ToString();
        TotalValue.BdefendValue = x;
        PointChange();
    }

    public void HpAdd()
    {
        int x = int.Parse(BhpValue.text);
        x++;
        BhpValue.text = x.ToString();
        TotalValue.BhpValue = x;
        PointChange();
    }

    public void HpMinus()
    {
        int x = int.Parse(BhpValue.text);
        x--;
        if (x < 0)
        {
            x = 0;
        }
        BhpValue.text = x.ToString();
        TotalValue.BhpValue = x;
        PointChange();
    }

    // Start is called before the first frame update
    void Start()
    {
        BattackValue.text = TotalValue.BAttackValue.ToString();
        BdefendValue.text = TotalValue.BdefendValue.ToString();
        BhpValue.text = TotalValue.BhpValue.ToString();
        PointChange();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
