 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up"))
        {
            Debug.Log("UP");
        }

        if (Input.GetKey("down"))
        {
            Debug.Log("DOWN");
        }

        if (Input.GetKey("left"))
        {
            Debug.Log("LEFT");
        }

        if (Input.GetKey("right"))
        {
            Debug.Log("RIGHT");
        }

        if (Input.GetKey("space"))
        {
            Debug.Log("SPACE");
        }
    }
}
