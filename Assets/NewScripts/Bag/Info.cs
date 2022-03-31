using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Info : MonoBehaviour
{
    bool isShowInfo;
    public GUIStyle _GUIStyle;
    public float Offset = 15;
    public string info = "Ãû×Ö";
    // Use this for initialization
    void Start()
    {
        isShowInfo = false;

    }
    void OnMouseEnter()
    {
        isShowInfo = true;
        // print("onmouseenter");
    }
    void OnMouseExit()
    {
        isShowInfo = false;
        // print("onmouseexit");
    }

    // Update is called once per frame
    void Update()
    {
        if (isShowInfo)
        {
            print("123");
            GUI.Label(new Rect(Input.mousePosition.x + Offset, Screen.height - Input.mousePosition.y, 100, 100), info, _GUIStyle);
        }
    }

}
