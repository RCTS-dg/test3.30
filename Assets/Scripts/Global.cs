using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Global : MonoBehaviour
{
    public GameObject BlueWin;
    public Text Rpp;
    public Text Bpp;
    public GameObject Red;
    public GameObject Blue;
    
    int ppAdd = 0;

    public Text time;
    private int times = 0;

    private int nowtime60;
    public GameObject SixtySeconds;

    private int nowtime300;
    public GameObject ThreeHundredSeconds;

    private int nowtime10;
    public GameObject TenSecondsOver;

    public GameObject BlueWin1;
    public GameObject BlueWin5;
    public GameObject BlueWin10;
    // Start is called before the first frame update
    void Start()
    {



        if (TotalValue.RleaderNum == 3)
        {
            time.color = Color.red;
        }

        if (TotalValue.BleaderNum == 2)
        {
            time.color = Color.blue;
        }
    }

    // Update is called once per frame
    void Update()
    {

        //成就60s
        if (times>=60&&Red&&Blue&&TotalValue.SixtySeconds==0)
        {
            TotalValue.SixtySeconds = 1;
            ini INI = new ini();
            INI.IniWrite("Achievements", "SixtySeconds", "1", "./setting.ini");
            nowtime60 = times;
            SixtySeconds.SetActive(true);

        }
        if (times-nowtime60>=4)
        {
            SixtySeconds.SetActive(false);
        }
        
        //成就300s
        if (times >= 300 && Red && Blue && TotalValue.ThreeHundredSeconds == 0)
        {
            TotalValue.ThreeHundredSeconds = 1;
            ini INI = new ini();
            INI.IniWrite("Achievements", "ThreeHundredSeconds", "1", "./setting.ini");
            nowtime300 = times;
            ThreeHundredSeconds.SetActive(true);

        }
        if (times - nowtime300 >= 4)
        {
            ThreeHundredSeconds.SetActive(false);
        }

        //成就10s
        if (times <=10 && TotalValue.TenSecondsOver == 0&&(!Red||!Blue))
        {
            TotalValue.TenSecondsOver = 1;
            ini INI = new ini();
            INI.IniWrite("Achievements", "TenSecondsOver", "1", "./setting.ini");
            nowtime10 = times;
            TenSecondsOver.SetActive(true);

        }
        if (times - nowtime10 >= 4)
        {
            TenSecondsOver.SetActive(false);
        }


        //技能
        if (TotalValue.RleaderNum == 3&&times >=60)
        {
            TotalValue.RdefendValue = 9;
        }

        if (TotalValue.BleaderNum == 2 && times >=90&&Red)
        {
            BlueWin.SetActive(true);
            GameObject.Destroy(Red);
            TotalValue.BlueWin++;
            ini INI = new ini();
            INI.IniWrite("Achievements", "BlueWin", TotalValue.BlueWin.ToString(), "./setting.ini");
            if (TotalValue.BlueWin==1)
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

        //退出游戏
        if (Input.GetKeyDown((KeyCode)TotalValue.QuitGame))
        {
            Application.Quit();
        }

        //回到开始
        if (Input.GetKeyDown((KeyCode)TotalValue.BackMenu))
        {
            TotalValue.RStability = 30;
            TotalValue.Rpp = 0;
            TotalValue.RdefendValue = 0;
            TotalValue.BStability = 30;
            TotalValue.Bpp = 0;
            TotalValue.BdefendValue = 0;
            TotalValue.timer = 0;
            times = 0;
            TotalValue.BlueZWLD = false;
            TotalValue.RedZWLD = false;
            TotalValue.FirstTeleport = true;
            TotalValue.FirstTeleportOver = false;
            SceneManager.LoadScene("StartMenu");
        }



    }

    void FixedUpdate()
    {
        if (ppAdd >= 50)
        {
            ppAdd = 0;
            if (TotalValue.RleaderNum==1)
            {
                TotalValue.Rpp++;
            }
            TotalValue.Rpp++;
            TotalValue.Bpp++;
            if (TotalValue.BleaderNum == 3&& TotalValue.Bpp< TotalValue.Rpp)
            {
                TotalValue.Rpp--;
                if (TotalValue.RleaderNum == 1)
                {
                    TotalValue.Rpp--;
                }
            }
            times += 1;
            TotalValue.timer = times;
            time.text = times.ToString();

        }
        Rpp.text = TotalValue.Rpp.ToString();
        Bpp.text = TotalValue.Bpp.ToString();
        ppAdd++;
    }
}
