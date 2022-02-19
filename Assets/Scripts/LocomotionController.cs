using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class LocomotionController : MonoBehaviour
{
    public XRController TeleportRay;
    public InputHelpers.Button teleportActivationButton;
    public float activationthreshhold = 0.1f;

    public bool EnableTeleport { get; set; } = true;


    // Update is called once per frame
    void Update()
    {
        TeleportRay.gameObject.SetActive(EnableTeleport && CheckIfActivated(TeleportRay)); 
    }

    public bool CheckIfActivated(XRController controller)
    {
        InputHelpers.IsPressed(controller.inputDevice, teleportActivationButton, out bool isActivated, activationthreshhold);
        return isActivated;
    }
}
