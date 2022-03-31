using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic : MonoBehaviour
{
    private Transform create;
    private int timeRandom;
    private int createNum;
    public GameObject HPPlus;
    public GameObject Energy;
    public GameObject ZaWaLuDou;
    // Start is called before the first frame update
    void Start()
    {
        timeRandom = Random.Range(3, 31);
        createNum = Random.Range(1, 4);
        create = transform.Find("create");
    }

    // Update is called once per frame
    void Update()
    {
        if (TotalValue.timer>=timeRandom)
        {
            switch (createNum)
            {
                case 1:
                    GameObject A = GameObject.Instantiate(HPPlus, create.position, create.rotation) as GameObject;
                    break;
                case 2:
                    GameObject B = GameObject.Instantiate(ZaWaLuDou, create.position, create.rotation) as GameObject;
                    break;
                case 3:
                    GameObject C = GameObject.Instantiate(Energy, create.position, create.rotation) as GameObject;
                    break;
                default:
                    break;
            }
            GameObject.Destroy(this.gameObject);
        }
    }
}
