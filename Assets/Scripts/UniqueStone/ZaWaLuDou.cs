using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZaWaLuDou : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag.Equals("Tank"))
        {
            collider.SendMessage("ZaWaLuDou");
            Destroy(gameObject);
        }

    }

}
