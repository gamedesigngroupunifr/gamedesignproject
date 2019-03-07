using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    private float x = 0.0f;
    private float y = 0.0f;
    public float intensity = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x = 0.0f;
        y = 0.0f;

        if (Input.GetKey(KeyCode.W))
        {
            y = intensity;
        }

        if (Input.GetKey(KeyCode.S))
        {
            y = -intensity;
        }

        if (Input.GetKey(KeyCode.A))
        {
            x = -intensity;
        }

        if (Input.GetKey(KeyCode.D))
        {
            x = intensity;
        }
        
        Physics2D.gravity = new Vector3(x, y, 0.0f);
    }
}
