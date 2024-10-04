using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBackground : MonoBehaviour
{
    public float moveSpeed;
    private float maxDisplacement;
    private float length;
    // public Transform cam;

    // Start is called before the first frame update
    void Start()
    {
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x + moveSpeed * 1e-2f, transform.position.y, transform.position.z);
        
        // if the sprite has gone off the screen, then change its position
        if (transform.position.x > length) {
            transform.position = new Vector3(-length, transform.position.y, transform.position.z);}
    }
}
