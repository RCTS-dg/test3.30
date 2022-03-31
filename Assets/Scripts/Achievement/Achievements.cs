using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Achievements : MonoBehaviour
{
    public Image StartGame1;
    public Image StartGame10;
    public Image StartGame20;

    public Image BlueWin1;
    public Image BlueWin5;
    public Image BlueWin10;

    public Image RedWin1;
    public Image RedWin5;
    public Image RedWin10;

    public Image TenSecondsOver;
    public Image SixtySeconds;
    public Image ThreeHundredSeconds;

    // Start is called before the first frame update
    void Start()
    {
/*        ini achi = new ini();
        TotalValue.StartGameTime= int.Parse(achi.IniRead("Achievements", "StartGameTime", "./setting.ini"));
        TotalValue.RedWin = int.Parse(achi.IniRead("Achievements", "RedWin", "./setting.ini"));
        TotalValue.BlueWin = int.Parse(achi.IniRead("Achievements", "BlueWin", "./setting.ini"));
        TotalValue.TenSecondsOver = int.Parse(achi.IniRead("Achievements", "TenSecondsOver", "./setting.ini"));
        TotalValue.SixtySeconds = int.Parse(achi.IniRead("Achievements", "SixtySeconds", "./setting.ini"));
        TotalValue.ThreeHundredSeconds = int.Parse(achi.IniRead("Achievements", "ThreeHundredSeconds", "./setting.ini"));*/

        if (TotalValue.StartGameTime >= 1)
        {
            StartGame1.sprite=Resources.Load("award_yes", typeof(Sprite)) as Sprite;
        }
        if (TotalValue.StartGameTime >= 10)
        {
            StartGame10.sprite = Resources.Load("award_yes", typeof(Sprite)) as Sprite;
        }
        if (TotalValue.StartGameTime >= 20)
        {
            StartGame20.sprite = Resources.Load("award_yes", typeof(Sprite)) as Sprite;
        }


        if (TotalValue.BlueWin >= 1)
        {
            BlueWin1.sprite = Resources.Load("award_yes", typeof(Sprite)) as Sprite;
        }
        if (TotalValue.BlueWin >= 5)
        {
            BlueWin5.sprite = Resources.Load("award_yes", typeof(Sprite)) as Sprite;
        }
        if (TotalValue.BlueWin >= 10)
        {
            BlueWin10.sprite = Resources.Load("award_yes", typeof(Sprite)) as Sprite;
        }


        if (TotalValue.RedWin >= 1)
        {
            RedWin1.sprite = Resources.Load("award_yes", typeof(Sprite)) as Sprite;
        }
        if (TotalValue.RedWin >= 5)
        {
            RedWin5.sprite = Resources.Load("award_yes", typeof(Sprite)) as Sprite;
        }
        if (TotalValue.RedWin >= 10)
        {
            RedWin10.sprite = Resources.Load("award_yes", typeof(Sprite)) as Sprite;
        }


        if (TotalValue.TenSecondsOver !=0)
        {
            TenSecondsOver.sprite = Resources.Load("award_yes", typeof(Sprite)) as Sprite;
        }

        if (TotalValue.SixtySeconds != 0)
        {
            SixtySeconds.sprite = Resources.Load("award_yes", typeof(Sprite)) as Sprite;
        }

        if (TotalValue.ThreeHundredSeconds != 0)
        {
            ThreeHundredSeconds.sprite = Resources.Load("award_yes", typeof(Sprite)) as Sprite;
        }
    }

    // Update is called once per frame
    void Update()
    {

        
    }
}
