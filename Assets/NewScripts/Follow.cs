using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform player;

    private Vector3 offset;

    private Camera camera;
    
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.position;
        camera =this.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {

            transform.position = player.position + offset;
            camera.orthographicSize = 10;
    }
}
