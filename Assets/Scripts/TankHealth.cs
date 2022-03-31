using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankHealth : MonoBehaviour
{
    public int number = 1;
    public int hp = 100;
    public GameObject TankExp;
    public AudioClip TankExpAudio;
    public Slider hpSlider;
    public Text RStability;
    public Text BStability;
    public GameObject BlueWin;
    public GameObject RedWin;


    public GameObject BlueWin1;
    public GameObject BlueWin5;
    public GameObject BlueWin10;


    public GameObject RedWin1;
    public GameObject RedWin5;
    public GameObject RedWin10;

    private int hpTotal;

    // Start is called before the first frame update
    void Start()
    {
        if (TotalValue.BleaderNum == 1)
        {
            TotalValue.BStability = 100;
        }
        if (number==1)
        {
            hp += 20 * TotalValue.RhpValue;
        }
        else
        {
            hp += 20 * TotalValue.BhpValue;
        }
        hpTotal = hp;
    }

    // Update is called once per frame
    void Update()
    {
        RStability.text = TotalValue.RStability.ToString();
        BStability.text = TotalValue.BStability.ToString();
    }

    void TakeDamage()
    {
        if (hp<=0)
        {
            return;
        }


        if (number == 1)
        {
            hp = hp - Random.Range(10-TotalValue.RdefendValue, 21- TotalValue.RdefendValue);
        }
        else
        {
            hp = hp - Random.Range(10- TotalValue.BdefendValue, 21- TotalValue.BdefendValue);
        }


        if (hp <= 0)
        {
            if (number == 1 && TotalValue.RStability >= 50)
            {
                hp = hpTotal;
                TotalValue.RStability -= 50;
            }
            else if (number == 2 && TotalValue.BStability >= 50)
            {
                hp = hpTotal;
                TotalValue.BStability -= 50;
            }
        }


        if (hp<=0)
        {
            AudioSource.PlayClipAtPoint(TankExpAudio,transform.position);
            hp = 0;
            if (number==1)
            {
                BlueWin.SetActive(true);
                TotalValue.BlueWin++;
                ini INI = new ini();
                INI.IniWrite("Achievements", "BlueWin", TotalValue.BlueWin.ToString(), "./setting.ini");
                if (TotalValue.BlueWin == 1)
                {
                    BlueWin1.SetActive(true);
                }
                if (TotalValue.BlueWin == 5)
                {
                    BlueWin5.SetActive(true);
                }
                if (TotalValue.BlueWin == 10)
                {
                    BlueWin10.SetActive(true);
                }
            }
            else
            {
                RedWin.SetActive(true);
                TotalValue.RedWin++;
                ini INI = new ini();
                INI.IniWrite("Achievements", "RedWin", TotalValue.RedWin.ToString(), "./setting.ini");
                if (TotalValue.RedWin == 1)
                {
                    RedWin1.SetActive(true);
                }
                if (TotalValue.RedWin == 5)
                {
                    RedWin5.SetActive(true);
                }
                if (TotalValue.RedWin == 10)
                {
                    RedWin10.SetActive(true);
                }
            }
            GameObject.Instantiate(TankExp,transform.position+Vector3.up,transform.rotation);
            GameObject.Destroy(this.gameObject);
        }

        hpSlider.value = (float)hp / hpTotal;
    }


    void HPPlus()
    {
        hp = hpTotal;
        hpSlider.value = (float)hp / hpTotal;
    }


}
