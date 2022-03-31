using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Load : MonoBehaviour
{
    public GameObject StartGame1;
    public GameObject StartGame10;
    public GameObject StartGame20;
    private int time = 0;
    bool achiYes = false;
    // Start is called before the first frame update
    void Start()
    {
        ini achi = new ini();
        TotalValue.StartGameTime = int.Parse(achi.IniRead("Achievements", "StartGameTime", "./setting.ini"));
        TotalValue.RedWin = int.Parse(achi.IniRead("Achievements", "RedWin", "./setting.ini"));
        TotalValue.BlueWin = int.Parse(achi.IniRead("Achievements", "BlueWin", "./setting.ini"));
        TotalValue.TenSecondsOver = int.Parse(achi.IniRead("Achievements", "TenSecondsOver", "./setting.ini"));
        TotalValue.SixtySeconds = int.Parse(achi.IniRead("Achievements", "SixtySeconds", "./setting.ini"));
        TotalValue.ThreeHundredSeconds = int.Parse(achi.IniRead("Achievements", "ThreeHundredSeconds", "./setting.ini"));

        if (TotalValue.FirstStartGame)
        {
            TotalValue.StartGameTime += 1;
            achi.IniWrite("Achievements", "StartGameTime", TotalValue.StartGameTime.ToString(), "./setting.ini");
            if (TotalValue.StartGameTime == 1)
            {
                StartGame1.SetActive(true);
                achiYes = true;
            }
            if (TotalValue.StartGameTime == 10)
            {
                StartGame10.SetActive(true);
                achiYes = true;
            }
            if (TotalValue.StartGameTime == 20)
            {
                StartGame20.SetActive(true);
                achiYes = true;
            }
            TotalValue.FirstStartGame = false;
        }

        ini a = new ini();
        TotalValue.RedShot = int.Parse(a.IniRead("Keyboard", "RedShot", "./setting.ini"));
        TotalValue.RedDraw = int.Parse(a.IniRead("Keyboard", "RedDraw", "./setting.ini"));
        TotalValue.BlueShot = int.Parse(a.IniRead("Keyboard", "BlueShot", "./setting.ini"));
        TotalValue.BlueDraw = int.Parse(a.IniRead("Keyboard", "BlueDraw", "./setting.ini"));
        TotalValue.QuitGame = int.Parse(a.IniRead("Keyboard", "QuitGame", "./setting.ini"));
        TotalValue.BackMenu = int.Parse(a.IniRead("Keyboard", "BackMenu", "./setting.ini"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (achiYes)
        {
            if (time == 50 * 4)
            {
                StartGame1.SetActive(false);
                StartGame10.SetActive(false);
                StartGame20.SetActive(false);
                achiYes = false;
            }
            time++;
        }
    }
}
