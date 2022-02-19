using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float speed = -8;
    public GameObject bullet;
    public Transform barrel;
    public AudioSource audioSource;
    public AudioClip gunshot;
    private Quaternion flip = Quaternion(0, 0, 90);//flip plane 90 degrees

    public Gun(Quaternion flip)
    {
        this.flip = flip;
    }

    private static Quaternion Quaternion(int v1, int v2, int v3)
    {
        throw new NotImplementedException();
    }

    public void Fire()
    {
        // GameObject spawnedBullet = Instantiate(bullet, barrel.position + Vector3(-.06f,0f,0f), barrel.rotation);
        GameObject spawnedBullet = Instantiate(bullet, barrel.position, barrel.rotation * flip);
        spawnedBullet.GetComponent<Rigidbody>().velocity = speed * barrel.forward;
      //Debug.Log("speed = " + speed + "barrel.forward = " + barrel.forward);

        audioSource.PlayOneShot(gunshot);
        Destroy(spawnedBullet,3);
    }

    private Vector3 Vector3(float v1, float v2, float v3)
    {
        throw new NotImplementedException();
    }
}
