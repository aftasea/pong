using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2 : MonoBehaviour
{
    public float speedPerSecond = 20;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up"))
        {
            transform.Translate(0, speedPerSecond * Time.deltaTime, 0);
        }
        if (Input.GetKey("down"))
        {
            transform.Translate(0, -speedPerSecond * Time.deltaTime, 0);
        }
    }
}
