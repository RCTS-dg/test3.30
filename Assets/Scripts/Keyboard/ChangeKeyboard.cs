using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeKeyboard : MonoBehaviour
{
    private int tf=0;
    public Text keyboard;
    public int number = 1;
    public void Keyboard()
    {
        tf = 1;
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnGUI()
    {
        if (tf==1)
        {
            if (Input.anyKeyDown)
            {
                Event e = Event.current;
                if (e.isKey)
                {
                    keyboard.text = e.keyCode.ToString();
                    ini a = new ini();
                    switch (number)
                    {
                        case 1:
                            TotalValue.RedShot = (int)e.keyCode;
                            a.IniWrite("Keyboard", "RedShot", ((int)e.keyCode).ToString(), "./setting.ini");
                            break;
                        case 2:
                            TotalValue.RedDraw = (int)e.keyCode;
                            a.IniWrite("Keyboard", "RedDraw", ((int)e.keyCode).ToString(), "./setting.ini");
                            break;
                        case 3:
                            TotalValue.BlueShot = (int)e.keyCode;
                            a.IniWrite("Keyboard", "BlueShot", ((int)e.keyCode).ToString(), "./setting.ini");
                            break;
                        case 4:
                            TotalValue.BlueDraw = (int)e.keyCode;
                            a.IniWrite("Keyboard", "BlueDraw", ((int)e.keyCode).ToString(), "./setting.ini");
                            break;
                        case 5:
                            TotalValue.QuitGame = (int)e.keyCode;
                            a.IniWrite("Keyboard", "QuitGame", ((int)e.keyCode).ToString(), "./setting.ini");
                            break;
                        case 6:
                            TotalValue.BackMenu = (int)e.keyCode;
                            a.IniWrite("Keyboard", "BackMenu", ((int)e.keyCode).ToString(), "./setting.ini");
                            break;
                        default:
                            break;
                    }
                    
                    
                    tf = 0;
                }
            }

        }

    }
}
