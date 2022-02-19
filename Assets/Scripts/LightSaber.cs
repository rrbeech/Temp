using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSaber : MonoBehaviour
{
    public Animator LightSaberAnimator;
    public AudioSource audioSource;
    public AudioSource audioSourceAux;
    public AudioClip hum;
    public AudioClip powerUp;
    public AudioClip powerDown;
    public AudioClip collisionSound;
    private bool LightSaberON = false;

    public void turnOnLightSaber()
    {
        LightSaberAnimator.SetTrigger("Turn Light Saber ON");
        LightSaberAnimator.ResetTrigger("Turn Light Saber OFF"); // Reset trigger
        LightSaberON = true;

        audioSource.PlayOneShot(hum); //play the steady hum
        audioSourceAux.PlayOneShot(powerUp); //play the powerup
    }

    public void turnOFFLightSaber()
    {
        if (LightSaberON) // This 'IF' is not redundent. It fixes the situation
                        // where the saber is dropped before the blade is turned off
                        // If the blade is already off we don't want to play the powerDown when we drop the saber.
        {
            LightSaberAnimator.SetTrigger("Turn Light Saber OFF");
            LightSaberAnimator.ResetTrigger("Turn Light Saber ON"); //Reset trigger
            LightSaberON = false;

            audioSource.Stop();//turn off hum
            audioSourceAux.PlayOneShot(powerDown);
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (LightSaberON) //play collision sound only if blade turned on
            audioSourceAux.PlayOneShot(collisionSound);
    }
}
