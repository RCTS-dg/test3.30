using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5;
    public float angularSpeed = 10;
    public int number = 1;
    private Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.velocity = transform.forward * Input.GetAxis("Player" + number + "V") * speed;
        rigidbody.angularVelocity = transform.up * Input.GetAxis("Player" + number + "H") * angularSpeed;
    }
}
