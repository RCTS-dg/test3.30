using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyboardInitialization : MonoBehaviour
{
    public Text keyboard1;
    public Text keyboard2;
    public Text keyboard3;
    public Text keyboard4;
    public Text keyboard5;
    public Text keyboard6;
    // Start is called before the first frame update
    void Start()
    {
        ini a = new ini();
        
        keyboard1.text = ((KeyCode)(int.Parse(a.IniRead("Keyboard", "RedShot", "./setting.ini")))).ToString();
        TotalValue.RedShot = int.Parse(a.IniRead("Keyboard", "RedShot", "./setting.ini"));

        keyboard2.text = ((KeyCode)(int.Parse(a.IniRead("Keyboard", "RedDraw", "./setting.ini")))).ToString();
        TotalValue.RedDraw = int.Parse(a.IniRead("Keyboard", "RedDraw", "./setting.ini"));

        keyboard3.text = ((KeyCode)(int.Parse(a.IniRead("Keyboard", "BlueShot", "./setting.ini")))).ToString();
        TotalValue.BlueShot = int.Parse(a.IniRead("Keyboard", "BlueShot", "./setting.ini"));

        keyboard4.text = ((KeyCode)(int.Parse(a.IniRead("Keyboard", "BlueDraw", "./setting.ini")))).ToString();
        TotalValue.BlueDraw = int.Parse(a.IniRead("Keyboard", "BlueDraw", "./setting.ini"));

        keyboard5.text = ((KeyCode)(int.Parse(a.IniRead("Keyboard", "QuitGame", "./setting.ini")))).ToString();
        TotalValue.QuitGame = int.Parse(a.IniRead("Keyboard", "QuitGame", "./setting.ini"));

        keyboard6.text = ((KeyCode)(int.Parse(a.IniRead("Keyboard", "BackMenu", "./setting.ini")))).ToString();
        TotalValue.BackMenu = int.Parse(a.IniRead("Keyboard", "BackMenu", "./setting.ini"));
        //Debug.Log(TotalValue.RedShot + "qqq" + TotalValue.RedDraw + "qqq" + TotalValue.BlueShot + "qqq" + TotalValue.BlueDraw + "qqq");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
