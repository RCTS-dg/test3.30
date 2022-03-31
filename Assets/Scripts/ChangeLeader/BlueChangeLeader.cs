using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlueChangeLeader : MonoBehaviour
{
    public Image BedLeader;


    public void ChangeLeader()
    {
        TotalValue.BleaderNum++;
        if (TotalValue.BleaderNum == 4)
        {
            TotalValue.BleaderNum = 1;
        }
        switch (TotalValue.BleaderNum)
        {
            case 1:
                TotalValue.Bleader = "ÍþÁ®¶þÊÀ";
                break;
            case 2:
                TotalValue.Bleader = "Ï£Ä·À³";
                break;
            case 3:
                TotalValue.Bleader = "ÂõÒ®";
                break;
            default:
                break;
        }
        BedLeader.sprite = Resources.Load("blue/" + TotalValue.Bleader, typeof(Sprite)) as Sprite;
    }
    // Start is called before the first frame update
    void Start()
    {
        BedLeader.sprite = Resources.Load("blue/" + TotalValue.Bleader, typeof(Sprite)) as Sprite;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
