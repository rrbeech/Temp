using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public AudioSource boing;

    // Start is called before the first frame update
    void Start()
    {
        boing = GetComponent<AudioSource>();
    
    }

    private void OnCollisionEnter(Collision collision)
    {
        boing.Play();
    }
}
