using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RedChangeLeader : MonoBehaviour
{
    public Image RedLeader;


    public void ChangeLeader()
    {
        TotalValue.RleaderNum++;
        if (TotalValue.RleaderNum==5)
        {
            TotalValue.RleaderNum = 1;
        }
        switch (TotalValue.RleaderNum)
        {
            case 1:
                TotalValue.Rleader = "˹����";
                break;
            case 2:
                TotalValue.Rleader = "������";
                break;
            case 3:
                TotalValue.Rleader = "����Ļ�";
                break;
            case 4:
                TotalValue.Rleader = "vladimir III";
                break;
            default:
                break;
        }
        RedLeader.sprite = Resources.Load("red/" + TotalValue.Rleader, typeof(Sprite)) as Sprite;
    }
    // Start is called before the first frame update
    void Start()
    {
        RedLeader.sprite = Resources.Load("red/"+TotalValue.Rleader, typeof(Sprite)) as Sprite;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
