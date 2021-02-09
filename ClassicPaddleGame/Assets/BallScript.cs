using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class BallScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rigidb = GetComponent<Rigidbody>();
        if (rigidb)
        {
            rigidb.freezeRotation = true;
        }
        StartCoroutine("Waitforit");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Waitforit()
    {
        Rigidbody rigidb = GetComponent<Rigidbody>();
        yield return new WaitForSeconds(3);
        if (rigidb)
        {
            rigidb.AddForce(Random.Range(6, 8), Random.Range(-4, -3), 0);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
    }
}
