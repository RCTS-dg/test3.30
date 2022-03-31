using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RedPoint : MonoBehaviour
{
    public Text RattackValue;
    public Text RdefendValue;
    public Text RhpValue;
    public Text RTotalPointValue;
    public int RPointValue = 5;

    void PointChange()
    {
        if (TotalValue.RleaderNum == 4)
        {
            int x = RPointValue +3 - int.Parse(RattackValue.text) - int.Parse(RdefendValue.text) - int.Parse(RhpValue.text);
            RTotalPointValue.text = x.ToString();
        }
        else
        {
            int x = RPointValue - int.Parse(RattackValue.text) - int.Parse(RdefendValue.text) - int.Parse(RhpValue.text);
            RTotalPointValue.text = x.ToString();
        }
    }
    public void AttackAdd()
    {
        int x = int.Parse(RattackValue.text);
        x++;
        RattackValue.text = x.ToString();
        TotalValue.RAttackValue = x;
        PointChange();
    }

    public void AttackMinus()
    {
        int x = int.Parse(RattackValue.text);
        x--;
        if (x<0)
        {
            x = 0;
        }
        RattackValue.text = x.ToString();
        TotalValue.RAttackValue = x;
        PointChange();
    }

    public void DefendAdd()
    {
        int x = int.Parse(RdefendValue.text);
        x++;
        RdefendValue.text = x.ToString();
        TotalValue.RdefendValue = x;
        PointChange();
    }

    public void DefendMinus()
    {
        int x = int.Parse(RdefendValue.text);
        x--;
        if (x < 0)
        {
            x = 0;
        }
        RdefendValue.text = x.ToString();
        TotalValue.RdefendValue = x;
        PointChange();
    }

    public void HpAdd()
    {
        int x = int.Parse(RhpValue.text);
        x++;
        RhpValue.text = x.ToString();
        TotalValue.RhpValue = x;
        PointChange();
    }

    public void HpMinus()
    {
        int x = int.Parse(RhpValue.text);
        x--;
        if (x < 0)
        {
            x = 0;
        }
        RhpValue.text = x.ToString();
        TotalValue.RhpValue = x;
        PointChange();
    }

    // Start is called before the first frame update
    void Start()
    {
        RattackValue.text = TotalValue.RAttackValue.ToString();
        RdefendValue.text = TotalValue.RdefendValue.ToString();
        RhpValue.text = TotalValue.RhpValue.ToString();
        PointChange();
    }

    // Update is called once per frame
    void Update()
    {
        PointChange();
    }
}
