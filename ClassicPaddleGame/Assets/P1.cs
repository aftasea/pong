﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1 : MonoBehaviour
{
    public float speedPerSecond = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            transform.Translate(0, speedPerSecond * Time.deltaTime, 0);
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(0, -speedPerSecond * Time.deltaTime, 0);
        }
    }
}
