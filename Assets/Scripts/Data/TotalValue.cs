using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotalValue : MonoBehaviour
{

    //属性
    public static int RAttackValue=0;
    public static int RdefendValue = 0;
    public static int RhpValue = 0;
    public static string Rleader = "斯大林";
    public static int RleaderNum = 1;
    public static int RStability = 30;
    public static int Rpp = 0;

    //按键修改
    public static int RedShot = 32;
    public static int RedDraw = 9;

    //属性
    public static int BAttackValue = 0;
    public static int BdefendValue = 0;
    public static int BhpValue = 0;
    public static string Bleader = "威廉二世";
    public static int BleaderNum = 1;
    public static int BStability = 30;
    public static int Bpp = 0;

    //按键修改
    public static int BlueShot = 112;
    public static int BlueDraw = 108;
    public static int QuitGame = 104;//H
    public static int BackMenu = 106;//J


    //成就系统
    public static int StartGameTime = 0;
    public static int RedWin = 0;
    public static int BlueWin = 0;
    public static int TenSecondsOver = 0;
    public static int SixtySeconds = 0;
    public static int ThreeHundredSeconds = 0;

    //后来加的全局计时器
    public static int timer = 0;

    public static bool RedZWLD = false;
    public static bool BlueZWLD = false;

    public static bool FirstStartGame=true;

    public static bool FirstTeleport = true;
    public static bool FirstTeleportOver = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
