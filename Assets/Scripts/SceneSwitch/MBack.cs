using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MBack : MonoBehaviour
{
    public Text RTotalPointValue;
    public Text BTotalPointValue;
    public void OnClick()
    {
        if (TotalValue.RleaderNum==3&& TotalValue.BleaderNum == 2)
        {
            return;
        }
        if (int.Parse(RTotalPointValue.text)>=0&& int.Parse(BTotalPointValue.text) >= 0)
        {
            SceneManager.LoadScene("StartMenu");
        }
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
