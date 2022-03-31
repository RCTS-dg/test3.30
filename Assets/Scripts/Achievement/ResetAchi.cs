using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetAchi : MonoBehaviour
{
    public void Reset()
    {
        ini achi = new ini();
        achi.IniWrite("Achievements", "StartGameTime", "0", "./setting.ini");
        achi.IniWrite("Achievements", "RedWin", "0", "./setting.ini");
        achi.IniWrite("Achievements", "BlueWin", "0", "./setting.ini");
        achi.IniWrite("Achievements", "TenSecondsOver", "0", "./setting.ini");
        achi.IniWrite("Achievements", "SixtySeconds", "0", "./setting.ini");
        achi.IniWrite("Achievements", "ThreeHundredSeconds", "0", "./setting.ini");
        SceneManager.LoadScene("StartMenu");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
