using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class torch : MonoBehaviour
{
   
    public bool TorchON = false;
    public  GameObject torchLight;
    public GameObject flames;
    public GameObject glow;

 
    void Start()
    {
        torchLight = GameObject.Find("TorchLight").gameObject; //point light source (child)
        flames = GameObject.Find("Flames").gameObject; // Particle flames (child)
        glow = GameObject.Find("Glow").gameObject; // Particle flames (child)

        TorchON = false;
        torchLight.SetActive(false);
        flames.SetActive(false);
        glow.SetActive(false);
    }

    public void turnOnTorch()
    {
        TorchON = true;
        torchLight.SetActive(true);
        flames.SetActive(true);
        glow.SetActive(true);
    }

    public void turnOFFTorch()
    {
        if (TorchON) // This 'IF' is not redundent. It fixes the situation
                          // where the saber is dropped before the blade is turned off
                          // If the blade is already off we don't want to play the powerDown when we drop the saber.
        {
            TorchON = false;
            torchLight.SetActive(false);
            flames.SetActive(false);
            glow.SetActive(false);
        }

    }

}
