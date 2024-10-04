using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraController : MonoBehaviour
{
    
    public GameObject background;
    public float scrollSpeed = 3f;
    public float boundary = 15.2f;
    // private float length;
    


    // Start is called before the first frame update
    void Start()
    {
        // length = background.GetComponent<SpriteRenderer>().bounds.size.x;
        
        // Debug.Log("The length is " + length);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horz = Input.GetAxis("Horizontal");
        
        // if you're not on the edge of the screen, then you can move left and right!
        
        float x = Mathf.Clamp(transform.position.x + scrollSpeed * horz * 1e-2f, -boundary, boundary);
        transform.position = new Vector3(x, transform.position.y, transform.position.z);
    }
}
