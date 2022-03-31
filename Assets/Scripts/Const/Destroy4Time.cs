using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy4Time : MonoBehaviour
{
    public float time = 1.5F;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, time);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
