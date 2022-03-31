using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShot : MonoBehaviour
{
    private Transform ShotPosition;
    public AudioClip ShotAudio;
    private KeyCode shotKeyCode;
    public GameObject shellPrefab;
    public GameObject superShellPrefab;
    public int number = 1;
    public float ShellSpeed = 20;
    public bool super = false;
    public int timerNow=-1;

    void Start()
    {
        ShotPosition = transform.Find("ShotPosition");
        if (number==1)
        {
            shotKeyCode = (KeyCode)TotalValue.RedShot;
        }
        else
        {
            shotKeyCode = (KeyCode)TotalValue.BlueShot;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(shotKeyCode)&&(!super))
        {
            AudioSource.PlayClipAtPoint(ShotAudio, transform.position);
            GameObject GO=GameObject.Instantiate(shellPrefab,ShotPosition.position,ShotPosition.rotation) as GameObject;
            GO.GetComponent<Rigidbody>().velocity = GO.transform.forward * ShellSpeed;
        }
        if (Input.GetKeyDown(shotKeyCode) && super)
        {
            AudioSource.PlayClipAtPoint(ShotAudio, transform.position);
            GameObject GO = GameObject.Instantiate(superShellPrefab, ShotPosition.position, ShotPosition.rotation) as GameObject;
            GO.GetComponent<Rigidbody>().velocity = GO.transform.forward * ShellSpeed;
        }

        if (timerNow!=-1&&TotalValue.timer-timerNow>=15)
        {
            super = false;
            timerNow = -1;
        }
    }

    void Energy()
    {
        super = true;
        timerNow = TotalValue.timer;
    }

    void TShot()
    {
        Debug.Log("222");
        GameObject GO = GameObject.Instantiate(shellPrefab, ShotPosition.position, ShotPosition.rotation) as GameObject;
        GO.GetComponent<Rigidbody>().velocity = GO.transform.forward * ShellSpeed;
    }
}
