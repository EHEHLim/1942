using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class playermove : MonoBehaviour
{
    private Transform tr;
    private float movespeed = 0.05f;

    void Start()
    {
        tr = GetComponent<Transform>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, movespeed, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -movespeed, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(movespeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-movespeed, 0, 0);
        }
    }
   

}
