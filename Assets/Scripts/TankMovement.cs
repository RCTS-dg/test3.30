using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{

    public float speed = 5;
    public float angularSpeed = 10;
    public int number = 1;
    private Rigidbody rigidbody;

    public AudioClip idleAudio;
    public AudioClip drivingAudio;
    private AudioSource audio;

    private int timeNow = -1;
    private bool set = true;

    void Start()
    {
        if (number==1)
        {
            speed += TotalValue.RAttackValue;
        }
        else
        {
            speed += TotalValue.BAttackValue;
        }
        rigidbody = this.GetComponent<Rigidbody>();
        audio = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (set)
        {
            rigidbody.velocity = transform.forward * Input.GetAxis("Player" + number + "V") * speed;
            rigidbody.angularVelocity = transform.up * Input.GetAxis("Player" + number + "H") * angularSpeed;

            if (Mathf.Abs(Input.GetAxis("Player" + number + "V")) > 0.1 || Mathf.Abs(Input.GetAxis("Player" + number + "H")) > 0.1)
            {
                audio.clip = drivingAudio;
                if (!audio.isPlaying)
                {
                    audio.Play();
                }
            }
            else
            {
                audio.clip = idleAudio;
                if (!audio.isPlaying)
                {
                    audio.Play();
                }
            }
        }


        if (TotalValue.BlueZWLD&&number==2)
        {
            set=false;
            TotalValue.BlueZWLD = false;
            timeNow = TotalValue.timer;
        }
        if (TotalValue.RedZWLD && number == 1)
        {
            set = false;
            TotalValue.RedZWLD = false;
            timeNow = TotalValue.timer;
        }

        if (timeNow!=-1&&TotalValue.timer - timeNow >= 5)
        {
            set = true;
        }
    }

    void ZaWaLuDou()
    {
        if (number==1)
        {
            TotalValue.BlueZWLD = true;//À¶É«ÔÝÍ£
        }
        if (number == 2)
        {
            TotalValue.RedZWLD = true;//ºìÉ«ÔÝÍ£
        }
    }
}
