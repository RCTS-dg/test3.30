using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour
{
    public bool Super = false;
    public GameObject ShellExp;
    public AudioClip ShellExpAudio;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider collider)
    {
        AudioSource.PlayClipAtPoint(ShellExpAudio,transform.position);
        GameObject.Destroy(this.gameObject);
        GameObject.Instantiate(ShellExp,this.transform.position,this.transform.rotation);

        if (collider.tag=="Tank"&&(!Super))
        {
            collider.SendMessage("TakeDamage");
        }

        if (collider.tag == "Tank" &&Super)
        {
            collider.SendMessage("TakeDamage");
            collider.SendMessage("TakeDamage");
            collider.SendMessage("TakeDamage");
        }
    }


}
