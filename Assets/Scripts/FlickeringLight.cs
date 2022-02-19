//	Name			Chau Tran
//	Last Modified	Feb 7th,2015

using UnityEngine;
using System.Collections;

public class FlickeringLight : MonoBehaviour
{


    Light testLight;
    public float minWaitTime;
    public float maxWaitTime;
    public float variation = 0.5f;
    private float baseIntensity;

    void Start()
    {
        testLight = GetComponent<Light>();
        baseIntensity = testLight.intensity;
        StartCoroutine(Flashing());
    }

    IEnumerator Flashing()
    {
        testLight.intensity = baseIntensity + Random.Range(-variation, +variation);
        yield return new WaitForSeconds(Random.Range(minWaitTime, maxWaitTime));
     }
}