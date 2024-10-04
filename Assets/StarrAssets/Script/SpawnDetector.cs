using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDetector : MonoBehaviour
{
    public GameObject line;
    // SHOTS VARIABLE TO HERE!!!!
    public int shots;
    private float y_position;

    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Spawn()
    {
        // change the position of the middle excellent setting here!!!
        y_position = 0;
        if (shots == 1)
        {
            y_position = -3;
        }
        else if (shots == 2)
        {
            y_position = -1;
        }
        Instantiate(line, new Vector3(0, y_position, 0), Quaternion.identity);
    }
}
