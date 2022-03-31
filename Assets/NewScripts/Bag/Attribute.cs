using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attribute : MonoBehaviour
{
    int x;
    public Text attackMode;
    public Text attackTime;
    public Text defend;
    public Text returnAttack;
    public Text speed;
    public Text attack;

    bool Hweapon;
    bool Hjewelry;
    bool Harmor;
    bool Hshoes;
    // Start is called before the first frame update
    void Start()
    {
        attackTime.text = TotalData.attackTime.ToString();
        defend.text = TotalData.defend.ToString();
        returnAttack.text = TotalData.returnAttack.ToString();
        speed.text = TotalData.speed.ToString();
        attack.text = TotalData.attack.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        GameObject weapon=GameObject.FindGameObjectWithTag("Gweapon");
        if (weapon.GetComponentsInChildren<Transform>(true).Length <= 1)
        {
            Hweapon = false;
            //Debug.Log("没有子物体");
        }
        else
        {
            Hweapon = true;
            ISORNOT(weapon.transform.GetChild(0).name, 1);
        }

        GameObject jewelry = GameObject.FindGameObjectWithTag("Gjewelry");
        if (jewelry.GetComponentsInChildren<Transform>(true).Length <= 1)
        {
            Hjewelry = false;
            //Debug.Log("没有子物体");
        }
        else
        {
            Hjewelry = true;
            ISORNOT(jewelry.transform.GetChild(0).name, 2);
            //Debug.Log(jewelry.transform.GetChild(0));
        }

        GameObject armors = GameObject.FindGameObjectWithTag("Garmor");
        if (armors.GetComponentsInChildren<Transform>(true).Length <= 1)
        {
            Harmor = false;
            //Debug.Log("没有子物体");
        }
        else
        {
            Harmor = true;
            ISORNOT(armors.transform.GetChild(0).name, 3);
            //Debug.Log(armors.transform.GetChild(0));
        }

        GameObject shoes = GameObject.FindGameObjectWithTag("Gshoes");
        if (shoes.GetComponentsInChildren<Transform>(true).Length <= 1)
        {
            Hshoes = false;
            //Debug.Log("没有子物体");
        }
        else
        {
            Hshoes = true;
            ISORNOT(shoes.transform.GetChild(0).name, 4);
            //Debug.Log(shoes.transform.GetChild(0));
        }


        if (!Hweapon)
        {
            attackMode.text = "未装备武器";
            TotalData.NattackTime = TotalData.attackTime;
            TotalData.Nattack = TotalData.attack;
        }
        if (!Hjewelry)
        {
            TotalData.NreturnAttack = TotalData.returnAttack;
        }
        if (!Harmor)
        {
            TotalData.Ndefend = TotalData.defend;
        }
        if (!Hshoes)
        {
            TotalData.Nspeed = TotalData.speed;
        }
        attackTime.text =TotalData.NattackTime.ToString();
        defend.text = TotalData.Ndefend.ToString();
        returnAttack.text = TotalData.NreturnAttack.ToString();
        speed.text = TotalData.Nspeed.ToString();
        attack.text = TotalData.Nattack.ToString();
    }

    void ISORNOT(string TTname, int th)
    {
        switch (TTname)
        {
            case "test0":
                x = 0;
                break;
            case "test1":
                x = 1;
                break;
            case "test2":
                x = 2;
                break;
            case "test3":
                x = 3;
                break;
            case "test4":
                x = 4;
                break;
            case "test5":
                x = 5;
                break;
            case "test6":
                x = 6;
                break;
            case "test7":
                x = 7;
                break;
            case "test8":
                x = 8;
                break;
            case "test9":
                x = 9;
                break;
            default:
                x = -1;
                break;
        }
        switch (TotalData.list1[x])
        {
            case 1:
                if (TotalData.weapon[TotalData.list2[x]].magic)
                {
                    attackMode.text = "远程";
                }
                else
                {
                    attackMode.text = "近战";
                }
                TotalData.NattackTime = TotalData.attackTime + TotalData.weapon[TotalData.list2[x]].delayTime;
                TotalData.Nattack = TotalData.attack + TotalData.weapon[TotalData.list2[x]].damage;
                //TotalData.weapon[x];
                break;
            case 2:
                TotalData.NreturnAttack = TotalData.returnAttack + TotalData.jewelry[TotalData.list2[x]].returnDamage;
                break;
            case 3:
                TotalData.Ndefend = TotalData.defend + TotalData.armors[TotalData.list2[x]].defend;
                break;
            case 4:
                TotalData.Nspeed = TotalData.speed + TotalData.shoes[TotalData.list2[x]].speed;
                break;
            default:
                break;
        }
    }
}
