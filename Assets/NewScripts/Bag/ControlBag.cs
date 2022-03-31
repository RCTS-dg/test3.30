using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class ControlBag : MonoBehaviour
{
    public GameObject bag;
    private bool bagState = true;
    public int type;
    public int id;

    public GameObject item1X;
    public GameObject item2X;
    public GameObject item3X;
    public GameObject item4X;
    public GameObject item5X;
    public GameObject item6X;
    public GameObject item7X;
    public GameObject item8X;
    public GameObject item9X;

    public Image item1;
    public Image item2;
    public Image item3;
    public Image item4;
    public Image item5;
    public Image item6;
    public Image item7;
    public Image item8;
    public Image item9;
    // Start is called before the first frame update
    void Start()
    {
        NewIni ini = new NewIni("./item.ini");
        TotalData.number = int.Parse(ini.IniRead("Total", "number"));
        for (int i = 0; i < TotalData.number; i++)
        {
            switch (int.Parse(ini.IniRead("Thing" + (i + 1), "type")))
            {
                case 1://ÎäÆ÷
                    TotalData.weapon[TotalData.index[0]] = new Weapon();
                    TotalData.weapon[TotalData.index[0]].locate = int.Parse(ini.IniRead("Thing" + (i + 1), "locate"));
                    TotalData.weapon[TotalData.index[0]].tName = ini.IniRead("Thing" + (i + 1), "name");
                    TotalData.weapon[TotalData.index[0]].picName = ini.IniRead("Thing" + (i + 1), "picName");
                    TotalData.weapon[TotalData.index[0]].whatisthis = ini.IniRead("Thing" + (i + 1), "whatisthis");
                    TotalData.weapon[TotalData.index[0]].delayTime = float.Parse(ini.IniRead("Thing" + (i + 1), "delayTime"));
                    TotalData.weapon[TotalData.index[0]].damage = float.Parse(ini.IniRead("Thing" + (i + 1), "damage"));
                    TotalData.weapon[TotalData.index[0]].magic = bool.Parse(ini.IniRead("Thing" + (i + 1), "magic"));
                    ChangePic(TotalData.weapon[TotalData.index[0]].locate, TotalData.weapon[TotalData.index[0]].picName);
                    TotalData.list1[i] = 1;
                    TotalData.list2[i] = TotalData.index[0];
                    TotalData.index[0]++;
                    break;
                case 2:

                    TotalData.jewelry[TotalData.index[1]] = new Jewelry();
                    TotalData.jewelry[TotalData.index[1]].locate = int.Parse(ini.IniRead("Thing" + (i + 1), "locate"));
                    TotalData.jewelry[TotalData.index[1]].tName = ini.IniRead("Thing" + (i + 1), "name");
                    TotalData.jewelry[TotalData.index[1]].picName = ini.IniRead("Thing" + (i + 1), "picName");
                    TotalData.jewelry[TotalData.index[1]].whatisthis = ini.IniRead("Thing" + (i + 1), "whatisthis");
                    TotalData.jewelry[TotalData.index[1]].returnDamage = float.Parse(ini.IniRead("Thing" + (i + 1), "returnDamage"));
                    ChangePic(TotalData.jewelry[TotalData.index[1]].locate, TotalData.jewelry[TotalData.index[1]].picName);
                    TotalData.list1[i] = 2;
                    TotalData.list2[i] = TotalData.index[1];
                    TotalData.index[1]++;
                    break;
                case 3:

                    TotalData.armors[TotalData.index[2]] = new Armor();
                    TotalData.armors[TotalData.index[2]].locate = int.Parse(ini.IniRead("Thing" + (i + 1), "locate"));
                    TotalData.armors[TotalData.index[2]].tName = ini.IniRead("Thing" + (i + 1), "name");
                    TotalData.armors[TotalData.index[2]].picName = ini.IniRead("Thing" + (i + 1), "picName");
                    TotalData.armors[TotalData.index[2]].whatisthis = ini.IniRead("Thing" + (i + 1), "whatisthis");
                    TotalData.armors[TotalData.index[2]].defend = float.Parse(ini.IniRead("Thing" + (i + 1), "defend"));

                    ChangePic(TotalData.armors[TotalData.index[2]].locate, TotalData.armors[TotalData.index[2]].picName);
                    TotalData.list1[i] = 3;
                    TotalData.list2[i] = TotalData.index[2];
                    TotalData.index[2]++;
                    break;
                case 4:

                    TotalData.shoes[TotalData.index[3]] = new Shoes();
                    TotalData.shoes[TotalData.index[3]].locate = int.Parse(ini.IniRead("Thing" + (i + 1), "locate"));
                    TotalData.shoes[TotalData.index[3]].tName = ini.IniRead("Thing" + (i + 1), "name");
                    TotalData.shoes[TotalData.index[3]].picName = ini.IniRead("Thing" + (i + 1), "picName");
                    TotalData.shoes[TotalData.index[3]].whatisthis = ini.IniRead("Thing" + (i + 1), "whatisthis");
                    TotalData.shoes[TotalData.index[3]].speed = float.Parse(ini.IniRead("Thing" + (i + 1), "speed"));

                    ChangePic(TotalData.shoes[TotalData.index[3]].locate, TotalData.shoes[TotalData.index[3]].picName);
                    TotalData.list1[i] = 4;
                    TotalData.list2[i] = TotalData.index[3];
                    TotalData.index[3]++;
                    break;
                default:
                    throw new System.Exception("QAQ");
                    break;
            }
        }


    }

    void ChangePic(int locate, string picName)
    {
        switch (locate)
        {
            case 1:
                item1.sprite = Resources.Load(picName, typeof(Sprite)) as Sprite;
                item1X.name = "test"+ (locate-1);
                break;
            case 2:
                item2.sprite = Resources.Load(picName, typeof(Sprite)) as Sprite;
                item2X.name = "test" + (locate - 1);
                break;
            case 3:
                item3.sprite = Resources.Load(picName, typeof(Sprite)) as Sprite;
                item3X.name = "test" + (locate - 1);
                break;
            case 4:
                item4.sprite = Resources.Load(picName, typeof(Sprite)) as Sprite;
                item4X.name = "test" + (locate - 1);
                break;
            case 5:
                item5.sprite = Resources.Load(picName, typeof(Sprite)) as Sprite;
                item5X.name = "test" + (locate - 1);
                break;
            case 6:
                item6.sprite = Resources.Load(picName, typeof(Sprite)) as Sprite;
                item6X.name = "test" + (locate - 1);
                break;
            case 7:
                item7.sprite = Resources.Load(picName, typeof(Sprite)) as Sprite;
                item7X.name = "test" + (locate - 1);
                break;
            case 8:
                item8.sprite = Resources.Load(picName, typeof(Sprite)) as Sprite;
                item8X.name = "test" + (locate - 1);
                break;
            case 9:
                item9.sprite = Resources.Load(picName, typeof(Sprite)) as Sprite;
                item9X.name = "test" + (locate - 1);
                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (bagState)
            {
                bag.SetActive(true);
                Time.timeScale = 0;
                bagState = false;
            }
            else
            {
                bag.SetActive(false);
                Time.timeScale = 1;
                bagState = true;
            }

        }
    }
}
